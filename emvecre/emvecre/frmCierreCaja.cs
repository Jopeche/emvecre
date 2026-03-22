using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
        Cierre cr = new Cierre();
        ConexTablas ct = new ConexTablas();

        public frmCierreCaja()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
           

            DateTime fecha = DateTime.Now;

            decimal repEfectivo = decimal.Parse(txtEfectivo.Text);
            decimal repTarjeta = decimal.Parse(txtTarjeta.Text);

            if (repEfectivo != 0 && repTarjeta != 0)
            {
                
                ct.cerrarCaja(fecha, repEfectivo, repTarjeta);

                txtEfectivo.Text = "";
                txtTarjeta.Text = "";
                cr = ct.reporteCierreCaja();
                cvCierreCaja.ReportSource = cr;
                cvCierreCaja.Refresh();
            

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

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.LightBlue;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.White;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.LightBlue;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.White;
        }

        private void txtEfectivo_Click(object sender, EventArgs e)
        {
            txtEfectivo.SelectAll();
        }

        private void txtTarjeta_Click(object sender, EventArgs e)
        {
            txtTarjeta.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            ct.eliminarCierre(fecha);
        }
    }
}
