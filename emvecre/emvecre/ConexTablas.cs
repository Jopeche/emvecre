//bibliotecas

using System;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;



namespace emvecre
{
    public class ConexTablas

    {
        //variables para los articulos
        public static int idArticulo;
        public static string codigo1;
        public static string codigo2;
        public static string nomb_articulo;
        public static decimal cantidad_stock;
        public static string imagen_articulo;
        public static decimal costo;
        public static decimal precio;
        public static string impuesto;
      

        //variables para los proveedores
        public static int idProveedor;
        public static string razon_social;


        //VARIABLES PARA LOS VENDEDORES
        public static int idVendedor;
        public static string nom_vendedor;

        // variables para las compras
        public static int idCompra;
        public static DateTime fecha_compra;

        //variables para detalle de compras
        public static int idDetalle_compra;
        public static int precio_Compra;
        public static int precio_venta;
        public static int cantidad;


        //variables para los clientes
        public static int idCliente;

        //variables para las ventas
        public static int idVenta;


        //variables para los departamentos
        public static int idDepartamento;
        public  static string nombreDep;

        //variables para los usuarios
        public static string admin;



        //Variable detalle de ventas
        public static string tabla_detalle_ventas = "detalle_ventas";

        //Variable de ventas
        public static string tablaVentas = "ventas";

        //Variable de clientes
        public static string tablaClientes = "clientes";

        //Variable para los departamentos
        public static string tablaDepartamento = "departamento";

        //Variable para los articulos
        public static string tablaArticulo = "Articulos";
        //crear tabla para los proveedores
        public static string tablaProveedor = "Proveedores";

        //Variable para los departamentos
        public static string tablaVendedor = "vendedor";

        //Variable para las compras
        public static string tablaCompra = "compra";

        //Variable para el detalle de las compras
        public static string tabla_detalle_compra = "detalle_compra";

        //Variable de administradores
        public static string tablaAdmin = "usuarios";

        //LLena un comboBox con los proveedores guandados en la tabla proveedores
        public void llenarComboProveedores(ComboBox Combo_Prov)
        {

            string nombre = "";
            Combo_Prov.Items.Clear();
            ConexSQL objMiconexion = new ConexSQL();
            ComboBox cb = new ComboBox();

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre", nombre);
            String sql = "SELECT *  FROM " + tablaProveedor;
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            miDr.Read();
            if (miDr.HasRows)
            {
                Combo_Prov.Items.Add(miDr["razon_social"].ToString());
                while (miDr.Read())
                {
                    Combo_Prov.Items.Add(miDr["razon_social"].ToString());
                    nombre = miDr["razon_social"].ToString();
                }
            }
        }

        //LLena un comboBox con los departamentos guandados en la tabla departamentos
        public void llenarComboDep(ComboBox Combo_dep)
        {

            string nombre = "";
            Combo_dep.Items.Clear();
            ConexSQL objMiconexion = new ConexSQL();
            ComboBox cb = new ComboBox();

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre", nombre);
            String sql = "SELECT *  FROM " + tablaDepartamento;
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            miDr.Read();
            if (miDr.HasRows)
            {
                Combo_dep.Items.Add(miDr["nombre"].ToString());
                while (miDr.Read())
                {
                    Combo_dep.Items.Add(miDr["nombre"].ToString());
                    nombre = miDr["nombre"].ToString();
                }
            }
            
        }
        //metodo para ingresar a la aplicacion con el nombre y contraseña verificando los datos guardados en la tabla usuarios
        public bool loguear(string usuario, string contra)
        {
            bool resulta = false;
            try { 
            {
                ConexSQL objMiconexion = new ConexSQL();

                SqlDataReader miDr;
                SqlParameter[] misParametros = new SqlParameter[2];
                misParametros[0] = new SqlParameter("@nombre", usuario);
                misParametros[1] = new SqlParameter("@contrasena", contra);
                    String sql = "SELECT * from " + tablaAdmin + " where nombre = '" + usuario + "' and contrasena = '"+ contra +"'" ;
                miDr = objMiconexion.consultarInformacion(sql, misParametros);
               
                miDr.Read();
                try
                {
                    if (miDr.HasRows)
                    {
                        resulta= true;

                        admin = miDr["admin"].ToString();

                        }
                    else
                    {
                        resulta = false;
                    }
                }
                finally
                {
                    miDr.Close();
                }
               
            }
            }
            catch { }
            return resulta;
        }

        //metodo para cargar los proveedores en un data grid view
        public void cargarProveedores(DataGridView dtv)
        {
            try
            {
                String queryProveedores = "";

                queryProveedores = "SELECT idProveedor as 'ID POVEEDOR', razon_social as 'RAZON SOCIAL', sector_comercial as 'SECTOR COMERCIAL', tipo_documento as 'TIPO DOCUMENTO', " +
                    "num_documento as 'NUMERO DOCUMENTO', direccion as 'DIRECCION', telefono as 'TELEFONO', email as 'EMAIL', URL as 'URL'  FROM " + ConexTablas.tablaProveedor + " order by " + "idProveedor";

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryProveedores, ConexSQL.miConexion);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        }

