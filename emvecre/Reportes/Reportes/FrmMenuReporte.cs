using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reportes
{
    public partial class FrmMenuReporte : Form
    {
        public FrmMenuReporte()
        {
            InitializeComponent();
        }
        //metodo para abrir formularios
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
        //abrir formulario ventas
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmVentas f1 = Application.OpenForms.OfType<frmVentas>().SingleOrDefault();
            if (f1 !=null) {

            f1.Close();

            }
            abrirFormulario<frmVentas>();
        }
        //abrir formulario reporte ventas por departamento
        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmVentasDepartamento>();
        }
        //cerrar formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturar_MouseEnter(object sender, EventArgs e)
        {
            btnRepVenta.BackColor = Color.LightBlue;
        }

        private void btnRepVenta_MouseLeave(object sender, EventArgs e)
        {
            btnRepVenta.BackColor = Color.White;
        }

        private void btnReimprimir_MouseEnter(object sender, EventArgs e)
        {
            btnRepDepart.BackColor = Color.LightBlue;
        }

        private void btnRepDepart_MouseLeave(object sender, EventArgs e)
        {
            btnRepDepart.BackColor = Color.White;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.LightBlue;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.White;
        }

    }
}
