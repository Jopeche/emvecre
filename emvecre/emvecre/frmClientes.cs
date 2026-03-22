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
    public partial class frmClientes : Form
    {
        //variable de instancia para acceder a la clase para las consultas a las tablas
        ConexTablas ct = new ConexTablas();
        public frmClientes()
        {
            InitializeComponent();
            ConexSQL.conectar();
        }

        //carga los clientes en el formulario
        private void frmClientes_Load(object sender, EventArgs e)
        {
            ct.cargarClientes(dgvClientes);
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

        //carga lso datos del datagridview en un archivo de excel
        private void BtnExpo_Click(object sender, EventArgs e)
        {
            ct.exportarExcel(dgvClientes);
        }

        //busca el cliente en la base de datos cada vez que el usuario agrega una letra
        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            ct.buscarClientes(dgvClientes,Txtbuscar.Text);
        }

        //carga los datos de la fila seleccionada en los campos de texto respectivos
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                dtpFecha_nac.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtCedula.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
                txtEmail.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        //cierra el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //limpia los campos de texto
        private void btnCacelar_Click(object sender, EventArgs e)
        {
     
            txtNombre.Text = "";
            dtpFecha_nac.Value = DateTime.Now;
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }
        
        //Guarda el cliente con la informacion ingresada en los campos de texto
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text!="")
            {

                DialogResult resultado = MessageBox.Show("Desea Guardar los datos?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    ct.guardarCliente(txtNombre.Text, dtpFecha_nac.Value, txtCedula.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
                ct.cargarClientes(dgvClientes);
                btnCacelar_Click(sender, e);

                }
            }
            else
            {

                MessageBox.Show("Debe ingresar el nombre del cliente");
            }
        }

        //elimina el cliente selecionado de la base de datos por id
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el cliente selecionado?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    ct.eliminarCliente(dgvClientes.CurrentRow.Cells[0].Value.ToString());
                ct.cargarClientes(dgvClientes);
                btnCacelar_Click(sender, e);

            }
            }
            else
            {

                MessageBox.Show("Debe selecionar un cliente");
            }
        }

        //modifica el cliente selecionado de la base de datos por id
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Desea actualizar los datos del cliente selecionado?", "CONFIRMAR", MessageBoxButtons.YesNo);


                if (resultado == DialogResult.Yes)
                {

                    ct.actualizarCliente(dgvClientes.CurrentRow.Cells[0].Value.ToString(), txtNombre.Text, dtpFecha_nac.Value, txtCedula.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
                ct.cargarClientes(dgvClientes);
                btnCacelar_Click(sender, e);

                }
            }
            else
            {

                MessageBox.Show("Debe selecionar un cliente");
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
