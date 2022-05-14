using System;
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

            PanelPrincipal.Visible = false;
        }

        private void btnFacturar_MouseEnter(object sender, EventArgs e)
        {
            btnFacturar.BackColor = Color.LightBlue;
        }

        private void btnCompras_MouseEnter(object sender, EventArgs e)
        {
            btnCompras.BackColor = Color.LightBlue;
        }

        private void btnInventario_MouseEnter(object sender, EventArgs e)
        {
            btnInventario.BackColor = Color.LightBlue;
        }

        private void btnClientes_MouseEnter(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.LightBlue;
        }

        private void btnProveedores_MouseEnter(object sender, EventArgs e)
        {
            btnProveedores.BackColor = Color.LightBlue;
        }

        private void btnFacturar_MouseLeave(object sender, EventArgs e)
        {
            btnFacturar.BackColor = Color.White;
        }

        private void btnCompras_MouseLeave(object sender, EventArgs e)
        {
            btnCompras.BackColor = Color.White;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackColor = Color.White;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.White;
        }

        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {
            btnProveedores.BackColor = Color.White;
        }

        //abre el formulario para ingresar compras
        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario<Ingresar_compra>();
            PanelPrincipal.Visible = false;
        }

        //abre el formulario de inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmInventario>();
            PanelPrincipal.Visible = false;
        }
        //abre el formulario de clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmClientes>();
            PanelPrincipal.Visible = false;
        }
        //abre el formulario de proveedores
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmProveedores>();
            PanelPrincipal.Visible = false;

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            btnVendedores.BackColor = Color.LightBlue;
        }

        private void btnVendedores_MouseLeave(object sender, EventArgs e)
        {
            btnVendedores.BackColor = Color.White;
        }
        //abre el formulario de vendedores
        private void btnVendedores_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmVendedores>();
            PanelPrincipal.Visible = false;
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
            PanelPrincipal.Visible = false;
        }

        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.LightBlue;
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.White;
        }

        private void btnRepCompras_MouseEnter(object sender, EventArgs e)
        {
            btnRepCompras.BackColor = Color.LightBlue;
        }

        private void btnRepCompras_MouseLeave(object sender, EventArgs e)
        {
            btnRepCompras.BackColor = Color.White;
        }

        //abre el formulario de reporte de compras
        private void btnRepCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario<Compras>();
            PanelPrincipal.Visible = false;
        }
    }
}
