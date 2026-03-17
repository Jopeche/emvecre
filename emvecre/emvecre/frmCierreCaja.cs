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
    public partial class frmCierreCaja : Form
    {
        public frmCierreCaja()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConexTablas ct = new ConexTablas();
            Cierre cr = new Cierre();
            DateTime fecha = DateTime.Now;
            
            decimal repEfectivo = decimal.Parse(txtEfectivo.Text);
            decimal repTarjeta = decimal.Parse(txtTarjeta.Text);

            if (repEfectivo != 0 && repTarjeta != 0)
            {
                cr.Refresh();
                ct.cerrarCaja(fecha, repEfectivo, repTarjeta);

                txtEfectivo.Text = "";
                txtTarjeta.Text = "";
                cr = ct.reporteCierreCaja();
                cvCierreCaja.ReportSource = cr;
                cvCierreCaja.Refresh();
                cr.Dispose();

            }
            else
            {
                MessageBox.Show("DEBE COMLETAR LA INFORMACION","ACEPTAR");
            }

            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnlyNumbersCantidad(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != '.')
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {

                    e.Handled = true;

                    System.Media.SystemSounds.Beep.Play();
                }
            }

            string punto = txtEfectivo.Text;
            int pun = 0;

            for (int i = 0; i < punto.Length; i++)
            {
                if (punto[i] == '.')
                {
                    pun++;
                }
                if (pun >= 1)
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {

                        e.Handled = true;

                    }

                }

            }
        }
    }
}
