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
    public partial class frmVentas : Form
    {
        //variable de instancia para acceder a la clase conexion de tablas
        ConexTablas ct = new ConexTablas();

        //variables necesarias para los procesos del reporte de ventas
        public static string nombreCliente = "";
        public static string nombreVendedor = "";
        public static bool permitir = false;
        public frmVentas()
        {
            InitializeComponent();
            ConexSQL.conectar();
        }
        //metodo para cargar las facturas por rango de fecha
        private void frmVentas_Load(object sender, EventArgs e)
        {
            if (rdbVentas.Checked == true)
            {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }

            if (rdbClienteVendedor.Checked == true)
            {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text, txtVendedor.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
            else if (rdbCliente.Checked == true)
            {
                ct.cargarVentasCliente(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
            else if (rdbVendedor.Checked == true)
            {
                ct.cargarVentasCliente(dgvVentas, dtpDesde, dtpHasta, txtVendedor.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }

            dgvVentas.ReadOnly = true;
            dgvVentas.Columns[3].DefaultCellStyle.Format = "N2";
        }
        
        //metodo para cargar las facturas por rango de fecha inicial
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (rdbVentas.Checked == true)
            {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }

            if (rdbClienteVendedor.Checked == true)
            {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text, txtVendedor.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
            else if (rdbCliente.Checked == true)
            {
                ct.cargarVentasCliente(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
            else if (rdbVendedor.Checked == true)
            {
                ct.cargarVentasVendedor(dgvVentas, dtpDesde, dtpHasta, txtVendedor.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }

        }
        //metodo para cargar las facturas por rango de fecha final
        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

            if (rdbVentas.Checked == true)
            {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }

            if (rdbClienteVendedor.Checked == true)
            {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text, txtVendedor.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
            else if (rdbCliente.Checked == true)
            {
                ct.cargarVentasCliente(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
            else if (rdbVendedor.Checked == true)
            {
                ct.cargarVentasVendedor(dgvVentas, dtpDesde, dtpHasta, txtVendedor.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
        }
        //carga las facturas por el cliente ingresado
        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (rdbVentas.Checked == true)
            {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }


            if (rdbClienteVendedor.Checked == true)
            {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text, txtVendedor.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
            else if (rdbCliente.Checked == true)
            {
                ct.cargarVentasCliente(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
            else if (rdbVendedor.Checked == true)
            {
                ct.cargarVentasVendedor(dgvVentas, dtpDesde, dtpHasta, txtVendedor.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
        }
        //carga el formulario del detalle de la factura al selecionarla en el datagridview
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmReporteVenta rv = new frmReporteVenta();

                string comprobante = "";
                string cliente = "";
                string tipoPago = "";
                string fecha = "";
                string total = "";

                comprobante = dgvVentas.CurrentRow.Cells["COMPROBANTE"].Value.ToString();
                cliente = dgvVentas.CurrentRow.Cells["NOMBRE CLIENTE"].Value.ToString();
                tipoPago = dgvVentas.CurrentRow.Cells["TIPO PAGO"].Value.ToString();
                fecha = dgvVentas.CurrentRow.Cells["FECHA"].Value.ToString();
                total = dgvVentas.CurrentRow.Cells["TOTAL"].Value.ToString();


                rv.lblComprobante.Text = comprobante;
                rv.lblCliente.Text = cliente;
                rv.lblTipoPago.Text = tipoPago;
                rv.lblFecha.Text = fecha;
                rv.lblTotal.Text = total;

                rv.ShowDialog();
             
            }
            catch { }
        }
        //carga las facturas por nombre de vendedor
        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {
            if (rdbVentas.Checked == true)
            {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }

            if (rdbClienteVendedor.Checked == true) {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text, txtVendedor.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;

            } else if (rdbCliente.Checked == true) {
                ct.cargarVentasCliente(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
            else if (rdbVendedor.Checked == true) {
                ct.cargarVentasVendedor(dgvVentas, dtpDesde, dtpHasta, txtVendedor.Text);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
        }
        //carga facturas por nombre de cliente y rango de fecha
        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            ct.cargarVentasCliente(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text);
            dtpDesde.MaxDate = dtpHasta.Value;
            dtpHasta.MinDate = dtpDesde.Value;
        }
        //carga facturas por nombre de vendedor, cliente y rango de fecha
        private void rdbClienteVendedor_CheckedChanged(object sender, EventArgs e)
        {
            ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text, txtVendedor.Text);
            dtpDesde.MaxDate = dtpHasta.Value;
            dtpHasta.MinDate = dtpDesde.Value;
        }
        //carga facturas por nombre de vendedor y rango de fecha
        private void rdbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            ct.cargarVentasVendedor(dgvVentas, dtpDesde, dtpHasta, txtVendedor.Text);
            dtpDesde.MaxDate = dtpHasta.Value;
            dtpHasta.MinDate = dtpDesde.Value;
        }
        //carga facturas por fecha
        private void rdbVentas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVentas.Checked == true)
            {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
        }
        //exporta aexcel las facturas cargadas en el datagridview
        private void BtnExpo_Click(object sender, EventArgs e)
        {
            if (dgvVentas.Rows.Count > 0)
            {
                ct.exportarExcel(dgvVentas);
            }
            else
                MessageBox.Show("NO HAY FACTURAS CARGADAS");
        }
        //accede al formulario buscar cliente
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente bc = new frmBuscarCliente();
            permitir = true;
            bc.ShowDialog();
        }
        //abre el formulario para buscar vendedores
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmBuscarVendedor bv = new frmBuscarVendedor();
            permitir = true;
            bv.ShowDialog();
        }

        private void btnBuscarCliente_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarCliente.BackColor = Color.LightBlue;
        }

        private void btnBuscarCliente_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarCliente.BackColor = Color.White;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarVendedor.BackColor = Color.LightBlue;
        }

        private void btnBuscarVendedor_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarVendedor.BackColor = Color.White;
        }
        //cierra el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




           