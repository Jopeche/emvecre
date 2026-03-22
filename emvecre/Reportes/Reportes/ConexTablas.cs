using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System.Drawing;


namespace Reportes
{
    class ConexTablas
    {

        //variables nesesarias para las consultas necesarias para los reportes
        public static int idVenta;
        public static decimal cantidad;
        public static decimal precio_venta;
        public static decimal descuento;
        public static decimal cantidad_stock;


        //llenar combobox con los nombres de los departamentos guardados en la base de datos en la tabla departamentos
 
        public void llenarCombo(ComboBox Combo_dep)
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
            
            if (miDr.HasRows)//si existe el departamento agregamos los nombres al combobox
            {
                Combo_dep.Items.Add(miDr["nombre"].ToString());

                while (miDr.Read())//mientra hayan departamentos se agregaran uno por uno al combobox
                {
                    Combo_dep.Items.Add(miDr["nombre"].ToString());
                    nombre = miDr["nombre"].ToString();
                }

            }
        }
        //crear tabla de detalle de ventas
        public static string tabla_detalle_ventas = "detalle_ventas";

        //crear tabla de ventas
        public static string tablaVentas = "ventas";

        //tabla para clientes
        public static string tablaClientes = "clientes";

        //Tabla para los departamentos
        public static string tablaDepartamento = "departamento";

        // tabla para los articulos
        public static string tablaArticulo = "Articulos";

        // tabla para los proveedores
        public static string tablaProveedor = "Proveedores";

        // tabla para los departamentos
        public static string tablaVendedor = "vendedor";
        //tabla para la compra
        public static string tablaCompra = "compra";
        //Tabla para el detalle de compra
        public static string tabla_detalle_compra = "detalle_compra";

        //Cargar las ventas en el data grid view

        //se cargan las ventas en el datagrid segun el cliente y el vendedor

