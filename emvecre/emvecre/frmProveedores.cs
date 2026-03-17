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
    public partial class frmProveedores : Form
    {
        ConexTablas ct = new ConexTablas();
        public frmProveedores()
        {
            InitializeComponent();
            ConexSQL.conectar();
            ct.cargarProveedores(dgvProv);
        }
        //inicia el indice de tipo de documento en 0
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cmbTipo_doc.SelectedIndex =0;
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
        //metodo para exportar a excel los datos cargados en el datagridview
        private void BtnExpo_Click(object sender, EventArgs e)
        {
            ct.exportarExcel(dgvProv);
        }
        //metodo para buscar en la lista de proveedores por nombre
        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            ct.buscarProv(dgvProv, Txtbuscar.Text);
        }
        //cierra el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //metodo para cargar los datos de la fila selecionada en los respectivos campos de texto
        private void dgvProv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProv.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvProv.CurrentRow.Cells[1].Value.ToString();
            txtSect_comercial.Text = dgvProv.CurrentRow.Cells[2].Value.ToString();
            cmbTipo_doc.Text = dgvProv.CurrentRow.Cells[3].Value.ToString();
            txtNum_docu.Text = dgvProv.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvProv.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text = dgvProv.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgvProv.CurrentRow.Cells[7].Value.ToString();
            txtURL.Text = dgvProv.CurrentRow.Cells[8].Value.ToString();
        }
        //metodo para limpiar los campos de texto
        private void btnCacelar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtSect_comercial.Text = "";
            cmbTipo_doc.SelectedIndex = 0;
            txtNum_docu.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtURL.Text = "";
            Txtbuscar.Text = "";

        }
        //metodo para guardar el nuevo proveedor y verificar los datos ingresados por el usuario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNum_docu.Text =="")
            {

                MessageBox.Show("Debe ingresar un nombre y numero de documento al proveedor");

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Desea Guardar los datos?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    
                    ct.guardarProveedor(txtNombre.Text, txtSect_comercial.Text, cmbTipo_doc.Text, txtNum_docu.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtURL.Text);
                    MessageBox.Show("DATOS ALMACENADOS CORRECTAMENTE");
                }
            }
            ct.cargarProveedores(dgvProv);
            btnCacelar_Click(sender, e );
        }
        //metodo para eliminar al proveedor por numero de identificacion
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el proveedor selecionado?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    ct.eliminarProv(dgvProv.CurrentRow.Cells[0].Value.ToString());
                    ct.cargarProveedores(dgvProv);
                    btnCacelar_Click(sender, e);
                    MessageBox.Show("PROVEEDOR ELIMINADO CORRECTAMENTE");
                }
            }
            else
            {

                MessageBox.Show("Debe selecionar un Proveedor");
            }

        }
        //metodo para actualizar los datos del proveedor por numero de identificacion
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Desea actualizar los datos del proveedor selecionado?", "CONFIRMAR", MessageBoxButtons.YesNo);


                if (resultado == DialogResult.Yes)
                {

                    ct.actualizarProv(txtId.Text, txtNombre.Text, txtSect_comercial.Text, cmbTipo_doc.Text, txtNum_docu.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtURL.Text);
                    ct.cargarProveedores(dgvProv);
                    btnCacelar_Click(sender, e);
                    MessageBox.Show("PROVEEDOR ACTUALIZADO CORRECTAMENTE");
                }
            }
            else
            {

                MessageBox.Show("Debe selecionar un proveedor");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

