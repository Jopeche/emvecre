using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }
        //metodo para buscar cliente por nombre
        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConexTablas ct = new ConexTablas();
                bool resulta = ct.buscarClientes(dgvCliente, txtCliente.Text);

                if (txtCliente.Text == "")
                {

                    ct.cargarClientes(dgvCliente);
                }
            }
            catch { }
        }
        //metodo para buscar cliente por letra
        private void txtProveedor_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                ConexTablas ct = new ConexTablas();
                bool resulta = ct.buscarClientes(dgvCliente, txtCliente.Text);
            }
            catch { }
        }
        //metodo para selecionar el cliente
        private void bntSelecionar_Click(object sender, EventArgs e)
        {
            frmVentas f1 = Application.OpenForms.OfType<frmVentas>().SingleOrDefault();

            if (f1 != null)
            {

                f1.txtCliente.Text = dgvCliente.CurrentRow.Cells["nombre_Cliente"].Value.ToString();
                this.Close(); //Cierro el form2
            }
        }
        //metodo para cargar la lista de cliente al abrir el formulario
        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            ConexTablas ct = new ConexTablas();
            ct.cargarClientes(dgvCliente);
        }
        //metodo para cerrar el formulario
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Silver;
        }
        //metodo para cargar el nombre del cliente en el formulario correspondiente
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                frmVentas f1 = Application.OpenForms.OfType<frmVentas>().SingleOrDefault();


            frmBuscarFactura bf = Application.OpenForms.OfType<frmBuscarFactura>().SingleOrDefault();

            if (frmVentas.permitir == true)
            {
                frmVentas.nombreCliente = dgvCliente.CurrentRow.Cells["NOMBRE CLIENTE"].Value.ToString();
                f1.txtCliente.Text = frmVentas.nombreCliente;
                frmVentas.permitir = false;
                this.Close();
            }
            if(frmBuscarFactura.permitir==true)
            {

                frmBuscarFactura.nombreCliente = dgvCliente.CurrentRow.Cells["NOMBRE CLIENTE"].Value.ToString();
                bf.txtCliente.Text = frmBuscarFactura.nombreCliente;
                frmBuscarFactura.permitir =false;
                this.Close();
            }
            }
            catch { }
        }

        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.LightBlue;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.Silver;
        }
    }
}
