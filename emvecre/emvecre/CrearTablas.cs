
//bibliotecas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Net;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System.Drawing;


namespace emvecre
{
    class crearTablas

    {
        //crear tabla de detalle de ventas
        public static string tabla_detalle_ventas = "detalle_ventas";

        public const string Cad_Grid_detalle_ventas = "idDetalle_venta,idVenta,codigo1,cantidad,precio_venta,descuento";

        public static void crear_tabla_detalle_ventas()
        {
            ConexSQL objMiconexion = new ConexSQL();

            String sql = "IF NOT EXISTS (select name from sysobjects where name ='" + tabla_detalle_ventas + "') CREATE TABLE " + tabla_detalle_ventas + "(idDetalle_venta int IDENTITY(1,1) not null, idVenta int NOT NULL,codigo1 nvarchar(50) NOT NULL," +
                "cantidad numeric(10,2) NOT NULL, precio_venta numeric(10,2) NOT NULL, descuento numeric(10,2) NOT NULL, PRIMARY KEY(idDetalle_venta) );";
            objMiconexion.ejecutarSentenciaSql(sql);
        }

        //crear tabla de ventas
        public static string tablaVentas = "ventas";

        public const string Cad_Grid_ventas = "idVenta,idCliente,idVendedor,tipoPago,fecha,total,estado";

        public static void crear_tabla_ventas()
        {
            ConexSQL objMiconexion = new ConexSQL();

            String sql = "IF NOT EXISTS (select name from sysobjects where name ='" + tablaVentas + "') CREATE TABLE " + tablaVentas + "(idVenta int IDENTITY(1,1) not null, idCliente int NOT NULL,idVendedor int NOT NULL," +
                "tipoPago nvarchar(15) NOT NUll,fecha smalldatetime NOT NULL , total numeric(10,2) NOT NULL, estado nvarchar(2), PRIMARY KEY(idVenta) );";
            objMiconexion.ejecutarSentenciaSql(sql);
        }


        //crear tabla de clientes
        public static string tablaClientes = "clientes";

        public const string Cad_Grid_clientes = "idCliente,nombre_cliente,fecha_nacimiento,cedula,direccion_cliente,telefono_cliente,email_cliente";

        public static void crear_tabla_clientes()
        {
            ConexSQL objMiconexion = new ConexSQL();

            String sql = "IF NOT EXISTS (select name from sysobjects where name ='" + tablaClientes + "') CREATE TABLE " + tablaClientes + "(idCliente int IDENTITY(1,1) not null, nombre_cliente nvarchar(50) NOT NULL, fecha_nacimiento Date," +
                "cedula nvarchar(10) NOT NULL, direccion_cliente nvarchar(256), telefono_cliente nvarchar(50), email_cliente nvarchar(100), PRIMARY KEY(idCliente) );";
            objMiconexion.ejecutarSentenciaSql(sql);


        }

        //crear tabla para los departamentos
        public static string tablaDepartamento = "departamento";

        public const string Cad_Grid_departamento = "idDepartamento,nombre,descripcion";

        public static void crear_tabla_departamentos()
        {
            ConexSQL objMiconexion = new ConexSQL();

            String sql = "IF NOT EXISTS (select name from sysobjects where name ='" + tablaDepartamento + "') CREATE TABLE " + tablaDepartamento + "(idDepartamento int IDENTITY(1,1) not null," +
                "nombre nvarchar(50) NOT NULL, descripcion nvarchar(256), PRIMARY KEY(idDepartamento) );";
            objMiconexion.ejecutarSentenciaSql(sql);
        }


        //crear tabla para los articulos
        public static string tablaArticulo = "Articulos";

        public const string Cad_Grid_articulo = "idArticulo,codigo1,codigo2,nombre,costo,precio,cantidad_stock,idDepartamento,impuesto";

        public static void crear_tabla_articulos()
        {
            ConexSQL objMiconexion = new ConexSQL();

            String sql = "IF NOT EXISTS (select name from sysobjects where name ='" + tablaArticulo + "') CREATE TABLE " + tablaArticulo + "(idArticulo int IDENTITY(1,1) not null, codigo1 nvarchar(50) NOT NULL, codigo2 nvarchar(50)," +
                "nombre nvarchar(50) NOT NULL, cantidad_stock numeric(10,2) not null,idDepartamento int not null,costo numeric(10,2) not null,precio numeric(10,2) not null, impuesto nvarchar(7),  PRIMARY KEY(codigo1) );";
            objMiconexion.ejecutarSentenciaSql(sql);
        }

        //crear tabla para los proveedores
        public static string tablaProveedor = "Proveedores";

