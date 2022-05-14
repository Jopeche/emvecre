//bibliotecas
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
    public partial class frmArticulos : Form
    {

        ConexTablas ct = new ConexTablas();

        public frmArticulos()
        {
            InitializeComponent();

            ConexSQL.conectar();
        }

       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtimpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        //boton para expopner a excel
        private void BtnExpo_Click(object sender, EventArgs e)
        {
            ct.exportarExcel(dgvArticulos);
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstock_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtcodigo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtcodigo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

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

        //cargar los datos al abrir el formulario
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            ct.llenarComboDep(cmbDep);
            cmbDep.SelectedIndex = 0;
            txtimpuesto.SelectedIndex = 1;
            ct.MostrarDatos(dgvArticulos);
            
        }

        //solo permite numeros en el campo de texto
        private void OnlyNumbersStock(object sender, KeyPressEventArgs e)
        {

            if (txtstock.Text == "" && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            string punto = txtstock.Text;

            int pun = 0;

            for (int i = 0; i < punto.Length; i++)
            {
                if (punto[i] == '.')
                {
                    pun++;
                }
                if (pun >= 1)
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {

                        e.Handled = true;

                    }

                }
                else if (e.KeyChar != '.')
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {

                        e.Handled = true;

                        System.Media.SystemSounds.Beep.Play();
                    }
                }
            }
        }

        //solo permite numeros en el campo de texto
        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtcosto.Text == "" && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            string punto = txtcosto.Text;
            int pun = 0;

            for (int i = 0; i < punto.Length; i++)
            {
                if (punto[i] == '.')
                {
                    pun++;
                }
                if (pun >= 1)
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {

                        e.Handled = true;

                    }

                }
                else if (e.KeyChar != '.')
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {

                        e.Handled = true;

                        System.Media.SystemSounds.Beep.Play();
                    }
                }
            }
        }

        //solo permite numeros en el campo de texto
        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtprecio.Text == "" && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            string punto = txtprecio.Text;
            int pun = 0;


            for (int i = 0; i < punto.Length; i++)
            {
                if (punto[i] == '.')
                {
                    pun++;
                }
                if (pun >= 1)
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {

                        e.Handled = true;

                    }

                }
                else if (e.KeyChar != '.')
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {

                        e.Handled = true;

                        System.Media.SystemSounds.Beep.Play();
                    }
                }
            }
        }

        //carga los datos de toda la fila selecionada en los campos de texto
        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbDep.Text = dgvArticulos.CurrentRow.Cells[4].Value.ToString();

            ct.buscarArticulo(cmbDep.ToString());

            try
            {

                Txtcodigo1.Text = dgvArticulos.CurrentRow.Cells[0].Value.ToString();
                Txtcodigo2.Text = dgvArticulos.CurrentRow.Cells[1].Value.ToString();
                txtnombre.Text = dgvArticulos.CurrentRow.Cells[2].Value.ToString();
                txtstock.Text = dgvArticulos.CurrentRow.Cells[3].Value.ToString();
                txtcosto.Text = dgvArticulos.CurrentRow.Cells[5].Value.ToString();
                txtprecio.Text = dgvArticulos.CurrentRow.Cells[6].Value.ToString();
                cmbDep.Text = ConexTablas.tablaDepartamento;
                txtimpuesto.Text = dgvArticulos.CurrentRow.Cells[7].Value.ToString();

            }
            catch
            {

            }
        }

        //guarda los datos en la tabla articulos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsMensaje miRespuesta = new clsMensaje();

            if (Txtcodigo1.Text=="" || txtnombre.Text=="" || txtstock.Text == "" || txtcosto.Text =="" || txtprecio.Text == "") {

                MessageBox.Show("Debe llenar los espacios de: Codigo1, Nombre, Existencias, Costo o Precio");

            }
            else{
                DialogResult resultado = MessageBox.Show("Desea Guardar los datos?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                ct.buscarDepartamento(cmbDep.Text);
                ct.guardarArticulo(Txtcodigo1.Text, Txtcodigo2.Text, txtnombre.Text, Convert.ToDecimal(txtstock.Text), ConexTablas.idDepartamento, Convert.ToDecimal(txtcosto.Text), Convert.ToDecimal(txtprecio.Text), txtimpuesto.Text);

                    if (  miRespuesta.mensajeError=="")
                    {
                        Limpiar();

                    }
                }

            }

            ct.MostrarDatos(dgvArticulos);
         
        }

        //busca articulos por nombre en la base de datos
        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConexTablas ct = new ConexTablas();
                bool resulta = ct.buscarArticulos(dgvArticulos, Txtbuscar.Text);


                if (Txtbuscar.Text == "")
                {

                    ct.MostrarDatos(dgvArticulos);
                }

            }
            catch { }

            Txtcodigo1.Text = "";
            Txtcodigo2.Text = "";
            txtnombre.Text = "";
            txtstock.Text = "";
            txtcosto.Text = "";
            txtprecio.Text = "";
            cmbDep.SelectedIndex = 0;
            txtimpuesto.SelectedIndex = 1;
        }


        //elimina datos en la tabla articulos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool accion = ct.buscarArticulo(Txtcodigo1.Text);

            if (accion == true)
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el articulo selecionado?", "CONFIRMAR", MessageBoxButtons.YesNo);

            if (resultado==DialogResult.Yes) { 
                ct.eliminarArticulo(dgvArticulos.CurrentRow.Cells["Codigo 1"].Value.ToString());
                MessageBox.Show("EL ARTICULO FUE ELIMINADO CON EXITO");
                ct.MostrarDatos(dgvArticulos);
                Limpiar();
                }
            else
            {
                ct.MostrarDatos(dgvArticulos);
            }
            }
            else
            {
                MessageBox.Show("EL ARTICULO NO EXISTE, VERIFIQUE EL CODIGO 1");
                Limpiar();
            }
        }

        //modifica datos en la tabla articulos
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try { 
            bool accion = ct.buscarArticulo(Txtcodigo1.Text);

            if (accion==true) { 
            DialogResult resultado = MessageBox.Show("Desea actualizar los datos del articulo?", "CONFIRMAR", MessageBoxButtons.YesNo);


            if (resultado == DialogResult.Yes)
            {
                    ct.buscarDepartamento(cmbDep.Text);
                    ct.actualizarArticulo(Txtcodigo1.Text, Txtcodigo2.Text, txtnombre.Text, Convert.ToDecimal(txtstock.Text), ConexTablas.idDepartamento, Convert.ToDecimal(txtcosto.Text), Convert.ToDecimal(txtprecio.Text), txtimpuesto.Text);
                MessageBox.Show("DATOS ACTUALIZADOS CORRECTAMENTE");
                ct.MostrarDatos(dgvArticulos);
                Limpiar();
            }
            else
            {
                ct.MostrarDatos(dgvArticulos);
            }
            }
            else{
                MessageBox.Show("EL ARTICULO NO EXISTE, VERIFIQUE EL CODIGO 1");
                Limpiar();
            }
            }
            catch { }
        }

        //limpia los campos de texto
        public void Limpiar()
        {
          
            Txtcodigo1.Text = "";
            Txtcodigo2.Text = "";
            txtnombre.Text = "";
            txtstock.Text = "";
            txtcosto.Text = "";
            txtprecio.Text = "";
            Txtbuscar.Text = "";
            cmbDep.SelectedIndex = 0;
            txtimpuesto.SelectedIndex = 1;

        }

        private void btnCacelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvArticulos_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void Txtbuscar_Validating(object sender, CancelEventArgs e)
        {
           
        }

        //cierra el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
