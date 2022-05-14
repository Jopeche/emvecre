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
    public partial class frmVendedores : Form
    {
        ConexTablas ct = new ConexTablas();
        public frmVendedores()
        {    
            InitializeComponent();
        }
        //carga la lista de vendedores en el datagridview
        private void frmVendedores_Load(object sender, EventArgs e)
        {
            ct.cargarVendedor(dgvVend);
        }
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightBlue;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Silver;
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
        //carga los datos de la fila selecionada en los respectivos campos de texto
        private void dgvDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvVend.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvVend.CurrentRow.Cells[1].Value.ToString();
        }
        //busca en la lista de vendedores por nombre
        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            ct.buscarVendedor(Txtbuscar.Text, dgvVend);
        }
        //cierra el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //limpia los campos de texto
        private void btnCacelar_Click(object sender, EventArgs e)
        {
            Txtbuscar.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
            ct.cargarVendedor(dgvVend);
        }
        //exporta los datos cargados en el datagridview a un archivo de excel
        private void BtnExpo_Click(object sender, EventArgs e)
        {
            ct.exportarExcel(dgvVend);
        }
        //guarda y verifica los datos del vendedor ingresados por el usuario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {

                DialogResult resultado = MessageBox.Show("Desea Guardar los datos?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    ct.guardarVend(txtNombre.Text);
                    ct.cargarVendedor(dgvVend);
                    btnCacelar_Click(sender, e);
                    MessageBox.Show("DATOS ALMACENADOS CORRECTAMENTE");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de vendedor");
            }
        }
        //elimina por numero de identificacion al vendedor selecionado con los datos ingresados por el usuario
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el vendedor selecionado?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    ct.eliminarVend(txtId.Text);
                    ct.cargarVendedor(dgvVend);
                    btnCacelar_Click(sender, e);
                    MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE");
                }
            }
            else
            {
                MessageBox.Show("Debe selecionar un vendedor");
            }
        }
        //actualiza por numero de identificacion al vendedor selecionado con los datos ingresados por el usuario
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idVend = int.Parse(dgvVend.CurrentRow.Cells[0].Value.ToString());
            if (txtNombre.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Desea actualizar los datos del vendedor selecionado?", "CONFIRMAR", MessageBoxButtons.YesNo);


                if (resultado == DialogResult.Yes)
                {

                    ct.actualizarVend(idVend, txtNombre.Text);
                    ct.MostrarDepartamentos(dgvVend);
                    btnCacelar_Click(sender, e);
                    MessageBox.Show("DATOS ACTUALIZADOS CORRECTAMENTE");
                }
            }
            else
            {
                MessageBox.Show("Debe selecionar un vendedor");

            }
        }
    }
}
