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
    public partial class frmBuscarCliente : Form
    {
        //variable de instancia para acceder a la clase conexion y consulta de las tablas
        ConexTablas ct = new ConexTablas();

        public frmBuscarCliente()
        {
            InitializeComponent();
            ConexSQL.conectar();
           

        }

       //cierra la aplicacion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightBlue;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.White;
        }
        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.LightBlue;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.White;
        }

        //busca cliente por nombre en el campo de texto
        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            ConexTablas ct = new ConexTablas();
            ct.cargarClientes(dgvClientes);
          
        }

        //busca cliente cada vez que el usuario ingresa una letra
        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                bool resulta = ct.buscarClientes(dgvClientes, txtBuscarCliente.Text);


                if (txtBuscarCliente.Text == "")
                {
                    ct.cargarClientes(dgvClientes);
                }

            }
            catch { }
        }

        //carga el nombre del cliente en el formulario deseado
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                frmFacturar f1 = Application.OpenForms.OfType<frmFacturar>().SingleOrDefault();
                if (f1 != null)
                {

                    f1.txtCliente.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtBuscarCliente.Text = "";
                    this.Close(); //Cierro el form2
                }
            }
            catch { }
        }
    }
}
