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
    public partial class Compras : Form
    {
        //creamos la instancia para la clase donde estan almacenados los metodos
        ConexTablas ct = new ConexTablas();
        public Compras()
        {
            InitializeComponent();
            ConexSQL.conectar();
        }

        private void Compras_Load(object sender, EventArgs e)
        {   
            //en el load del formulario reporte de compras llamamos al metodo para cargar las compras registradas en el sistema
            ct.cargarCompras(dgvCompras, dtpDesde, dtpHasta,txtProveedor.Text);

            //datatimepickr desde valor maximo igual al valor de datetimepicker hasta
            dtpDesde.MaxDate = dtpHasta.Value;
            //datetimepicker hasta valor minimo igual al valor del datetimepicker desde
            dtpHasta.MinDate = dtpDesde.Value;
            //datagridcompras solo lectura
            dgvCompras.ReadOnly = true;
        
        }

        //llamar al metodo exportar a excell mientras el datagrid no este vacio
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvCompras.Rows.Count > 0)
            {
                ct.exportarExcel(dgvCompras);
            }
            else
                MessageBox.Show("NO HAY COMPRAS CARGADAS");    //mesaje mientras el datagridview este vacio
            }

        //definir los valores para el datetimepicker desde
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

            ct.cargarCompras(dgvCompras, dtpDesde, dtpHasta, txtProveedor.Text);//cargar compras por proveedores
            dtpDesde.MaxDate = dtpHasta.Value;
            dtpHasta.MinDate = dtpDesde.Value;

        }

        //definir los valores para el datetimepicker hasta
        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

            ct.cargarCompras(dgvCompras, dtpDesde, dtpHasta, txtProveedor.Text);//cargar compras por proveedores
            dtpDesde.MaxDate = dtpHasta.Value;
            dtpHasta.MinDate = dtpDesde.Value;
        }

        //cargar el detalle de compra ai selecionar sobre la compra deseada
        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmReporteCompra rc = new frmReporteCompra();//instancia para aceder al formulario reporte de compra

                string comprobante = "";
                string proveedor = "";
                string fecha = "";
                string total = "";


                //guargar los valores de lass celdas en variables
                comprobante = dgvCompras.CurrentRow.Cells["COMPROBANTE"].Value.ToString();
                proveedor = dgvCompras.CurrentRow.Cells["PROVEEDOR"].Value.ToString();
                fecha = dgvCompras.CurrentRow.Cells["FECHA"].Value.ToString();
                total = dgvCompras.CurrentRow.Cells["TOTAL"].Value.ToString();

                //pasar los datos a los labels en el formulario detalle de compra
                rc.lblComprobante.Text = comprobante;
                rc.lblProveedor.Text = proveedor;
                rc.lblFecha.Text = fecha;
                rc.lblTotal.Text = total;

                rc.ShowDialog();
                
            }
            catch { }
        }


        // boton para abrir formulario buscar proveedor
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarProveedor bp = new buscarProveedor();
            bp.ShowDialog();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            //cargar las compras
            ct.cargarCompras(dgvCompras, dtpDesde, dtpHasta, txtProveedor.Text);

        }
        //metodo para exportar a excel
        private void BtnExpo_Click(object sender, EventArgs e)
        {
            if (dgvCompras.Rows.Count > 0)
            {
                ct.exportarExcel(dgvCompras);
            }
            else
                MessageBox.Show("NO HAY COMPRAS CARGADAS");    //mesaje mientras el datagridview este vacio
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            buscarProveedor bp = new buscarProveedor();
            bp.ShowDialog();
        }
        //CIERRA EL FORMULARIO
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

