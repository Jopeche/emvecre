using System;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Reportes;

namespace emvecre
{
    public partial class frmMenuPrincipal : Form
    {
       
        public frmMenuPrincipal()
        {
            InitializeComponent();
           
            //conexion a la base de datos
            ConexSQL.conectar();

            //crea las tablas en la base de datos en caso de que no existan

            crearTablas.crear_tabla_articulos(); //creacion de la tabla Articulos
            crearTablas.crear_tabla_clientes(); //creacion de la tabla Clientes
            crearTablas.crear_tabla_departamentos(); //creacion de la tabla Departamento
            crearTablas.crear_tabla_detalle_compra(); //creacion de la tabla detalle_Compras
            crearTablas.crear_tabla_compra(); //creacion de la tabla Compra
            crearTablas.crear_tabla_proveedor(); //creacion de la tabla Proveedor
            crearTablas.crear_tabla_vendedor(); //creacion de la tabla Vendedor
            crearTablas.crear_tabla_ventas(); //creacion de la tabla Ventas
            crearTablas.crear_tabla_detalle_ventas(); //creacion de la tabla Detalle ventas
            crearTablas.crearusuarios(); //creacion de la tabla usuarios                              
            crearTablas.crear_tabla_cierre_caja(); //Creacion de la tabla cierre de caja
            iniciarProyecto();
        }

        public void iniciarProyecto()
        {
            ConexTablas ct = new ConexTablas();
            DateTime dateTime = DateTime.Now;
            string sql = "select * from clientes";
            SqlDataReader miDr;
            miDr = ConexSQL.consultarInformacionSinParm(sql);
            if (miDr.HasRows==false)
            {
                ct.guardarCliente("CLIENTE CONTADO",dateTime,"000000000","","","");
                sql = "";
                miDr.Dispose();
            }
            sql = "select * from vendedor";
            miDr = ConexSQL.consultarInformacionSinParm(sql);
            if(miDr.HasRows==false)
            {
                ct.guardarVend("SISTEMA");
                sql = "";
                miDr.Dispose();
            }
            sql = "select * from departamento";
            miDr = ConexSQL.consultarInformacionSinParm(sql);
            if (miDr.HasRows == false)
            {
                ct.guardarDep("GENERAL","Departamento general de articulos");
                sql = "";
                miDr.Dispose();
            }
        }




        //Metodo para abrir formularios en el panel
        private void abrirFormulario<miform>() where miform : Form, new()
        {
            
            Form formulario;
            formulario = panelOperaciones.Controls.OfType<miform>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelOperaciones.Controls.Add(formulario);
                panelOperaciones.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
              
            }
        }

        //cierra el la aplicacion.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        //minimiza la aplicacion
        private void btnMInimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMInimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMInimizar.BackColor = Color.LightBlue;

        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnMInimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMInimizar.BackColor = Color.SteelBlue;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.SteelBlue;
        }

        //abre el formulario de menu de facturacion
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmMenuFacturacion>();

        }

        private void btnFacturar_MouseEnter(object sender, EventArgs e)
        {
            btnFacturar.BackColor = Color.LightBlue;
            btnFacturar.Height = btnFacturar.Height + 5;
            btnFacturar.Width = btnFacturar.Width + 5;
        }

        private void btnCompras_MouseEnter(object sender, EventArgs e)
        {
            btnCompras.BackColor = Color.LightBlue;
            btnCompras.Height = btnCompras.Height + 5;
            btnCompras.Width = btnCompras.Width + 5;
        }

        private void btnInventario_MouseEnter(object sender, EventArgs e)
        {
            btnInventario.BackColor = Color.LightBlue;
            btnInventario.Height = btnInventario.Height + 5;
            btnInventario.Width = btnInventario.Width + 5;
        }

        private void btnClientes_MouseEnter(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.LightBlue;
            btnClientes.Height = btnClientes.Height + 5;
            btnClientes.Width = btnClientes.Width + 5;
        }

        private void btnProveedores_MouseEnter(object sender, EventArgs e)
        {
            btnProveedores.BackColor = Color.LightBlue;
            btnProveedores.Height = btnProveedores.Height + 5;
            btnProveedores.Width = btnProveedores.Width + 5;
        }

        private void btnFacturar_MouseLeave(object sender, EventArgs e)
        {
            btnFacturar.BackColor = Color.White;
            btnFacturar.Height = btnFacturar.Height - 5;
            btnFacturar.Width = btnFacturar.Width - 5;
        }

        private void btnCompras_MouseLeave(object sender, EventArgs e)
        {
            btnCompras.BackColor = Color.White;
            btnCompras.Height = btnCompras.Height - 5;
            btnCompras.Width = btnCompras.Width - 5;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = Color.White;
            btnInventario.Height = btnInventario.Height - 5;
            btnInventario.Width = btnInventario.Width - 5;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.White;
            btnClientes.Height = btnClientes.Height - 5;
            btnClientes.Width = btnClientes.Width - 5;
        }

        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {
            btnProveedores.BackColor = Color.White;
            btnProveedores.Height = btnProveedores.Height - 5;
            btnProveedores.Width = btnProveedores.Width - 5;
        }

        //abre el formulario para ingresar compras
        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario<Ingresar_compra>();
        }

        //abre el formulario de inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmInventario>();
        }
        //abre el formulario de clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmClientes>();
        }
        //abre el formulario de proveedores
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmProveedores>();

        }

        private void btnVendedores_MouseEnter(object sender, EventArgs e)
        {
            btnVendedores.BackColor = Color.LightBlue;
            btnVendedores.Height = btnVendedores.Height + 5;
            btnVendedores.Width = btnVendedores.Width + 5;
        }


        private void btnVendedores_MouseLeave(object sender, EventArgs e)
        {
            btnVendedores.BackColor = Color.White;
            btnVendedores.Height = btnVendedores.Height - 5;
            btnVendedores.Width = btnVendedores.Width - 5;

        }
        //abre el formulario de vendedores
        private void btnVendedores_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmVendedores>();
        }

        private void btnUsuarios_MouseEnter(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = Color.LightBlue;

        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = Color.White;
        }
        //abre el formulario de usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmUsuarios>();
        }
        //abre el formulario de menu de reportes
        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario<FrmMenuReporte>();
        }

        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.LightBlue;
            btnVentas.Height = btnVentas.Height + 5;
            btnVentas.Width = btnVentas.Width + 5;
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.White;
            btnVentas.Height = btnVentas.Height - 5;
            btnVentas.Width = btnVentas.Width - 5;
        }

        private void btnRepCompras_MouseEnter(object sender, EventArgs e)
        {
            btnRepCompras.BackColor = Color.LightBlue;
            btnRepCompras.Height = btnRepCompras.Height + 5;
            btnRepCompras.Width = btnRepCompras.Width + 5;
        }

        private void btnRepCompras_MouseLeave(object sender, EventArgs e)
        {
            btnRepCompras.BackColor = Color.White;
            btnRepCompras.Height = btnRepCompras.Height - 5;
            btnRepCompras.Width = btnRepCompras.Width - 5;
        }

        //abre el formulario de reporte de compras
        private void btnRepCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario<Compras>();
        }
    }
}
