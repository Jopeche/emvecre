using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Reportes;


namespace emvecre
{
    public partial class frmMenuFacturacion : Form
    {
        //VARIABLES DE INSTANCIA PARA LOS FORMULARIOS
        frmFacturar f = new frmFacturar();
        frmVentas v = new frmVentas();
       
        public frmMenuFacturacion()
        {
            InitializeComponent();
        }

        //metodo para abrir los formularios en el panel
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

    

        //MINIMIZAR FORMULARIO
        private void btnMInimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //CAMBIA EL COLOR DEL BOTON PARA INDICAR QUE EL CURSOR ESTA DENTRO DEL COMPONENTE
        private void btnFacturar_MouseEnter(object sender, EventArgs e)
        {
            btnFacturar.BackColor = Color.LightBlue;
        }

        private void btnFacturar_MouseClick(object sender, MouseEventArgs e)
        {
            abrirFormulario<frmFacturar>();

        }

        //CAMBIA EL COLOR DEL BOTON PARA INDICAR QUE EL CURSOR ESTA FUERA DEL COMPONENTE
        private void btnFacturar_MouseLeave(object sender, EventArgs e)
        {
            btnFacturar.BackColor = Color.White;
        }


        //CAMBIA EL COLOR DEL BOTON PARA INDICAR QUE EL CURSOR ESTA DENTRO DEL COMPONENTE
        private void btnReimprimir_MouseEnter(object sender, EventArgs e)
        {
            btnReimprimir.BackColor = Color.LightBlue;
        }

        //CAMBIA EL COLOR DEL BOTON PARA INDICAR QUE EL CURSOR ESTA FUERA DEL COMPONENTE
        private void btnReimprimir_MouseLeave(object sender, EventArgs e)
        {
            btnReimprimir.BackColor = Color.White;
        }

        //CAMBIA EL COLOR DEL BOTON PARA INDICAR QUE EL CURSOR ESTA DENTRO DEL COMPONENTE
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightBlue;
        }

        //CAMBIA EL COLOR DEL BOTON PARA INDICAR QUE EL CURSOR ESTA FUERA DEL COMPONENTE
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.White;

        }
        //cierra el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        //abre el formulario de ventas en el panel
        private void btnVentas_Click(object sender, EventArgs e)
        {

        }
        //cierra el formulario ventas en caso de que este abierto
        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            frmVentas f1 = Application.OpenForms.OfType<frmVentas>().SingleOrDefault();
            if (f1 != null)
            {

                f1.Close();

            }
            abrirFormulario<frmVentas>();
        }

        //abre el formulario de reimpresion en el panel
        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmBuscarFactura>();
        }

        private void btnDevolucion_MouseEnter(object sender, EventArgs e)
        {
            btnDevolucion.BackColor = Color.LightBlue;
        }

        private void btnDevolucion_MouseLeave(object sender, EventArgs e)
        {
            btnDevolucion.BackColor = Color.White;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmCierreCaja>();
        }

        private void btnCierreCaja_MouseEnter(object sender, EventArgs e)
        {
            btnCierreCaja.BackColor = Color.LightBlue;
        }

        private void btnCierreCaja_MouseLeave(object sender, EventArgs e)
        {
            btnCierreCaja.BackColor = Color.White;
        }

        private void panelOperaciones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