        public const string Cad_Grid_proveedor = "idProveedor,razon_social,sector_comercial,tipo_documento,num_documento,direccion,telefono,email,url";

        public static void crear_tabla_proveedor()
        {
            ConexSQL objMiconexion = new ConexSQL();

            String sql = "IF NOT EXISTS (select name from sysobjects where name ='" + tablaProveedor + "') CREATE TABLE " + tablaProveedor + "(idProveedor int IDENTITY(1,1) not null, razon_social nvarchar(100) NOT NULL, sector_comercial nvarchar(100)," +
                "tipo_documento nvarchar(50) NOT NULL, num_documento nvarchar(256), direccion nvarchar(256), telefono nvarchar(50), email nvarchar(50), URL nvarchar(100),  PRIMARY KEY(idProveedor) );";
            objMiconexion.ejecutarSentenciaSql(sql);
        }

        //crear tabla para los departamentos
        public static string tablaVendedor = "vendedor";

        public const string Cad_Grid_vendedor = "idVendedor,nombre";

        public static void crear_tabla_vendedor()
        {
            ConexSQL objMiconexion = new ConexSQL();

            String sql = "IF NOT EXISTS (select name from sysobjects where name ='" + tablaVendedor + "') CREATE TABLE " + tablaVendedor + "(idVendedor int IDENTITY(1,1) not null," +
                "nombre nvarchar(50) NOT NULL, PRIMARY KEY(idVendedor) );";
            objMiconexion.ejecutarSentenciaSql(sql);
        }

        //crear tabla de compra
        public static string tablaCompra = "compra";

        public const string Cad_Grid_compra = "idCompra,fecha_compra,num_compra,razon_social,total";

        public static void crear_tabla_compra()
        {
            ConexSQL objMiconexion = new ConexSQL();

            String sql = "IF NOT EXISTS (select name from sysobjects where name ='" + tablaCompra + "') CREATE TABLE " + tablaCompra + "(idCompra int IDENTITY(1,1) not null," +
                "fecha_Compra date NOT NULL, num_compra varchar(30) not null, razon_social nvarchar(50) not null, total numeric(10,2) NOT NULL, PRIMARY KEY(num_compra) );";
            objMiconexion.ejecutarSentenciaSql(sql);
        }

        //crear tabla de detalle compra
        public static string tabla_detalle_compra = "detalle_compra";

        public const string Cad_Grid_detalle_compra = "idDetalle_compra,idCompra,codigo1,precio_compra,precio_venta,cantidad";

        public static void crear_tabla_detalle_compra()
        {
            ConexSQL objMiconexion = new ConexSQL();

            String sql = "IF NOT EXISTS (select name from sysobjects where name ='" + tabla_detalle_compra + "') CREATE TABLE " + tabla_detalle_compra + "(idDetalle_compra int IDENTITY(1,1) not null," +
                "idCompra nvarchar(50) NOT NULL, codigo1 nvarchar(50) NOT NULL, precio_compra money not null, precio_venta money not null, cantidad numeric(10,2) NOT NULL, PRIMARY KEY(idDetalle_compra));";
            objMiconexion.ejecutarSentenciaSql(sql);
        }


        //crear tabla de administradores
        public static string tablaAdmin = "usuarios";

        public const string Cad_Grid_usuarios = "id,nombre,contrasena,admin";

        public static void crearusuarios()
        {
            ConexSQL objMiconexion = new ConexSQL();
            String sql = "IF NOT EXISTS (select name from sysobjects where name ='" + tablaAdmin + "') CREATE TABLE " + tablaAdmin + "(id int IDENTITY(1,1) not null,nombre nvarchar(50) NOT NULL,contrasena nvarchar(50) NOT NULL, admin nvarchar(7), " +
                "PRIMARY KEY (contrasena));";
            objMiconexion.ejecutarSentenciaSql(sql);

        }

        public static string tablaCierreCaja = "CierreCaja";
        public static void crear_tabla_cierre_caja()
        {
            ConexSQL objMiconexion = new ConexSQL();
            String sql = "IF NOT EXISTS (select name from sysobjects where name ='" + tablaCierreCaja + "') CREATE TABLE " + tablaCierreCaja + "(idCierre int IDENTITY(1,1) not null," +
                "fecha date NOT NULL, ventasTotales money NOT NULL, totalEfectivo money NOT NULL, totalTarjeta money NOT NULL, totalTrans money NOT NULL," +
                " repEfectivo money NOT NULL, repTarjeta money NOT NULL);";
            objMiconexion.ejecutarSentenciaSql(sql);

        }
    }
}
