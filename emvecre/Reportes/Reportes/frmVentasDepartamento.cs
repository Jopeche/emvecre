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
    public partial class frmVentasDepartamento : Form
    {
        //VARIABLE DE INSTANCIA PARA ACCEDER A LA CLASE CONECCION DE TABLAS
        ConexTablas ct = new ConexTablas();
        public string dep = "";
        public frmVentasDepartamento()
        {
            InitializeComponent();
        }

        //metodo para cargar facturas por fecha
        private void frmVentasDepartamento_Load(object sender, EventArgs e)
        {
            //llenar en el combobox todos los nombres con los departamentos almacenados en la base de datos
            ct.llenarCombo(cmbDepartamentos);

            
            dtpDesde.MaxDate = dtpHasta.Value;
            dtpHasta.MinDate = dtpDesde.Value;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //exportar a excell la informacion del datagridview

            if (dgvVentas.Rows.Count > 0)
            {
                ct.exportarExcel(dgvVentas);
            }
            else
                MessageBox.Show("NO HAY ARTICULOS CARGADAS");
        }
        //carga las ventas por nombre de departamento y rango de fecha
        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

            dep = cmbDepartamentos.SelectedItem.ToString();

            ct.cargarVentasDepartamento(dgvVentas, dep,dtpDesde,dtpHasta);

            string departamento = cmbDepartamentos.SelectedItem.ToString();
        }
        //carga las ventas por rango de fecha inicial
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
         
            ct.cargarVentasDepartamento(dgvVentas, dep, dtpDesde, dtpHasta);
            dtpDesde.MaxDate = dtpHasta.Value;
            dtpHasta.MinDate = dtpDesde.Value;
        }
        //carga las ventas por rango de fecha final
        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
         
            ct.cargarVentasDepartamento(dgvVentas, dep , dtpDesde, dtpHasta);
            dtpDesde.MaxDate = dtpHasta.Value;
            dtpHasta.MinDate = dtpDesde.Value;
        }

        private void BtnExpo_Click(object sender, EventArgs e)
        {
            //exportar a excell la informacion del datagridview

            if (dgvVentas.Rows.Count > 0)
            {
                ct.exportarExcel(dgvVentas);
            }
            else
                MessageBox.Show("NO HAY ARTICULOS CARGADAS");
        }
        //cierra el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
