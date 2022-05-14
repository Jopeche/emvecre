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
    public partial class frmBuscarVendedor : Form
    {
        //variable de instancia para acceder a la clase coneccion de tablas
        ConexTablas ct = new ConexTablas();
        public frmBuscarVendedor()
            
        {
            InitializeComponent();
        }
        //metodo para cargar los vendedores en el datagridview
        private void frmBuscarVendedor_Load(object sender, EventArgs e)
        {
            ct.cargarVendedor(dgvVendedor);
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
        //metodo para buscar vendedor y pasar el dato al formulario correspondiente
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try { 
            frmVentas f1 = Application.OpenForms.OfType<frmVentas>().SingleOrDefault();


            frmBuscarFactura bf = Application.OpenForms.OfType<frmBuscarFactura>().SingleOrDefault();

            if (frmVentas.permitir == true)
            {
                frmVentas.nombreVendedor = dgvVendedor.CurrentRow.Cells["nombre"].Value.ToString();
                f1.txtVendedor.Text = frmVentas.nombreVendedor;
                frmVentas.permitir = false;
                this.Close();
            }
            if (frmBuscarFactura.permitir == true)
            {

                frmBuscarFactura.nombreVendedor = dgvVendedor.CurrentRow.Cells["nombre"].Value.ToString();
                bf.txtVendedor.Text = frmBuscarFactura.nombreVendedor;
                frmBuscarFactura.permitir = false;
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
