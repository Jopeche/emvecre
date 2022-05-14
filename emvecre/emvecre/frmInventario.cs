using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emvecre
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {

        }

        //metodo para abrir formularios en el panel
        private void abrirFormulario<miform>() where miform : Form, new()
        {
            Form formulario;
            formulario = PanelControlInventario.Controls.OfType<miform>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelControlInventario.Controls.Add(formulario);
                PanelControlInventario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();

            }
        }

        //abre el formulario articulos en el panel
        private void btnSalir_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmArticulos>();
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnArticulos.BackColor = Color.LightBlue;
        }

        private void btnArticulos_MouseLeave(object sender, EventArgs e)
        {
            btnArticulos.BackColor = Color.White;
        }

        private void btnDepartamentos_MouseEnter(object sender, EventArgs e)
        {
            btnDepartamentos.BackColor = Color.LightBlue;
        }

        private void btnDepartamentos_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamentos.BackColor = Color.White;
        }

        //abre el formulario departamentos en el panel
        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            abrirFormulario<frmDepartamentos>();
        }

        private void btnSalir_MouseEnter_1(object sender, EventArgs e)
        {
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
    }

        private void btnSalir_MouseEnter_2(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Red;
        }

        private void btnSalir_MouseLeave_1(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.White;

        }

        //cierra el formulario
        private void btnSalir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}