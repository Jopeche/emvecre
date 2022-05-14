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
    public partial class frmBuscarFactura : Form
    {
        ConexTablas ct = new ConexTablas();

        //variables para los procesos del formulario
        public static string nombreCliente="";
        public static string nombreVendedor = "";
        public static bool permitir = false;
        public frmBuscarFactura()
        {
            InitializeComponent();
            ConexSQL.conectar();
        }


        //metodo para cargar la lista de facturas y cambiar la lista segun sea la selecion del usuario
        private void frmBuscarFactura_Load(object sender, EventArgs e)
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
        //metodo para abrir el formulario de buscar clientes
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCliente bc = new frmBuscarCliente();

            bc.ShowDialog();
        }
        //metodo para cambiar la lista de facturas segun sea el rango de fecha inicial
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
        //metodo para cambiar la lista de facturas segun sea el rango de fecha final
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
        //metodo para cambiar la lista de facturas segun sea el nombre del cliente
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
        //metodo para abrir el detalle de l factura al selecionarla dentro del datagridview para reporte de venta
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmReporteVenta rv = new frmReporteVenta();

                string comprobante = "";
                string cliente = "";
                string fecha = "";
                string total = "";

                comprobante = dgvVentas.CurrentRow.Cells["COMPROBANTE"].Value.ToString();
                cliente = dgvVentas.CurrentRow.Cells["NOMBRE CLIENTE"].Value.ToString();
                fecha = dgvVentas.CurrentRow.Cells["FECHA"].Value.ToString();
                total = dgvVentas.CurrentRow.Cells["TOTAL"].Value.ToString();

                rv.lblComprobante.Text = comprobante;
                rv.lblCliente.Text = cliente;
                rv.lblFecha.Text = fecha;
                rv.lblTotal.Text = total;

                rv.ShowDialog();

            }
            catch { }
        }
        //metodo para exportar a excel la lista de facturas
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.Rows.Count > 0)
            {
                ct.exportarExcel(dgvVentas);
            }
            else
                MessageBox.Show("NO HAY FACTURAS CARGADAS");
        }
        //metodo para abrir el formulario de buscar vendedores
        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarVendedor bv = new frmBuscarVendedor();
            bv.ShowDialog();
        }
        //metodo para cargar la lista de vendedore segun el vendedor selecionado
        private void txtVendedor_TextChanged(object sender, EventArgs e)
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
        //metodo para cargar lista de facturas si se desea mostrar por cliente
        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            ct.cargarVentasCliente(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text);
            dtpDesde.MaxDate = dtpHasta.Value;
            dtpHasta.MinDate = dtpDesde.Value;
        }
        //metodo para cargar lista de facturas si se desea mostrar por vendedor y cliente
        private void rdbClienteVendedor_CheckedChanged(object sender, EventArgs e)
        {
            ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta, txtCliente.Text, txtVendedor.Text);
            dtpDesde.MaxDate = dtpHasta.Value;
            dtpHasta.MinDate = dtpDesde.Value;
        }
        //metodo para cargar lista de facturas si se desea mostrar por vendedor
        private void rdbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            ct.cargarVentasVendedor(dgvVentas, dtpDesde, dtpHasta, txtVendedor.Text);
            dtpDesde.MaxDate = dtpHasta.Value;
            dtpHasta.MinDate = dtpDesde.Value;
        }
        //metodo para cargar lista de facturas si se desea mostrar por fechas
        private void rdbVentas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVentas.Checked == true)
            {
                ct.cargarVentas(dgvVentas, dtpDesde, dtpHasta);
                dtpDesde.MaxDate = dtpHasta.Value;
                dtpHasta.MinDate = dtpDesde.Value;
            }
        }
        //metodo para permitir la busqueda del cliente
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente bc = new frmBuscarCliente();
            permitir = true;
            bc.ShowDialog();
        }
        //metodo para permitir la busqueda del vendedor
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
        //cerrar el formulario
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //metodo para abrir el detalle de l factura al selecionarla dentro del datagridview para imprimir la factura
        private void dgvVentas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmImprimir rv = new frmImprimir();

                string comprobante = "";
                string cliente = "";
                string fecha = "";
                string total = "";

                comprobante = dgvVentas.CurrentRow.Cells["COMPROBANTE"].Value.ToString();
                cliente = dgvVentas.CurrentRow.Cells["NOMBRE CLIENTE"].Value.ToString();
                fecha = dgvVentas.CurrentRow.Cells["FECHA"].Value.ToString();
                total = dgvVentas.CurrentRow.Cells["TOTAL"].Value.ToString();

                rv.lblComprobante.Text = comprobante;
                rv.lblCliente.Text = cliente;
                rv.lblFecha.Text = fecha;
                rv.lblTotal.Text = total;

                rv.ShowDialog();

            }
            catch { }
        }
    }
}

