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
    public partial class frmRetiroEfectivo : Form
    {
        public frmRetiroEfectivo()
        {
            InitializeComponent();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            ConexTablas ct = new ConexTablas();
            DateTime fecha = DateTime.Today;

            if (Convert.ToDecimal(txtMonto.Text) == 0)
            {
                MessageBox.Show("El monto a retirar debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Desea retirar el efectivo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    ct.retirarEfectivo(fecha, Convert.ToDecimal(txtMonto.Text), txtDescripcion.Text);
                    MessageBox.Show("Efectivo retirado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Retiro cancelado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                

            
        }

        private void frmRetiroEfectivo_Load(object sender, EventArgs e)
        {
            txtDescripcion.Text = "Retiro de efectivo";
            txtMonto.Text = "0.00";
        }
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, el punto decimal y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }


        private void txtMonto_Click(object sender, EventArgs e)
        {
            txtMonto.SelectAll();
        }
    }
}
