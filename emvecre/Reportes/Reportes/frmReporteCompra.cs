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
    public partial class frmReporteCompra : Form
    {
        //variable de instancia para acceder a la clase coneccion tablas
        ConexTablas ct = new ConexTablas();

        //variable de instancia paar acceder a la clase compras
        Compras fv = new Compras();
 

        public frmReporteCompra()
        {
            InitializeComponent();
            ConexSQL.conectar();
        }
        //carga el detalle de la compra
        private void frmReporteCompra_Load(object sender, EventArgs e)
        {
            ct.cargarDetalleCompra(dgvCompra, int.Parse(lblComprobante.Text));
            foreach (DataGridViewRow fila in dgvCompra.Rows)
            {

                if (fila.Cells["IMPUESTO"].Value.ToString() == "")
                {

                    fila.Cells["IMPUESTO"].Value = 0;
                }
            }
        }
        //elimina la compra selecionada
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Desea eliminar la compra? ", "CONFIRMAR", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                ct.eliminarCompra(dgvCompra, int.Parse(lblComprobante.Text));

                MessageBox.Show("COMPRA ELIMINADA CORRECTAMENTE");
                this.Close();
          
            }
        }
        
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Silver;
        }
        //cierra el formulario
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //elimina la factura
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea eliminar la compra? ", "CONFIRMAR", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                ct.eliminarCompra(dgvCompra, int.Parse(lblComprobante.Text));

                MessageBox.Show("COMPRA ELIMINADA CORRECTAMENTE");
                this.Close();
            }
    }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.LightBlue;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.Silver;
        }
    }
}