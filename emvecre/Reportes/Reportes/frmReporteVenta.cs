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
    public partial class frmReporteVenta : Form
    {
        //variable de instancia para la coneccion de tablas
        ConexTablas ct = new ConexTablas();

        //variable de instancia para acceder a la clase venta
        frmVentas fv = new frmVentas();
  
        public frmReporteVenta()
        {
            InitializeComponent();
        }
        //metodo carga el detalle de la venta
        private void frmReporteVenta_Load(object sender, EventArgs e)
        {
         
            ct.cargarDetalleVenta(dgvVenta,int.Parse(lblComprobante.Text));
            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {

                if (fila.Cells["IMPUESTO"].Value.ToString() == "")
                {

                    fila.Cells["IMPUESTO"].Value = 0;
                }
            }
        }
        //metodo consulta para eliminar la factura
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult respuesta = MessageBox.Show("Desea eliminar la factura? ", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    ct.eliminarFactura(dgvVenta, int.Parse(lblComprobante.Text));

                    MessageBox.Show("FACTURA ELIMINADA CORRECTAMENTE");
                    fv.Activate();
                    ct.cargarVentas(fv.dgvVentas, fv.dtpDesde, fv.dtpHasta);
                    this.Close();

                }
            }
            catch { }
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.LightBlue;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.Silver;
        }
        //cierra el formulario
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
    }
}
