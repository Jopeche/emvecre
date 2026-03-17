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
    public partial class frmDepartamentos : Form
    {
        //variable de instancia para acceder a 
        ConexTablas ct = new ConexTablas();
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        //carga los departamentos en el formulario
        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            ct.MostrarDepartamentos(dgvDepartamentos);
        }

        //exporta a excel los datos cargados en el datagridview
        private void BtnExpo_Click(object sender, EventArgs e)
        {
            ct.exportarExcel(dgvDepartamentos);
        }

        //cierra el formulario 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //envia los datos de la linea selecionados en los respectivos campos de texto
        private void dgvDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNombre.Text = dgvDepartamentos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvDepartamentos.CurrentRow.Cells[2].Value.ToString();
            
        }

        //limpia los campos de texto
        private void btnCacelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            Txtbuscar.Text = "";
        }
 

        private void btnCacelar_MouseEnter(object sender, EventArgs e)
        {
            btnCacelar.BackColor = Color.LightBlue;
        }

        private void btnCacelar_MouseLeave(object sender, EventArgs e)
        {
            btnCacelar.BackColor = Color.Silver;
        }

        private void btnGuadar_MouseEnter(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.LightBlue;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.Silver;
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.LightBlue;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.Silver;
        }

        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.LightBlue;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.Silver;
        }

        //guarda los datos ingresados en los campos de texto
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text!="") {

                DialogResult resultado = MessageBox.Show("Desea Guardar los datos?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    ct.guardarDep(txtNombre.Text, txtDescripcion.Text);
                ct.MostrarDepartamentos(dgvDepartamentos);
                btnCacelar_Click(sender, e);
            }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de departamento");
            }
        }

        //elimina los datos de la fila selecionados por id de departamento
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el departamento selecionado?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    ct.eliminarDep(txtNombre.Text = dgvDepartamentos.CurrentRow.Cells[0].Value.ToString());
                ct.MostrarDepartamentos(dgvDepartamentos);
                btnCacelar_Click(sender, e);
            }
            }
            else
            {
                MessageBox.Show("Debe selecionar un departamento");
            }
        }

        //actualiza los datos de la fila selecionados por id de departamento
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idDeparta = int.Parse(dgvDepartamentos.CurrentRow.Cells[0].Value.ToString());
            if (txtNombre.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Desea actualizar los datos del departamento selecionado?", "CONFIRMAR", MessageBoxButtons.YesNo);


                if (resultado == DialogResult.Yes)
                {

                ct.actualizarDep(idDeparta, txtNombre.Text, txtDescripcion.Text);
                ct.MostrarDepartamentos(dgvDepartamentos);
                btnCacelar_Click(sender, e);
            }
            }
            else
            {
                MessageBox.Show("Debe selecionar un departamento");

            }
        }

        //busca los departamentos guardados en la base de datos por nombre
        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            ct.BuscarDep(Txtbuscar.Text, dgvDepartamentos);
        }
    }
}