        //metodo para buscar proveedores por nombre en la tabla 
        public bool buscarProv(DataGridView datos, string nombre)
        {
            ConexSQL objMiconexion = new ConexSQL();
            String queryProveedores = "";

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre", nombre);
            String sql = queryProveedores = "SELECT idProveedor as 'ID POVEEDOR', razon_social as 'RAZON SOCIAL', sector_comercial as 'SECTOR COMERCIAL', tipo_documento as 'TIPO DOCUMENTO', " +
                    "num_documento as 'NUMERO DOCUMENTO', direccion as 'DIRECCION', telefono as 'TELEFONO', email as 'EMAIL', URL as 'URL'  FROM " + ConexTablas.tablaProveedor + " WHERE razon_social like('%" + nombre + "%')";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                if (miDr.HasRows)
                {

                    String queryArticulos = "";

                    queryArticulos = "SELECT idProveedor as 'ID POVEEDOR', razon_social as 'RAZON SOCIAL', sector_comercial as 'SECTOR COMERCIAL', tipo_documento as 'TIPO DOCUMENTO', " +
                    "num_documento as 'NUMERO DOCUMENTO', direccion as 'DIRECCION', telefono as 'TELEFONO', email as 'EMAIL', URL as 'URL'  FROM " + ConexTablas.tablaProveedor + " WHERE razon_social like('%" + nombre + "%')";

                    System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryArticulos, ConexSQL.miConexion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtV = new DataTable();
                    da.Fill(dtV);
                    datos.DataSource = dtV;


                }
                else
                {
                    resulta = false;


                }
            }
            finally
            {
                miDr.Close();
            }
            return resulta;
        }

        //Muestra los datos de un articulo segun el codigo de departamento
        public void MostrarDatos(DataGridView dtv)
        {

            try
            {

                String queryArticulos = "";

                queryArticulos = "SELECT ta.codigo1 as 'Codigo 1', ta.codigo2 as 'Codigo 2', ta.nombre as 'Nombre', ta.cantidad_stock as 'Existencias', (select td.nombre from "
                    + ConexTablas.tablaDepartamento + " as td where td.idDepartamento = ta.idDepartamento) as 'Departamento', ta.costo as 'Costo', ta.precio as 'Precio', ta.impuesto as 'Impuesto' FROM " + ConexTablas.tablaArticulo + " as ta order by " + "ta.codigo1";

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryArticulos, ConexSQL.miConexion);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        }

