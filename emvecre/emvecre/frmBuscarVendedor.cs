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
    public partial class frmBuscarVendedor : Form
    {
        // variable de instancia para acceder al formulario facturar
        frmFacturar f = new frmFacturar();

        //variable de instancia papa acceder a la clase de consulta a base de datos
        ConexTablas ct = new ConexTablas();

        public frmBuscarVendedor()
        {
            InitializeComponent();
            //conectar a la base de datos
            ConexSQL.conectar();
        }

        //cierra el formulario
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

        //carga los vendedores de la base de datos en el formulario
        private void frmBuscarVendedor_Load(object sender, EventArgs e)
        {
           
            ct.cargarVendedor(dgvVendedores);
        }

        //busca los vendedores por nombre cada vez que el usuario agega una letra a la caja de texto
        private void txtBuscarVendedor_TextChanged(object sender, EventArgs e)
        {
            try
            {

                bool resulta = ct.buscarVendedor(txtBuscarVendedor.Text, dgvVendedores);


                if (txtBuscarVendedor.Text == "")
                {
                    ct.cargarVendedor(dgvVendedores);
                }

            }
            catch { }
        }

        //seleciona el vendedor deseado y lo carga en el formulario de facturacion
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                frmFacturar f1 = Application.OpenForms.OfType<frmFacturar>().SingleOrDefault();
                if (f1 != null)
                {

                    f1.txtVendedor.Text = dgvVendedores.CurrentRow.Cells["NOMBRE"].Value.ToString();
                    this.Close(); //Cierro el form2
                }
            }
            catch { }
        }

    }
}
