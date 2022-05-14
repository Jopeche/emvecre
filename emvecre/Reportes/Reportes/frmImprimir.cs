using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Reportes
{
    public partial class frmImprimir : Form
    {
        //variable de instancia para acceder a la clase de conexion a las tablas
        ConexTablas ct = new ConexTablas();
        string comprobante= "";
        string cliente = "";
        string fecha = "";
        string total = "";
        public frmImprimir()
        {
            InitializeComponent();
        }
        //cerrar formulario
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
        //muestra loas detalles de la factura
        private void frmImprimir_Load(object sender, EventArgs e)
        {

            ct.cargarDetalleVenta(dgvVenta, int.Parse(lblComprobante.Text));
            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {

                if (fila.Cells["IMPUESTO"].Value.ToString() == "")
                {

                    fila.Cells["IMPUESTO"].Value = 0;
                }
            }
            comprobante = lblComprobante.Text;
            cliente = lblCliente.Text;
            fecha = lblFecha.Text;
            total = lblTotal.Text;
        }

        private void btnReimprimir_MouseEnter(object sender, EventArgs e)
        {
            btnReimprimir.BackColor = Color.LightBlue;
        }
        private void btnReimprimir_MouseLeave(object sender, EventArgs e)
        {
            btnReimprimir.BackColor = Color.Silver;
        }
        //metodo para la impresion de la factura
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int ancho = 600;
            int y = 20;

            e.Graphics.DrawString("-----Repostería Laly&Lucy-----", font, Brushes.Black, new RectangleF(300,y+=30,ancho,20));
            e.Graphics.DrawString("Factura# "+comprobante, font, Brushes.Black, new RectangleF(300, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha " +fecha, font, Brushes.Black, new RectangleF(300, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente " + cliente, font, Brushes.Black, new RectangleF(300, y += 20, ancho, 20));

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                e.Graphics.DrawString(fila.Cells["CODIGO"].Value.ToString()+"   "+
                                      fila.Cells["DESCRIPCION"].Value.ToString() + "   " +
                                      fila.Cells["PRECIO VENTA"].Value.ToString() + "   "
                    , font, Brushes.Black, new RectangleF(300, y += 30, ancho, 20));

            }
        }
        //metodo para imprimir
        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            pdImprimir = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            pdImprimir.PrinterSettings = ps;
            pdImprimir.PrintPage += Imprimir;
            pdImprimir.Print();

        }
    }
}