        //metodo para buscar proveedores
        public bool buscarProveedores(DataGridView datos, string razonsocial)
        {
            ConexSQL objMiconexion = new ConexSQL();

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@razon_social", razonsocial);
            String sql = "SELECT * FROM " + tablaProveedor + " WHERE razon_social = '" + razonsocial + "'";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                if (miDr.HasRows)
                {

                    String queryProveedores = "";

                    queryProveedores = "SELECT idProveedor, razon_social FROM " + tablaProveedor + " WHERE razon_social like('" + razonsocial + "%')";

                    System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryProveedores, ConexSQL.miConexion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtV = new DataTable();
                    da.Fill(dtV);
                    datos.DataSource = dtV;


                }
                else
                {
                    resulta = false;


                }
            }
            finally
            {
                miDr.Close();
            }
            return resulta;
        }

        //metodo para cargar clientes en un data grid view
        public void cargarClientes(DataGridView dtv)
        {
            try
            {
                String queryClientes = "";

                queryClientes = "SELECT idCliente as 'Codigo Cliente', nombre_cliente as 'Nombre', fecha_nacimiento as 'Fecha de Nacimiento', cedula as 'Cedula', " +
                    " direccion_cliente as 'Direccion', telefono_cliente as 'Telefono', email_cliente as 'Email'  FROM " + ConexTablas.tablaClientes + " order by " + "idCliente";

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryClientes, ConexSQL.miConexion);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtv.DataSource = dt;
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        }

        //metodo para cargar vendedores en un data grid view
        public void cargarVendedor(DataGridView dtv)
        {
            try
            {
                String queryVendedor = "";

                queryVendedor = "SELECT idVendedor as 'ID VENDEDOR', nombre as 'NOMBRE'  FROM " + ConexTablas.tablaVendedor + " order by " + "idVendedor";

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryVendedor, ConexSQL.miConexion);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        }

        //metodo para buscar clientes en la base de datos por nombre y cargarlos en un data grid view
        public bool buscarClientes(DataGridView datos, string nombre_cliente)
        {
            ConexSQL objMiconexion = new ConexSQL();

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre_cliente", nombre_cliente);
            String sql = "SELECT idCliente as 'Codigo Cliente', nombre_cliente as 'Nombre', fecha_nacimiento as 'Fecha de Nacimiento', cedula as 'Cedula', " +
                    " direccion_cliente as 'Direccion', telefono_cliente as 'Telefono', email_cliente as 'Email'  FROM " + ConexTablas.tablaClientes + " WHERE nombre_cliente like('%" + nombre_cliente + "%')";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                if (miDr.HasRows)
                {

                    String queryClientes = "";

                    queryClientes = "SELECT idCliente as 'Codigo Cliente', nombre_cliente as 'Nombre', fecha_nacimiento as 'Fecha de Nacimiento', cedula as 'Cedula', " +
                    " direccion_cliente as 'Direccion', telefono_cliente as 'Telefono', email_cliente as 'Email'  FROM " + ConexTablas.tablaClientes + " WHERE nombre_cliente like('%" + nombre_cliente + "%')";

                    System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryClientes, ConexSQL.miConexion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtV = new DataTable();
                    da.Fill(dtV);
                    datos.DataSource = dtV;


                }
                else
                {
                    resulta = false;


                }
            }
            finally
            {
                miDr.Close();
            }
            return resulta;
        }

        //metodo para buscar vendedores en la base de datos por nombre y cargarlos en un data grid view
        public bool cargarVendedores(DataGridView datos, string nombre_vendedor)
        {
            ConexSQL objMiconexion = new ConexSQL();

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre", nombre_vendedor);
            String sql = "SELECT * FROM " + tablaVendedor + " WHERE nombre = '" + nombre_vendedor + "'";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                if (miDr.HasRows)
                {

                    String queryVendedores = "";

                    queryVendedores = "SELECT idVendedor as 'ID VENDEDOR', nombre as 'NOMBRE' FROM " + tablaVendedor + " WHERE nombre like('" + nombre_vendedor + "%')";

                    System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryVendedores, ConexSQL.miConexion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtV = new DataTable();
                    da.Fill(dtV);
                    datos.DataSource = dtV;


                }
                else
                {
                    resulta = false;


                }
            }
            finally
            {
                miDr.Close();
            }
            return resulta;
        }


        //metodo para buscar articulos en la base de datos por nombre y cargarlos en un data grid view
        public bool buscarArticulos(DataGridView datos, string nombre)
        {
            ConexSQL objMiconexion = new ConexSQL();

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre", nombre);
            String sql = "SELECT ta.codigo1 as 'Codigo 1', ta.codigo2 as 'Codigo 2', ta.nombre as 'Nombre', ta.cantidad_stock as 'Existencias', (select td.nombre from "
                    + ConexTablas.tablaDepartamento + " as td where td.idDepartamento = ta.idDepartamento) as 'Departamento', ta.costo as 'Costo', ta.precio as 'Precio', ta.impuesto as 'Impuesto' FROM " + ConexTablas.tablaArticulo + " as ta  WHERE nombre like('%" + nombre + "%')"; ;
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                if (miDr.HasRows)
                {

                    String queryArticulos = "";

                    queryArticulos = "SELECT ta.codigo1 as 'Codigo 1', ta.codigo2 as 'Codigo 2', ta.nombre as 'Nombre', ta.cantidad_stock as 'Existencias', (select td.nombre from "
                    + ConexTablas.tablaDepartamento + " as td where td.idDepartamento = ta.idDepartamento) as 'Departamento', ta.costo as 'Costo', ta.precio as 'Precio', ta.impuesto as 'Impuesto' FROM " + ConexTablas.tablaArticulo + " as ta  WHERE nombre like('%" + nombre + "%')";

                    System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryArticulos, ConexSQL.miConexion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtV = new DataTable();
                    da.Fill(dtV);
                    datos.DataSource = dtV;


                }
                else
                {
                    resulta = false;


                }
            }
            finally
            {
                miDr.Close();
            }
            return resulta;
        }

        //metodo para buscar proveedores solo con el nombre como parametro
        public string buscarProveedores(string razonsocial)
        {

            ConexSQL objMiconexion = new ConexSQL();
            Ingresar_compra ic = new Ingresar_compra();

            RadioButton rb = new RadioButton();
            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@razon_social", razonsocial);
            String sql = "SELECT * FROM " + tablaProveedor + " WHERE razon_social = '" + razonsocial + "'";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            miDr.Read();
            try
            {
                if (miDr.HasRows)
                {
                    razonsocial = miDr["razon_social"].ToString();
                }
                else
                {
                    razonsocial = "";
                }
            }
            finally
            {
                miDr.Close();
            }

            return razonsocial;
        }

        //metodo que guarda la compra(fecha, numero factura, nombre de proveedor y total) en la tabla compra
        public void guardarIngreso(DateTime fecha, string num_compra, string razon_social, decimal total)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[4];
            misParametros[0] = new SqlParameter("@fecha_Compra", fecha);
            misParametros[1] = new SqlParameter("@num_compra", num_compra);
            misParametros[2] = new SqlParameter("@razon_social", razon_social);
            misParametros[3] = new SqlParameter("@total", total);

            String sql = "INSERT INTO " + tablaCompra + "(fecha_Compra,num_compra,razon_social,total)" +
                          " VALUES (@fecha_Compra,@num_compra,@razon_social,@total)";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }


        //metodo que guarda la venta(cliente, vendedor, fecha y total) en la tabla venta
        public void guardarVenta(int idCliente, int idVendedor, DateTime fecha, decimal total)
        {
            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[4];
            misParametros[0] = new SqlParameter("@idCliente", idCliente);
            misParametros[1] = new SqlParameter("@idVendedor", idVendedor);
            misParametros[2] = new SqlParameter("@fecha", fecha);
            misParametros[3] = new SqlParameter("@total", total);


            String sql = "INSERT INTO " + tablaVentas + "(idCliente,idVendedor,fecha,total)" +
                          " VALUES (@idCliente,@idVendedor,@fecha,@total)";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        //busca la venta y guarda el numero de factura para cuando se guarde el detalle de venta con el mismo numero
        public bool buscarVenta()
        {
            ConexSQL objMiconexion = new ConexSQL();

            SqlDataReader miDr;

            String sql = "SELECT top (1) * FROM " + ConexTablas.tablaVentas + " order by " + "idVenta desc";
            miDr = ConexSQL.consultarInformacionSinParm(sql);
            bool resulta = false;
            miDr.Read();
            try
            {
                if (miDr.HasRows)
                {
                    idVenta = (int)miDr["idVenta"];
                }
                else
                {
                    resulta = false;


                }
            }
            finally
            {
                miDr.Close();
            }
            return resulta;
        }

        // metodo que guarda el detalle de la compra y actualiza el stock del articulo
        public void guardarDetalleIngreso(DataGridView dgvCompra, string idCompra)
        {
            string codigo1 = "";
            decimal precio_compra = 0;
            decimal precio_venta = 0;
            decimal cantidad = 0;

            ConexSQL cs = new ConexSQL();

            foreach (DataGridViewRow fila in dgvCompra.Rows)
            {

                string sql = "";
                decimal stock_final = 0;

                codigo1 = fila.Cells["Codigo"].Value.ToString();
                precio_compra = Convert.ToDecimal(fila.Cells["Costo"].Value.ToString());
                precio_venta = Convert.ToDecimal(fila.Cells["Precio Venta"].Value.ToString());
                cantidad = Convert.ToDecimal(fila.Cells["Cantidad"].Value.ToString());



                buscarArticulo(codigo1);


                if (buscarArticulo(codigo1) == true)
                {
                    stock_final = cantidad + cantidad_stock;


                    sql = "update Articulos set costo = " + precio_compra + " WHERE codigo1 = " + codigo1;

                    cs.ejecutarSentenciaSql(sql);

                    sql = "update Articulos set cantidad_stock = " + stock_final + " WHERE codigo1 = " + codigo1;
                    cs.ejecutarSentenciaSql(sql);
                }

                ConexSQL objMiconexion = new ConexSQL();

                SqlParameter[] misParametros = new SqlParameter[5];
                misParametros[0] = new SqlParameter("@idCompra", idCompra);
                misParametros[1] = new SqlParameter("@codigo1", codigo1);
                misParametros[2] = new SqlParameter("@precio_compra", precio_compra);
                misParametros[3] = new SqlParameter("@precio_venta", precio_venta);
                misParametros[4] = new SqlParameter("@cantidad", cantidad);


                String Sql = "INSERT INTO " + tabla_detalle_compra + "(idCompra,codigo1,precio_compra,precio_venta,cantidad)" +
                              " VALUES (@idCompra,@codigo1,@precio_compra,@precio_venta,@cantidad)";

                objMiconexion.ejecutarSentencia(Sql, misParametros);
            }
        }

        //metodo que guarda el detalle de la venta y actualiza el stock del articulo
        public void guardarDetalleVenta(DataGridView dgvFactura, int idVenta)
        {
            string codigo1 = "";
            decimal cantidad = 0;
            decimal precio_venta = 0;
            decimal descuento = 0;


            ConexSQL cs = new ConexSQL();



            foreach (DataGridViewRow fila in dgvFactura.Rows)
            {
               
                string sql = "";
                decimal stock_final = 0;

              
                codigo1 = fila.Cells["Codigo"].Value.ToString();
                cantidad = Convert.ToDecimal(fila.Cells["Cantidad"].Value.ToString());
                precio_venta = Convert.ToDecimal(fila.Cells["Precio"].Value.ToString());
                descuento = Convert.ToDecimal(fila.Cells["Descuento"].Value.ToString());

                buscarArticulo(codigo1);

                if (buscarArticulo(codigo1) == true)
                {
                    stock_final = cantidad_stock - cantidad;

                    sql = "update Articulos set cantidad_stock = " + stock_final + " WHERE codigo1 = " + codigo1;
                    cs.ejecutarSentenciaSql(sql);
                }

                ConexSQL objMiconexion = new ConexSQL();

                SqlParameter[] misParametros = new SqlParameter[5];
                misParametros[0] = new SqlParameter("@idVenta", idVenta);
                misParametros[1] = new SqlParameter("@codigo1", codigo1);
                misParametros[2] = new SqlParameter("@cantidad", cantidad);
                misParametros[3] = new SqlParameter("@precio_venta", precio_venta);
                misParametros[4] = new SqlParameter("@descuento", descuento);



                String Sql = "INSERT INTO " + tabla_detalle_ventas + "(idVenta,codigo1,cantidad,precio_venta,descuento)" +
                              " VALUES (@idVenta,@codigo1,@cantidad,@precio_venta,@descuento)";

                objMiconexion.ejecutarSentencia(Sql, misParametros);
            }

        }

        //metodo para buscar cliente por nombre como parametro
        public bool buscarCliente(string nombreCliente)
        {
            ConexSQL objMiconexion = new ConexSQL();

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre_cliente", nombreCliente);
            String sql = "SELECT * FROM " + tablaClientes + " WHERE nombre_cliente = '" + nombreCliente + "'";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                resulta = true;
                if (miDr.HasRows)
                {
                    idCliente = (int)miDr["idCliente"];


                }
                else
                {
                    resulta = false;
                    MessageBox.Show("EL NOMBRE DEL CLIENTE  NO EXISTE");
                }

            }
            finally
            {
                miDr.Close();
            }
            return resulta;
        }

        //Busca vendedores por nombre y los carga en un data grid view
        public bool buscarVendedor(string nombre, DataGridView datos)
        {
            ConexSQL objMiconexion = new ConexSQL();


            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre", nombre);
            String sql = "SELECT idVendedor as 'ID VENDEDOR', nombre as 'NOMBRE' FROM " + tablaVendedor + " WHERE NOMBRE  like('%" + nombre + "%')";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                resulta = true;
                if (miDr.HasRows)
                {

                    
                    String queryClientes = "";

                        queryClientes = "SELECT idVendedor as 'ID VENDEDOR', nombre as 'NOMBRE' FROM " + tablaVendedor + " WHERE NOMBRE  like('%" + nombre + "%')";

                    System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryClientes, ConexSQL.miConexion);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dtV = new DataTable();
                        da.Fill(dtV);
                        datos.DataSource = dtV;

                    idVendedor = (int)miDr["ID VENDEDOR"];


                }
                
                else
                {
                    resulta = false;
                   
                }

            }
            finally
            {
              
                miDr.Close();

            }
            return resulta;
        }



        //carga las compras realizadas en un data grid view
        public bool cargarArticulosCompra(DataGridView datos, string codigo1, decimal costo, string nombre, decimal precio, decimal cantidad)
        {

          
            ConexSQL objMiconexion = new ConexSQL();
            decimal subtotal = 0;
            string codigo2= codigo1;
            string paga_impuesto = "";
            decimal imp = 0;

            Ingresar_compra f1 = Application.OpenForms.OfType<Ingresar_compra>().SingleOrDefault();

            Ingresar_compra ic = new Ingresar_compra();

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@codigo1", codigo1);
            String sql = "SELECT * FROM " + tablaArticulo + " WHERE codigo1 = '" + codigo1 + "' or codigo2 = '" + codigo1 + "'";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                if (miDr.HasRows)
                {
                    resulta = true;


                    codigo1 = miDr["codigo1"].ToString();
                    codigo2 = miDr["codigo2"].ToString();
                    nombre = miDr["nombre"].ToString();
                    precio = (decimal)miDr["precio"];
                    paga_impuesto = miDr["impuesto"].ToString();


                    subtotal = costo * cantidad;


                    if (paga_impuesto == "Si")
                    {

                        imp = Convert.ToDecimal(f1.txtImpuesto.Text) + subtotal * 13 / 100;
                        imp = decimal.Round(imp, 2);
                    }
                    else
                    {
                        imp = Convert.ToDecimal(f1.txtImpuesto.Text) + 0;
                        imp = decimal.Round(imp, 2);
                    }
                    f1.txtImpuesto.Text = imp.ToString();

                    datos.Rows.Add(codigo1, nombre, precio, costo, cantidad, subtotal);

                }
                else
                {
                    resulta = false;
                    MessageBox.Show("EL ARTICULO NO EXISTE, BUSCAR POR CODIGO");

                }
            }
            finally
            {
                miDr.Close();
            }
            return resulta;
        }

        //carga las ventas realizadas en un data grid view
        public bool cargarArticulosVenta(DataGridView datos, string codigo1, string nombre, decimal precio, decimal cantidad)
        {

            ConexSQL objMiconexion = new ConexSQL();
           
            decimal subtotal = 0;
            decimal descuento = 0;
            decimal imp = 0;
            string paga_impuesto = "";

            frmFacturar f1 = Application.OpenForms.OfType<frmFacturar>().SingleOrDefault();

            frmFacturar ff = new frmFacturar();

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@codigo1", codigo1);
            String sql = "SELECT * FROM " + tablaArticulo + " WHERE codigo1 = '" + codigo1 + "' or codigo2 ='" + codigo1 + "'";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                if (miDr.HasRows)
                {

                    resulta = true;
                    codigo1 = miDr["codigo1"].ToString();
                    nombre = miDr["nombre"].ToString();
                    precio = (decimal)miDr["precio"];
                    paga_impuesto = miDr["impuesto"].ToString();


                    subtotal = precio * cantidad;

                    if (paga_impuesto == "Si")
                    {

                        imp = Convert.ToDecimal(f1.txtImpuesto.Text) + subtotal * 13 / 100;
                        imp = decimal.Round(imp, 2);
                    }
                    else
                    {
                        imp = Convert.ToDecimal(f1.txtImpuesto.Text) + 0;
                        imp = decimal.Round(imp, 2);
                    }
                    f1.txtImpuesto.Text = imp.ToString();

                    datos.Rows.Add(codigo1, nombre, precio, cantidad, descuento, subtotal);

                }

                else
                {
                    resulta = false;
                    MessageBox.Show("El articulo ya fue ingresdo puede modificarlo manualmente");
                }
            }
            finally
            {
                miDr.Close();
            }
            return resulta;
        }

        //busca los articulos con impuesto
        public decimal buscarGravados(DataGridView dataGridView)
        {
          
            decimal total = 0;
            decimal subtotal = 0;
            try
            {
                foreach (DataGridViewRow filas in dataGridView.Rows)
            {
                buscarArticulo(filas.Cells["Codigo"].Value.ToString());
                if (ConexTablas.impuesto == "Si")
                {
                    subtotal += Convert.ToDecimal(filas.Cells["Subtotal"].Value);

                }
                total = subtotal * 13 / 100;
                total = decimal.Round(total, 2);
            }

            return total;
            }
            catch { }
            return total;
        }

        //busca los articulos por codigo
        public bool buscarArticulo(string codigo1)
        {

            ConexSQL objMiconexion = new ConexSQL();
            Ingresar_compra f1 = Application.OpenForms.OfType<Ingresar_compra>().SingleOrDefault();

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@codigo1", codigo1);
            String sql = "SELECT * FROM " + tablaArticulo + " WHERE codigo1 = '" + codigo1 + "' or codigo2 ='"+ codigo1+ "'";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                resulta = true;
                if (miDr.HasRows)
                {
                    codigo1 = miDr["codigo1"].ToString();
                    codigo2 = miDr["codigo1"].ToString();
                    costo = (decimal)miDr["costo"];
                    impuesto = miDr["impuesto"].ToString();
                    cantidad_stock = (decimal)miDr["cantidad_stock"];

                }
                else
                {
                    resulta = false;
             


                }

            }
            finally
            {
                miDr.Close();
            }
            return resulta;
        }

        //metodo que busca los departamentos por nombre
        public void buscarDepartamento(string nombre)
        {
    

            ConexSQL objMiconexion = new ConexSQL();
   

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre", nombre);
            String sql = "SELECT * FROM " + tablaDepartamento + " WHERE nombre = '" + nombre + "'";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                resulta = true;
                if (miDr.HasRows)
                {

                    idDepartamento = (int)miDr["idDepartamento"];
                    nombre = miDr["nombre"].ToString();

                }
                else
                {
                    resulta = false;

                }

            }
            finally
            {
                miDr.Close();
            }
           
        }

        //metodo para el calcular el subtotal de la compra realizada
        public void calculoCompra(DataGridView dgvCompra, TextBox txtSubtotal)
        {

            decimal subtotal = 0;

            foreach (DataGridViewRow fila in dgvCompra.Rows)
            {

                subtotal += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                subtotal = decimal.Round(subtotal, 2);

            }
            txtSubtotal.Text = subtotal.ToString();
          
        }

        //metodo para guardar un dato en la tabla articulos
        public void guardarArticulo(string codigo1, string codigo2, string nombre, decimal existencia, int idDepartamento, decimal costo, decimal precio, string imp)
        {
           
            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[8];
            misParametros[0] = new SqlParameter("@codigo1", codigo1);
            misParametros[1] = new SqlParameter("@codigo2", codigo2);
            misParametros[2] = new SqlParameter("@nombre", nombre);
            misParametros[3] = new SqlParameter("@cantidad_stock", existencia);
            misParametros[4] = new SqlParameter("@idDepartamento", idDepartamento);
            misParametros[5] = new SqlParameter("@costo", costo);
            misParametros[6] = new SqlParameter("@precio", precio);
            misParametros[7] = new SqlParameter("@impuesto", imp);
        
            String sql = "INSERT INTO " + tablaArticulo + "(codigo1,codigo2,nombre,cantidad_stock,idDepartamento,costo,precio,impuesto)" +
                          " VALUES (@codigo1,@codigo2,@nombre,@cantidad_stock,@idDepartamento,@costo,@precio,@impuesto)";
         
           objMiconexion.ejecutarArticulo(sql, misParametros);
            

        }

        ////metodo para eliminar un dato en la tabla articulos
        public void eliminarArticulo(string codigo)
        {


            ConexSQL objMiconexion = new ConexSQL();

            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@codigo1", codigo);

            String sql = "delete from " + tablaArticulo + " where codigo1 = '" + codigo + "'";
            objMiconexion.ejecutarSentencia(sql, misParametros);
           
          
        
        }

        ////metodo para actualizar un dato en la tabla articulos
        public void actualizarArticulo(string codigo1, string codigo2, string nombre, double existencia, int idDepartamento, double costo, double precio, string imp)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[8];
            misParametros[0] = new SqlParameter("@codigo1", codigo1);
            misParametros[1] = new SqlParameter("@codigo2", codigo2);
            misParametros[2] = new SqlParameter("@nombre", nombre);
            misParametros[3] = new SqlParameter("@cantidad_stock", existencia);
            misParametros[4] = new SqlParameter("@idDepartamento", idDepartamento);
            misParametros[5] = new SqlParameter("@costo", costo);
            misParametros[6] = new SqlParameter("@precio", precio);
            misParametros[7] = new SqlParameter("@impuesto", imp);


            String sql = "UPDATE " + tablaArticulo + " set codigo2 = '" +codigo2+ "', nombre = '" + nombre + "' , cantidad_stock = '" + existencia + "', idDepartamento = '" + idDepartamento + "',"
                   +     "  costo = '" + costo + "', precio = '" + precio + "', impuesto = '" + imp + "' where codigo1 = '"+codigo1+"'";
           
            objMiconexion.ejecutarSentencia(sql, misParametros);
        }
        
        //metodo para exportar los datos de un datagridview a un archivo de excel
        public void exportarExcel(DataGridView grd)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int indiceColumna = 0;

            foreach (DataGridViewColumn col in grd.Columns)//Columnas
            {
                indiceColumna++;
                excel.Cells[1, indiceColumna] = col.Name;

            }

            int indiceFila = 0;

            foreach (DataGridViewRow row in grd.Rows)//Filas
            {
                indiceFila++;
                indiceColumna = 0;

                foreach (DataGridViewColumn col in grd.Columns)
                {

                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;

                }
            }

            excel.Visible = true;
        }

        ////metodo para mostrar los departamentos en un datagridview
        public void MostrarDepartamentos(DataGridView dtv)
        {

            try
            {

                String queryArticulos = "";

                queryArticulos = "SELECT idDepartamento as 'ID DEPARTAMENTO', nombre as 'NOMBRE', descripcion as 'DESCRIPCION' from " + tablaDepartamento;

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryArticulos, ConexSQL.miConexion);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        }
        //metodo para guardar un dato en la tabla departamentos
        public void guardarDep(string nombre, string descripcion)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[2];
            misParametros[0] = new SqlParameter("@nombre", nombre);
            misParametros[1] = new SqlParameter("@descripcion", descripcion);

            String sql = "INSERT INTO " + tablaDepartamento + "(nombre,descripcion)" +
                          " VALUES (@nombre,@descripcion)";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        ////metodo para eliminar un dato en la tabla departamentos
        public void eliminarDep(string idDepartamento)
        {


            ConexSQL objMiconexion = new ConexSQL();

            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@idDepartamento", idDepartamento);

            String sql = "delete from " + tablaDepartamento + " where idDepartamento = '" + idDepartamento + "'";
            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        ////metodo para actualizar un dato en la tabla departamentos
        public void actualizarDep(int idDepart, string nombre, string descripcion)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[3];
            misParametros[0] = new SqlParameter("@idDepartamento", idDepart);
            misParametros[1] = new SqlParameter("@nombre", nombre);
            misParametros[2] = new SqlParameter("@descripcion", descripcion);

            String sql = "UPDATE " + tablaDepartamento + " set nombre = '" + nombre + "', DESCRIPCION = '" + descripcion + "' where idDepartamento = '" + idDepart + "'";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        //metodo para buscar un departamento por nombre
        public bool BuscarDep(string nombre, DataGridView datos)
        {
            ConexSQL objMiconexion = new ConexSQL();


            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre", nombre);
            String sql = "SELECT idDepartamento as 'ID DEPARTAMENTO', nombre as 'NOMBRE', descripcion as 'DESCRIPCION' from " + tablaDepartamento + " where nombre like('%" + nombre + "%')";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                resulta = true;
                if (miDr.HasRows)
                {


                    String queryClientes = "";

                    queryClientes = "SELECT idDepartamento as 'ID DEPARTAMENTO', nombre as 'NOMBRE', descripcion as 'DESCRIPCION' from " + tablaDepartamento + " where nombre like('%" + nombre + "%')";

                    System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryClientes, ConexSQL.miConexion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtV = new DataTable();
                    da.Fill(dtV);
                    datos.DataSource = dtV;


                }

                else
                {
                    resulta = false;

                }

            }
            finally
            {

                miDr.Close();

            }
            return resulta;
        }

        //metodo para guardar un dato en la tabla clientes
        public void guardarCliente(string nombre, DateTime fecha, string cedula, string direccion, string telefono, string email)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[6];
            misParametros[0] = new SqlParameter("@nombre_cliente", nombre);
            misParametros[1] = new SqlParameter("@fecha_nacimiento", fecha);
            misParametros[2] = new SqlParameter("@cedula", cedula);
            misParametros[3] = new SqlParameter("@direccion_cliente", direccion);
            misParametros[4] = new SqlParameter("@telefono_cliente", telefono);
            misParametros[5] = new SqlParameter("@email_cliente", email);


            String sql = "INSERT INTO " + tablaClientes + "(nombre_cliente,fecha_nacimiento,cedula,direccion_cliente,telefono_cliente,email_cliente)" +
                          " VALUES (@nombre_cliente,@fecha_nacimiento,@cedula,@direccion_cliente,@telefono_cliente,@email_cliente)";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        // //metodo para eliminar un dato en la tabla clientes
        public void eliminarCliente(string idCliente)
        {


            ConexSQL objMiconexion = new ConexSQL();

            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@idCliente", idCliente);

            String sql = "delete from " + tablaClientes + " where idCliente = '" + idCliente + "'";
            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        // //metodo para actualizar un dato en la tabla clientes
        public void actualizarCliente(string idCliente, string nombre, DateTime fecha, string cedula, string direccion, string telefono, string email)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[6];
            misParametros[0] = new SqlParameter("@nombre_cliente", nombre);
            misParametros[1] = new SqlParameter("@fecha_nacimiento", fecha);
            misParametros[2] = new SqlParameter("@cedula", cedula);
            misParametros[3] = new SqlParameter("@direccion_cliente", direccion);
            misParametros[4] = new SqlParameter("@telefono_cliente", telefono);
            misParametros[5] = new SqlParameter("@email_cliente", email);


            String sql = "UPDATE " + tablaClientes + " set nombre_cliente = '" + nombre + "', fecha_nacimiento = '" + fecha + "' , cedula = '" + cedula + "', direccion_cliente = '" + direccion + "',"
                   + "  telefono_cliente = '" + telefono + "', email_cliente = '" + email + "' where idCliente = '" + idCliente + "'";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        //metodo para guardar un dato en la tabla proveedores
        public void guardarProveedor(string razon_social, string sector_comercial, string tipo_doc, string num_doc, string direccion, string telefono, string email, string url)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[8];
            misParametros[0] = new SqlParameter("@razon_social", razon_social);
            misParametros[1] = new SqlParameter("@sector_comercial", sector_comercial);
            misParametros[2] = new SqlParameter("@tipo_documento", tipo_doc);
            misParametros[3] = new SqlParameter("@num_documento", num_doc);
            misParametros[4] = new SqlParameter("@direccion", direccion);
            misParametros[5] = new SqlParameter("@telefono", telefono);
            misParametros[6] = new SqlParameter("@email", email);
            misParametros[7] = new SqlParameter("@url", url);

            String sql = "INSERT INTO " + tablaProveedor + "(razon_social,sector_comercial,tipo_documento,num_documento,direccion,telefono,email,url)" +
                          " VALUES (@razon_social,@sector_comercial,@tipo_documento,@num_documento,@direccion,@telefono,@email,@url)";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        //metodo para eliminar un dato en la tabla proveedores
        public void eliminarProv(string idProv)
        {


            ConexSQL objMiconexion = new ConexSQL();

            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@idProveedor", idProv);

            String sql = "delete from " + tablaProveedor + " where idProveedor = '" + idProv + "'";
            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        //metodo para actualizar un dato en la tabla proveedores
        public void actualizarProv(string idProveedor, string razon_social, string sector_comercial, string tipo_doc, string num_doc, string direccion, string telefono, string email, string url)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[8];
            misParametros[0] = new SqlParameter("@razon_social", razon_social);
            misParametros[1] = new SqlParameter("@sector_comercial", sector_comercial);
            misParametros[2] = new SqlParameter("@tipo_documento", tipo_doc);
            misParametros[3] = new SqlParameter("@num_documento", num_doc);
            misParametros[4] = new SqlParameter("@direccion", direccion);
            misParametros[5] = new SqlParameter("@telefono", telefono);
            misParametros[6] = new SqlParameter("@email", email);
            misParametros[7] = new SqlParameter("@url", url);


            String sql = "UPDATE " + tablaProveedor + " set razon_social = '" + razon_social + "', sector_comercial = '" + sector_comercial + "' , tipo_documento = '" + tipo_doc + "', num_documento = '" + num_doc + "',"
                   + "  direccion = '" + direccion + "', telefono = '" + telefono + "', email = '" + email + "', url = '" + url + "' where idProveedor = '" + idProveedor + "'";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }
        //metodo para guardar un dato en la tabla vendedores
        public void guardarVend(string nombre)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre", nombre);

            String sql = "INSERT INTO " + tablaVendedor + "(nombre)" +
                          " VALUES (@nombre)";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        //metodo para eliminar un dato en la tabla vendedores
        public void eliminarVend(string idVendedor)
        {


            ConexSQL objMiconexion = new ConexSQL();

            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@idVendedor", idVendedor);

            String sql = "delete from " + tablaVendedor + " where idVendedor = '" + idVendedor + "'";
            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        //metodo para actualizar un dato en la tabla vendedores
        public void actualizarVend(int idVendedor, string nombre)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[2];
            misParametros[0] = new SqlParameter("@idVendedor", idVendedor);
            misParametros[1] = new SqlParameter("@nombre", nombre);


            String sql = "UPDATE " + tablaVendedor + " set nombre = '" + nombre + "' where idVendedor = '" + idVendedor + "'";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        //metodo para cargar los usuarios en un datagridview
        public void cargarUsuarios(DataGridView dtv)
        {
            try
            {
                String queryVendedor = "";

                queryVendedor = "SELECT id as 'ID', nombre as 'NOMBRE', contrasena as CONTRASEÑA, admin as 'Administrador'  FROM " + ConexTablas.tablaAdmin + " order by " + "id";

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryVendedor, ConexSQL.miConexion);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        }

        //metodo para guardar un dato en la tabla usuarios
        public void guardarUsuario(string nombre, string contrasena, string admin)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[3];
            misParametros[0] = new SqlParameter("@nombre", nombre);
            misParametros[1] = new SqlParameter("@contrasena", contrasena);
            misParametros[2] = new SqlParameter("@admin", admin);


            String sql = "INSERT INTO " + tablaAdmin + "(nombre,contrasena,admin)" +
                          " VALUES (@nombre,@contrasena,@admin)";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        //metodo para eliminar un dato en la tabla usuarios
        public void eliminarUsuario(string idUsuario)
        {


            ConexSQL objMiconexion = new ConexSQL();

            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@id", idUsuario);

            String sql = "delete from " + tablaAdmin + " where id = '" + idUsuario + "'";
            objMiconexion.ejecutarSentencia(sql, misParametros);
        }

        //metodo para actualizar un dato en la tabla usuarios
        public void actualizarUsuario(int idUsuario, string nombre, string contrasena, string admin)
        {


            ConexSQL objMiconexion = new ConexSQL();


            SqlParameter[] misParametros = new SqlParameter[4];
            misParametros[0] = new SqlParameter("@id", idUsuario);
            misParametros[1] = new SqlParameter("@nombre", nombre);
            misParametros[2] = new SqlParameter("@contrasena", contrasena);
            misParametros[3] = new SqlParameter("@admin", admin);


            String sql = "UPDATE " + tablaAdmin + " set nombre = '" + nombre + "', contrasena = '" + contrasena + "', admin = '" + admin + "' where id = '" + idUsuario + "'";

            objMiconexion.ejecutarSentencia(sql, misParametros);
        }
        //metodo para buscar usuarios por nombre
        public bool buscarUsuario(string nombre, DataGridView datos)
        {
            ConexSQL objMiconexion = new ConexSQL();


            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre", nombre);
            String sql = "SELECT id as 'ID', nombre as 'NOMBRE', contrasena as CONTRASEÑA, admin as 'Administrador'  FROM " + tablaAdmin + " WHERE NOMBRE  like('%" + nombre + "%')";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                resulta = true;
                if (miDr.HasRows)
                {


                    String queryClientes = "";

                    queryClientes = "SELECT id as 'ID', nombre as 'NOMBRE', contrasena as CONTRASEÑA, admin as 'Administrador'  FROM " + tablaAdmin + " WHERE NOMBRE  like('%" + nombre + "%')"; ;

                    System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryClientes, ConexSQL.miConexion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtV = new DataTable();
                    da.Fill(dtV);
                    datos.DataSource = dtV;

                }

                else
                {
                    resulta = false;

                }

            }
            finally
            {

                miDr.Close();

            }
            return resulta;
        }
     

    }
}
