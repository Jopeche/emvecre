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
   
    public partial class frmProcesarFactura : Form
    {
        
   
        public frmProcesarFactura()
        {
            InitializeComponent();
        }

        //carga los datos necesarios
        private void frmProcesarFactura_Load(object sender, EventArgs e)
        {
            rdbEfectivo.Checked = true; 
            txtEfectivo.Focus();
            btnCancelar.BackColor = Color.SkyBlue;
            btnFacturar.BackColor = Color.SkyBlue;
        }

        //procede con la facturacion si los datos son correctos
        private void txtPaga_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == (char)Keys.Enter && txtEfectivo.Text != "")
            {
                decimal total = Convert.ToDecimal(lblTotal.Text);
                decimal paga = Convert.ToDecimal(txtEfectivo.Text);
                if (paga >= total)
                {
                    decimal cambio = paga - total;
                    lblCambio.Text = cambio.ToString();
                    btnFacturar.Enabled = true;
                    btnFacturar.Focus();
                    btnFacturar.BackColor = Color.LightBlue;
                }
                else
                {
                    decimal cambio = paga - total;
                    lblCambio.Text = cambio.ToString();
                    MessageBox.Show("FALTA DINERO PARA CANCELAR LA FACTURA: " + cambio);
                  
                }

            }
        }
        //procede con la facturacion si los datos son correctos
        private void txtPaga_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal total = Convert.ToDecimal(lblTotal.Text);
                decimal paga = Convert.ToDecimal(txtEfectivo.Text);
                if (paga >= total)
                {
                    decimal cambio = paga - total;
                    lblCambio.Text = cambio.ToString();
                    btnFacturar.Enabled = true;
                    btnFacturar.Focus();
                }
                else if (btnFacturar.Enabled == true)
                {
                    decimal cambio = paga - total;
                    lblCambio.Text = cambio.ToString();
                    MessageBox.Show("FALTA DINERO PARA CANCELAR LA FACTURA: " + cambio);
                    btnFacturar.Enabled = false;

                }
            }
            catch { }
        }

        //cierra el formulario de procesar factura sin procesar la factura
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            lblCambio.Text = "0";
            txtEfectivo.Focus();
            this.Close();
        }
        //metodo para realizar la venta
        private void btnFacturar_Click_1(object sender, EventArgs e)
        {
            frmFacturar f1 = Application.OpenForms.OfType<frmFacturar>().SingleOrDefault();

            if (rdbEfectivo.Checked == true)
            {
                f1.tipoPago = "Efectivo";

            }
            if (rdbTarjeta.Checked == true)
            {
                f1.tipoPago = "Tarjeta";
            }
             if (rdbTransferencia.Checked == true)
            {
                f1.tipoPago = "Transferencia";
            }

            if (txtEfectivo.Text=="" || txtEfectivo.Text == "." || Convert.ToDouble(txtEfectivo.Text)==0 || Convert.ToDouble(txtEfectivo.Text)< Convert.ToDouble(lblTotal.Text))
            {
                txtEfectivo.Text = lblTotal.Text;
                lblCambio.Text = "0";
                MessageBox.Show("El efectivo no puede ser inferior al monto a pagar");
            }
            else { 
            if (f1 != null)
            {

                f1.permitir = true;
               
                this.Close();
                }

            
            }
           
        }
        //metodo para solo permitir numeros en el monto con el que cancela el cliente
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

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.LightBlue;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.SkyBlue;
        }

        private void btnFacturar_MouseEnter(object sender, EventArgs e)
        {
            btnFacturar.BackColor = Color.LightBlue;
        }

        private void btnFacturar_MouseLeave(object sender, EventArgs e)
        {
            btnFacturar.BackColor = Color.SkyBlue;
        }
        //habilita el boton de procesar factura
        private void txtPaga_Validated(object sender, EventArgs e)
        {
            while (txtEfectivo.Text == "")
            {
                btnFacturar.Enabled = false;

            }
        }
        //Deshabilita el boton de procesar factura
        private void txtPaga_Validating(object sender, CancelEventArgs e)
        {
            while (txtEfectivo.Text=="")
            {
                btnFacturar.Enabled = false;

            }
        }
        //metodo para facturar
        private void btnFacturar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
            frmFacturar f1 = Application.OpenForms.OfType<frmFacturar>().SingleOrDefault();

            if (rdbEfectivo.Checked==true) {
                f1.tipoPago = "Efectivo";
                
            }else if (rdbTarjeta.Checked==true)
            {
                f1.tipoPago = "Tarjeta";
            }
            else
            {
                f1.tipoPago = "Transferencia";
            }



            if (txtEfectivo.Text == "" || txtEfectivo.Text == "." || Convert.ToDouble(txtEfectivo.Text) == 0 || Convert.ToDouble(txtEfectivo.Text) < Convert.ToDouble(lblTotal.Text))
            {
                txtEfectivo.Text = lblTotal.Text;
                lblCambio.Text = "0";
                MessageBox.Show("El efectivo no puede ser inferior al monto a pagar");
            }
            else
            {
                if (f1 != null)
                {
                    f1.permitir = true;

                    this.Close();
                }
            }
        }
    }
}