        public void cargarVentas(DataGridView dtv, DateTimePicker desde, DateTimePicker hasta)
        {

            String queryReportes = "";
            SqlParameter[] misParametros = new SqlParameter[2];
            misParametros[0] = new SqlParameter("@desde", desde);
            misParametros[1] = new SqlParameter("@hasta", hasta);

            try
            {



                // query para buscar por vendedor y cliente
                queryReportes = "SELECT tv.idVenta as COMPROBANTE, tv.fecha as FECHA, tc.nombre_cliente AS 'NOMBRE CLIENTE',tv.tipoPago as 'TIPO PAGO', tven.nombre as VENDEDOR,  tv.total as TOTAL FROM " + ConexTablas.tablaVendedor + " as tven, " + ConexTablas.tablaVentas + " as tv,"
                + ConexTablas.tablaClientes + " as tc " +
            " where tven.idVendedor = tv.idVendedor and tc.idCliente = tv.idCliente and cast(tv.fecha as date) BETWEEN @desde and @hasta order by " + "idVenta";

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryReportes, ConexSQL.miConexion);
                cmd.Parameters.AddWithValue("@desde", desde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Value.Date);

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

        public void cargarVentas(DataGridView dtv, DateTimePicker desde, DateTimePicker hasta, string cliente, string vendedor)
        {

            String queryReportes = "";
            SqlParameter[] misParametros = new SqlParameter[2];
            misParametros[0] = new SqlParameter("@desde", desde);
            misParametros[1] = new SqlParameter("@hasta", hasta);


            try
            {



                // query para buscar por vendedor y cliente
                queryReportes = "SELECT tv.idVenta as COMPROBANTE, tv.fecha as FECHA, tc.nombre_cliente AS 'NOMBRE CLIENTE', tven.nombre as VENDEDOR,  tv.total as TOTAL FROM " + ConexTablas.tablaVendedor + " as tven  inner join " + ConexTablas.tablaVentas + " as tv on tv.idVendedor = tven.idVendedor inner join "
                + ConexTablas.tablaClientes + " as tc on tv.idCliente = tc.idCliente " +
            " where cast(tv.fecha as date) BETWEEN @desde and @hasta and tc.nombre_cliente ='" + cliente + "' and tven.nombre='" + vendedor + "' order by " + "idVenta";

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryReportes, ConexSQL.miConexion);
                cmd.Parameters.AddWithValue("@desde", desde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Value.Date);

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

        //metodo para buscar las ventas con filtro de vendedores
            public void cargarVentasVendedor(DataGridView dtv, DateTimePicker desde, DateTimePicker hasta, string vendedor)
            {

                String queryReportes = "";
            SqlParameter[] misParametros = new SqlParameter[2];
            misParametros[0] = new SqlParameter("@desde", desde);
            misParametros[1] = new SqlParameter("@hasta", hasta);


            try
            {



                // query para buscar por vendedor
                queryReportes = "SELECT tv.idVenta as COMPROBANTE, tv.fecha as FECHA, tc.nombre_cliente AS 'NOMBRE CLIENTE', tven.nombre as VENDEDOR,  tv.total as TOTAL FROM " +
                     ConexTablas.tablaVentas + " as tv inner join "
                   + ConexTablas.tablaVendedor + " as tven on tv.idVendedor = tven.idVendedor," +
                   ConexTablas.tablaClientes + " as tc  " +
               " where tv.idVendedor = tven.idVendedor and  tv.idCliente = tc.idCliente and cast(tv.fecha as date) BETWEEN @desde and @hasta and tven.nombre  ='" + vendedor + "' order by " + "idVenta";

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryReportes, ConexSQL.miConexion);
                cmd.Parameters.AddWithValue("@desde", desde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Value.Date);

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

        //metodo para cargar las ventas por filtro de clientes
            public void cargarVentasCliente(DataGridView dtv, DateTimePicker desde, DateTimePicker hasta, string cliente)
            {

                String queryReportes = "";
            SqlParameter[] misParametros = new SqlParameter[2];
            misParametros[0] = new SqlParameter("@desde", desde);
            misParametros[1] = new SqlParameter("@hasta", hasta);


            try
            {

                   // query para buscar por cliente
                    queryReportes = "SELECT tv.idVenta as COMPROBANTE, tv.fecha as FECHA, tc.nombre_cliente AS 'NOMBRE CLIENTE', tven.nombre as VENDEDOR,  tv.total as TOTAL FROM " +
                      ConexTablas.tablaVentas + " as tv inner join "
                    + ConexTablas.tablaClientes + " as tc on tv.idCliente = tc.idCliente," +
                    ConexTablas.tablaVendedor + " as tven  "+
                " where tv.idCliente = tc.idCliente and tv.idVendedor = tven.idVendedor and cast(tv.fecha as date) BETWEEN @desde and @hasta and tc.nombre_cliente ='" + cliente + "' order by " + "idVenta";

                    System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryReportes, ConexSQL.miConexion);
                    cmd.Parameters.AddWithValue("@desde", desde.Value.Date);
                    cmd.Parameters.AddWithValue("@hasta", hasta.Value.Date);

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
        
        //metodo para cargar en el datagridview todo el contenido de la factura
        public void cargarDetalleVenta(DataGridView dtv, int idVenta)
        {

            {

                String queryReportes = "";

                queryReportes = "SELECT tdv.codigo1 as CODIGO, (select ta.nombre from " + ConexTablas.tablaArticulo + " as ta where tdv.codigo1 = ta.codigo1) as 'DESCRIPCION', " +
                    "tdv.cantidad as CANTIDAD, tdv.precio_venta as 'PRECIO VENTA', (select (tdv.precio_venta*13/100) from " + ConexTablas.tablaArticulo + " as ta where ta.impuesto='si' and tdv.codigo1 = ta.codigo1) as IMPUESTO, tdv.descuento as DESCUENTO FROM "
                    + ConexTablas.tabla_detalle_ventas + " as tdv " +
                    " where tdv.idVenta = '" + idVenta + "' order by tdv.idVenta";

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryReportes, ConexSQL.miConexion);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtv.DataSource = dt;

            }

        }
        //metodo para cargar las compras a proveedores
        public void cargarCompras(DataGridView dtv, DateTimePicker desde, DateTimePicker hasta, string prov)
        {

            String queryReportes = "";

            SqlParameter[] misParametros = new SqlParameter[2];
            misParametros[0] = new SqlParameter("@desde", desde);
            misParametros[1] = new SqlParameter("@hasta", hasta);

            try
            {
                if (prov == "")//si no se filtra por nombre de proveedor, se envian todas las compras que esten en el rango de fecha indicado
                {
            

                    queryReportes = "SELECT tc.num_compra as COMPROBANTE,  tc.razon_social as PROVEEDOR, tc.fecha_compra AS FECHA, tc.total as TOTAL FROM " + ConexTablas.tablaCompra + " as tc " +
                        " where cast(tc.fecha_compra as date) BETWEEN @desde and @hasta order by " + "tc.fecha_compra";

                }
                else
                {// en este query se carrgan las compras por nombre de proveedor y fecha
                    queryReportes = "SELECT tc.num_compra as COMPROBANTE,  tc.razon_social as PROVEEDOR, tc.fecha_compra AS FECHA, tc.total as TOTAL FROM " + ConexTablas.tablaCompra + " as tc " +
                      " where tc.razon_social ='"+prov+ "' and cast(tc.fecha_compra as date) BETWEEN @desde and @hasta order by " + "tc.fecha_compra";
                }

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryReportes, ConexSQL.miConexion);
                cmd.Parameters.AddWithValue("@desde",desde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Value.Date);

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


        // se cargan el detalle de los productos dentro de la compra 
        public void cargarDetalleCompra(DataGridView dtv, int idCompra)
        {

            {

                String queryReportes = "";

                queryReportes = "SELECT tdc.idCompra as 'NUMERO COMPRA', tdc.codigo1 as CODIGO, tdc.precio_compra as 'PRECIO COMPRA', tdc.precio_venta as 'PRECIO VENTA'," +
                    "(select (tdc.precio_compra*13/100) from " + ConexTablas.tablaArticulo + " as ta where ta.impuesto='si' and tdc.codigo1 = ta.codigo1) as IMPUESTO, " +
                    "tdc.cantidad as CANTIDAD FROM "
                    + ConexTablas.tabla_detalle_compra + " as tdc " +
                    " where tdc.idCompra = '" + idCompra + "' order by tdc.idCompra";

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryReportes, ConexSQL.miConexion);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtv.DataSource = dt;

            }

        }
        //metodo para eliminar una factura del sistema
        public void eliminarFactura(DataGridView dgvVentas, int idVenta)
        {
            string codigo1 = "";
            decimal cantidad = 0;
            string sql = "";

            ConexSQL cs = new ConexSQL();

            foreach (DataGridViewRow fila in dgvVentas.Rows)
            {

              
                decimal stock_final = 0;

                codigo1 = fila.Cells["CODIGO"].Value.ToString();
                cantidad = Convert.ToDecimal(fila.Cells["CANTIDAD"].Value.ToString());



                buscarArticulo(codigo1);


                if (buscarArticulo(codigo1) == true)
                {
                    stock_final = cantidad + cantidad_stock;

                    sql = "update Articulos set cantidad_stock = " + stock_final + " WHERE codigo1 = " + codigo1;
                    cs.ejecutarSentenciaSql(sql);

                   
                }


            }
            sql = "delete from " + tablaVentas + " where idVenta='" + idVenta + "'";
            cs.ejecutarSentenciaSql(sql);

            sql = "delete from " + tabla_detalle_ventas + " where idVenta='" + idVenta + "'";
            cs.ejecutarSentenciaSql(sql);
        }
        //metodo para eliminar una compra del sistema
        public void eliminarCompra(DataGridView dgvCompra, int idCompra)
        {
            string codigo1 = "";
            decimal cantidad = 0;
            string sql = "";

            ConexSQL cs = new ConexSQL();

            foreach (DataGridViewRow fila in dgvCompra.Rows)
            {


                decimal stock_final = 0;

                codigo1 = fila.Cells["CODIGO"].Value.ToString();
                cantidad = Convert.ToDecimal(fila.Cells["CANTIDAD"].Value.ToString());



                buscarArticulo(codigo1);


                if (buscarArticulo(codigo1) == true)
                {
                    stock_final = cantidad_stock - cantidad;

                    sql = "update Articulos set cantidad_stock = " + stock_final + " WHERE codigo1 = " + codigo1;
                    cs.ejecutarSentenciaSql(sql);


                }


            }
            sql = "delete from " + tablaCompra + " where num_compra='" + idCompra + "'";
            cs.ejecutarSentenciaSql(sql);

            sql = "delete from " + tabla_detalle_compra + " where idCompra='" + idCompra + "'";
            cs.ejecutarSentenciaSql(sql);
          }
        //metodo para buscar articulos por codigo en el sistema
        public bool buscarArticulo(string codigo1)
          {
                ConexSQL objMiconexion = new ConexSQL();
               

                SqlDataReader miDr;
                SqlParameter[] misParametros = new SqlParameter[1];
                misParametros[0] = new SqlParameter("@codigo1", codigo1);
                String sql = "SELECT * FROM " + tablaArticulo + " WHERE codigo1 = '" + codigo1 + "'";
                miDr = objMiconexion.consultarInformacion(sql, misParametros);
                bool resulta = false;
                miDr.Read();
                try
                {
                    resulta = true;
                    if (miDr.HasRows)
                    {
                        codigo1 = miDr["codigo1"].ToString();
                        cantidad_stock = (decimal)miDr["cantidad_stock"];

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

        //metodo para cargar clientes en un datagridview
        public void cargarClientes(DataGridView dtv)
        {
            try
            {
                String queryClientes = "";

                queryClientes = "SELECT idCliente as 'ID CLIENTE', nombre_cliente as 'NOMBRE CLIENTE', cedula AS CEDULA FROM " + ConexTablas.tablaClientes + " order by " + "idCliente";

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
        //metodo para buscar clientes por nombre
        public bool buscarClientes(DataGridView datos, string nombre_cliente)
        {
            ConexSQL objMiconexion = new ConexSQL();

            SqlDataReader miDr;
            SqlParameter[] misParametros = new SqlParameter[1];
            misParametros[0] = new SqlParameter("@nombre_cliente", nombre_cliente);
            String sql = "SELECT * FROM " + tablaClientes + " WHERE nombre_cliente = '" + nombre_cliente + "'";
            miDr = objMiconexion.consultarInformacion(sql, misParametros);
            bool resulta = false;
            miDr.Read();
            try
            {
                if (miDr.HasRows)
                {

                    String queryClientes = "";

                    queryClientes = "SELECT idCliente as 'ID CLIENTE', nombre_cliente as 'NOMBRE CLIENTE', cedula FROM " + tablaClientes + " WHERE nombre_cliente like('" + nombre_cliente + "%')";

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
        //metodo para cargar vendedores en un datagridview
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
        //metodo para exportar a excel
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

        //cargar los articulos existentes en el invetario
        public void cargarInventario(DataGridView dtv)
        {

            {

                String queryReportes = "";

                queryReportes = "SELECT ta.codigo1 as CODIGO, ta.nombre as DESCRIPCION," +
                    "ta.cantidad_stock as EXISTENCIAS, ta.precio as 'PRECIO VENTA' from " + ConexTablas.tablaArticulo +
                     " as ta order by ta.codigo1";

                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryReportes, ConexSQL.miConexion);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtv.DataSource = dt;

            }

        }

        //cargar en el datagrid las ventas por departamento
        public void cargarVentasDepartamento(DataGridView dtv, string dep, DateTimePicker desde, DateTimePicker hasta)
        {

            {

                String queryReportes = "";
                SqlParameter[] misParametros = new SqlParameter[2];
                misParametros[0] = new SqlParameter("@desde", desde);
                misParametros[1] = new SqlParameter("@hasta", hasta);


                queryReportes = "SELECT tdv.idVenta as COMPROBANTE, tdv.codigo1 as CODIGO, ta.nombre as ARTICULO, td.nombre as DEPARTAMENTO, " +
            "tdv.cantidad as CANTIDAD, tdv.Precio_venta as 'PRECIO VENTA'  FROM "+ConexTablas.tablaVentas+ " as tv INNER JOIN "
            + ConexTablas.tabla_detalle_ventas + " as tdv on tv.idVenta = tdv.idVenta and cast(tv.fecha as date) BETWEEN @desde and @hasta  INNER JOIN " + ConexTablas.tablaArticulo + " as ta on tdv.codigo1 = ta.codigo1 INNER JOIN  " + ConexTablas.tablaDepartamento + " as td " +
            " on ta.idDepartamento = td.idDepartamento and td.nombre= '" + dep + "'";
            
                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(queryReportes, ConexSQL.miConexion);
                cmd.Parameters.AddWithValue("@desde", desde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtv.DataSource = dt;

            }

        }
        //metodo para cargar los proveedores en un datagridview
        public void cargarProveedores(DataGridView dtv)
        {
            try
            {
                String queryProveedores = "";

                queryProveedores = "SELECT idProveedor as 'ID PROVEEDOR', razon_Social as 'RAZON SOCIAL'  FROM " + ConexTablas.tablaProveedor + " order by " + "idProveedor";

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
        //metodo para buscar proveedores por nombre
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

                    queryProveedores = "SELECT idProveedor as 'ID PROVEEDOR', razon_Social as 'RAZON SOCIAL' FROM " + tablaProveedor + " WHERE razon_social like('" + razonsocial + "%')";

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

    }
}