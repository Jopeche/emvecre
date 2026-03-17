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
    public partial class frmUsuarios : Form
    {
        //VARIABLE DE INSTANCIA PARA ACCEDER A LA CLASE DE CONSULTAS DE LAS TABLAS
        ConexTablas ct = new ConexTablas();
        public frmUsuarios()
        {
            InitializeComponent();
        }
        //carga los usuarios en el datagridview
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ct.cargarUsuarios(dgvUsuarios);
            txtAdmin.SelectedIndex = 1;
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
        //exporta los usuarios cargados en el datagridview a un archivo de excel
        private void BtnExpo_Click(object sender, EventArgs e)
        {
            ct.exportarExcel(dgvUsuarios);
        }
        //cierra el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //carga lso datos de la fila en los respectivos campos de texto
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtContrasena.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtAdmin.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
        }
        //limpia los campos de texto
        private void btnCacelar_Click(object sender, EventArgs e)
        {
            Txtbuscar.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
            txtContrasena.Text = "";
            txtAdmin.SelectedIndex =1;
            ct.cargarUsuarios(dgvUsuarios);
        }
        //guarda el nuevo usuario y verifica los datos del ingresados por el usuario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtContrasena.Text != "")
            {

                DialogResult resultado = MessageBox.Show("Desea Guardar los datos?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    ct.guardarUsuario(txtNombre.Text,txtContrasena.Text,txtAdmin.Text);
                    ct.cargarUsuarios(dgvUsuarios);
                    btnCacelar_Click(sender, e);
                    MessageBox.Show("DATOS ALMACENADOS CORRECTAMENTE");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de USUARIO Y CONTRASEÑA");
            }
        }
        //elimina al usuario selecionado por numero de identificacion
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el usuario selecionado?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    ct.eliminarUsuario(txtId.Text);
                    ct.cargarUsuarios(dgvUsuarios);
                    btnCacelar_Click(sender, e);
                    MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE");
                }
            }
            else
            {
                MessageBox.Show("Debe selecionar un usuario");
            }
        }
        //actualiza al usuario por numero de identificacion
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            if (txtId.Text != "" && txtNombre.Text != "" && txtContrasena.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Desea actualizar los datos del usuario selecionado?", "CONFIRMAR", MessageBoxButtons.YesNo);


                if (resultado == DialogResult.Yes)
                {

                    ct.actualizarUsuario(idUsuario, txtNombre.Text,txtContrasena.Text,txtAdmin.Text);
                    ct.MostrarDepartamentos(dgvUsuarios);
                    btnCacelar_Click(sender, e);
                    MessageBox.Show("DATOS ACTUALIZADOS CORRECTAMENTE");
                }
            }
            else
            {
                MessageBox.Show("Debe selecionar un Usuario, debe ingresar un nombre de usuario y contraseña");

            }
        }
        //busca en la lista de usuarios
        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            ct.buscarUsuario(Txtbuscar.Text, dgvUsuarios);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
