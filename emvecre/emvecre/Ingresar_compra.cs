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
    public partial class Ingresar_compra : Form
    {

        Art_lista al = new Art_lista();
        ConexTablas ct = new ConexTablas();
        public double impues = 0;
        

        public string proveedor;
        public Ingresar_compra()
        {
            InitializeComponent();

            ConexSQL.conectar();
        }
        
        //carga los datos necesarios para agregar los articulos de compra al datagridview
        private void Ingresar_compra_Load(object sender, EventArgs e)
        {
            txtArticulo.Focus();
            ct.llenarComboProveedores(cmbProveedores);

            dgvCompra.Columns.Add("Codigo", "Codigo");
            dgvCompra.Columns.Add("Nombre", "Nombre");
            dgvCompra.Columns.Add("Precio Venta", "Precio Venta");
            dgvCompra.Columns.Add("Costo", "Costo");
            dgvCompra.Columns.Add("Cantidad", "Cantidad");
            dgvCompra.Columns.Add("Subtotal", "Subtotal");

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = " ";
            btnDelete.HeaderText = " ";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.CellTemplate.Style.BackColor = Color.Red;
            dgvCompra.Columns.Add(btnDelete);

            dgvCompra.Columns[0].ReadOnly = true;
            dgvCompra.Columns[1].ReadOnly = true;
            dgvCompra.Columns[2].ReadOnly = true;
            dgvCompra.Columns[2].DefaultCellStyle.Format = "N2";
            dgvCompra.Columns[3].ReadOnly = false;
            dgvCompra.Columns[3].DefaultCellStyle.Format = "N2";
            dgvCompra.Columns[4].ReadOnly = false;
            dgvCompra.Columns[4].DefaultCellStyle.Format = "N2";
            dgvCompra.Columns[5].ReadOnly = true;
            dgvCompra.Columns[5].DefaultCellStyle.Format = "N2";

        }
 

        
        //agrega la cantidad de articulo y lo carga en el datagridview
        private void txtCantidad_KeyDown_1(object sender, KeyEventArgs e)
        
        {
            bool resulta = false;
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (txtCantidad.Text != "" && double.Parse(txtCantidad.Text)!=0)
                {
                    string nombre = "";
                    decimal precio = 0;

                    string codigo1 = txtArticulo.Text;

                    ct.buscarArticulo(codigo1);

                    foreach (DataGridViewRow filas in dgvCompra.Rows)
                    {
                      
                        if (codigo1 == Convert.ToString(filas.Cells["Codigo"].Value) || ConexTablas.codigo2 == Convert.ToString(filas.Cells["Codigo"].Value))
                        {
                            MessageBox.Show("El articulo ya fue ingresdo puede modificarlo manualmente");
                            txtArticulo.Focus();
                            txtCantidad.Text = "1";
                            txtArticulo.Text = "";
                            txtPrecio.Text = "";
                            resulta = true;
                        }
                        
                    }
                    if (resulta == false)
                    {
                        resulta = ct.cargarArticulosCompra(dgvCompra, txtArticulo.Text, decimal.Parse(txtPrecio.Text), nombre, precio, decimal.Parse(txtCantidad.Text));
                        txtArticulo.Focus();
                        txtCantidad.Text = "1";
                        txtArticulo.Text = "";
                        txtPrecio.Text = "";
                    }

                
                    ct.calculoCompra(dgvCompra, txtSubtotal);
                    decimal total = Convert.ToDecimal(txtSubtotal.Text) + Convert.ToDecimal(txtImpuesto.Text);

                    total = decimal.Round(total, 2);
                    txtTotal.Text = total.ToString();
                }

                else
                {

                    MessageBox.Show("Debe ingresar la cantidad de articulos");
                }
            }
        }
        //verifica el codigo del articulo y agrega el costo en el campo de costo
        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
      
        {

            bool resulta = false;
            resulta = ct.buscarArticulo(txtArticulo.Text);

            if (e.KeyValue == (char)Keys.Enter)
            {
               
                if (resulta == true)
                {
                    txtPrecio.Text = ConexTablas.costo.ToString();
                    txtPrecio.Focus();
       

                }
                else
                {
                    txtArticulo.Text = "";
                    txtPrecio.Text = "";
                    txtCantidad.Text = "1";
                    txtArticulo.Focus();
                    MessageBox.Show("El codigo de articulo no existe");
                }
            }
            
        }

        //guarda el costo ingresado por el usuario
        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            try {

                string punto = txtPrecio.Text;
         
            if (e.KeyValue == (char)Keys.Enter && txtPrecio.Text != "" && txtPrecio.Text != ".")
            {
                for (int i = 0; i < punto.Length; i++)
                {

                    if (punto[0] == '.')
                    {
                        txtPrecio.Text = "0" + punto ;              
                    }
                        if (double.Parse(txtPrecio.Text) == 0)
                        {
                            txtPrecio.Text = ConexTablas.costo.ToString();
                            txtPrecio.Focus();
                        }else
                        {
                            txtCantidad.Focus();
                        }
                        
                }
                }
            }

            catch { }
             
           
        }

        //al cambiar el valor de una celda calcula el valor de total, subtotal e impuesto
        private void dgvCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {



            try
            {

                dgvCompra.CurrentRow.Cells["Costo"].Value = decimal.Round(Convert.ToDecimal(dgvCompra.CurrentRow.Cells["Costo"].Value.ToString()), 2);
                dgvCompra.CurrentRow.Cells["Cantidad"].Value = decimal.Round(Convert.ToDecimal(dgvCompra.CurrentRow.Cells["Cantidad"].Value.ToString()), 2);


                decimal costo = Convert.ToDecimal(dgvCompra.CurrentRow.Cells["Costo"].Value.ToString());
                decimal cantidad = Convert.ToDecimal(dgvCompra.CurrentRow.Cells["Cantidad"].Value.ToString());

                if (cantidad == 0)
                {
                    MessageBox.Show("La cantidad debe ser superior a cero");
                    dgvCompra.CurrentRow.Cells["Cantidad"].Value = 1;
                }
                else if (costo == 0)
                {
                    MessageBox.Show("El costo de venta debe ser superior a cero");
                    dgvCompra.CurrentRow.Cells["Costo"].Value = 1;
                }

                else
                {

                    dgvCompra.Rows[e.RowIndex].Cells[5].Value = costo * cantidad;

                    dgvCompra.Rows[e.RowIndex].Cells[5].Value = decimal.Round(Convert.ToDecimal(dgvCompra.Rows[e.RowIndex].Cells[5].Value), 2);

                    ct.calculoCompra(dgvCompra, txtSubtotal);

                    decimal impuesto = Convert.ToDecimal(ct.buscarGravados(dgvCompra));
                    impuesto = decimal.Round(impuesto, 2);
                    txtImpuesto.Text = impuesto.ToString();

                    decimal total = Convert.ToDecimal(txtSubtotal.Text) + Convert.ToDecimal(txtImpuesto.Text);
                    total = decimal.Round(total, 2);
                    txtTotal.Text = total.ToString();
                }
            }
            catch { }
        }

        //metodo consulta eliminar la fila al presionar en la celda de eliminar
        private void dgvCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            DialogResult resultado;
            try
            {

                ct.buscarArticulo(dgvCompra.CurrentRow.Cells["Codigo"].Value.ToString());



                if (dgvCompra.CurrentRow.Cells[6].Selected)
                {
                    resultado = MessageBox.Show("Desea eliminar la fila selecionada?", "ELIMINAR", MessageBoxButtons.YesNo);
               
                    if (resultado == DialogResult.Yes)
                    {
                        dgvCompra.Rows.RemoveAt(dgvCompra.CurrentRow.Index);


                      
                    }
                    else if (resultado == DialogResult.No)
                    {

                    }

                }

            }

            catch { }
        }

        //al agregar un articulo al datagridview calcula el total de la factura
        private void dgvCompra_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            ct.calculoCompra(dgvCompra, txtSubtotal);
            txtTotal.Text = Convert.ToDecimal(txtSubtotal.Text + txtImpuesto.Text).ToString();
            txtTotal.Text = (Convert.ToDecimal(txtSubtotal.Text) + Convert.ToDecimal(txtImpuesto.Text)).ToString();

        }
        //al quitar un articulo del datagridview calcula el total de la factura
        private void dgvCompra_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            ct.calculoCompra(dgvCompra, txtSubtotal);
            txtImpuesto.Text = Convert.ToDecimal(ct.buscarGravados(dgvCompra)).ToString();
            txtTotal.Text = (Convert.ToDecimal(txtSubtotal.Text) + Convert.ToDecimal(txtImpuesto.Text)).ToString();
        }

        //metodo para verificar los datos ingresados e ingresar la compra al sistema
        private void btnProcesar_Click(object sender, EventArgs e)
        {

            if (cmbProveedores.Text != "" && txtNum_compra.Text != "" && dgvCompra.Rows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Desea ingresar la factura al sistema? ", "CONFIRMAR", MessageBoxButtons.YesNo);


                if (resultado == DialogResult.Yes)
                {


                    DateTime fecha = Convert.ToDateTime(dtpFecha_ingreso.Value.Date.ToString("dd/MM/yyyy"));

                    ct.guardarIngreso(fecha, txtNum_compra.Text, cmbProveedores.Text, Convert.ToDecimal(txtTotal.Text));
                    ct.guardarDetalleIngreso(dgvCompra, txtNum_compra.Text);

                    MessageBox.Show("DATOS ALMACENADOS CORRECTAMENTE");

                    dgvCompra.Rows.Clear();
                    txtArticulo.Text = "";
                    cmbProveedores.Text = "";
                    txtPrecio.Text = "";
                    txtCantidad.Text = "1";
                    txtNum_compra.Text = "";
                    dtpFecha_ingreso.Text.StartsWith(DateTime.Today.ToString());



                }
                else if (resultado == DialogResult.No)
                {
                    MessageBox.Show("INGRESO DE COMPRA CANCELADO");
                }

            }
            else
            {

                MessageBox.Show("DEBE LLENAR TODOS LOS DATOS");
            }

        }
         //metodo para solo permitir numeros en el campo de texto
        private void OnlyNumbersPrecio(object sender, KeyPressEventArgs e)
        {
            if (txtPrecio.Text == "" && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            string punto = txtPrecio.Text;
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
                else if (e.KeyChar != '.' )
                {

                   
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
                    {

                        e.Handled = true;

                        System.Media.SystemSounds.Beep.Play();
                    }
                }
            }
        }
        //metodo para solo permitir numeros en el campo de texto
        private void OnlyNumbersCantidad(object sender, KeyPressEventArgs e)
        {

            if (txtCantidad.Text == "" && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            string punto = txtCantidad.Text;
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

        //metodo solo permite numeros en la celda
        private void dgvCompra_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl OnlyNumbers = (DataGridViewTextBoxEditingControl)e.Control;
            OnlyNumbers.KeyPress -= new KeyPressEventHandler(dgvCompra_KeyPress_1);
            OnlyNumbers.KeyPress += new KeyPressEventHandler(dgvCompra_KeyPress_1);
        }
         //metodo solo permite un punto(necesario para decimales) en las celdas, no permite caracteres que no sean numeros
        private void dgvCompra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
            try
            {
                
                string p = dgvCompra.CurrentCell.EditedFormattedValue.ToString();
                if (p=="" && !Char.IsDigit(e.KeyChar) ) {
                    e.Handled = true;
                }
                    int pun = 0;

                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i] == '.')
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
            catch { }
        }
        //limpia los datos ingresados en la compra actual
        private void btnCancrelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea ingresar la factura al sistema? ", "CONFIRMAR", MessageBoxButtons.YesNo);


            if (resultado == DialogResult.Yes)
            {

                dgvCompra.Rows.Clear();
                txtArticulo.Text = "";
                cmbProveedores.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "1";
                txtNum_compra.Text = "";
                dtpFecha_ingreso.Text = DateTime.Today.ToString();
            }
        }

        //cambia el foco de numero de factura al campo de texto articulos
        private void txtNum_compra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                txtArticulo.Focus();
            }
        }

        //agrega el icono eliminar en la ultima celda
        private void dgvCompra_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvCompra.Columns[e.ColumnIndex].Name == " " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvCompra.Rows[e.RowIndex].Cells[" "] as DataGridViewButtonCell;
                Icon iconoEliminar = new Icon(Environment.CurrentDirectory + @"\imagenes\Eliminar.ico");

                e.Graphics.DrawIcon(iconoEliminar, e.CellBounds.Left + 5, e.CellBounds.Top + 3);
                this.dgvCompra.Rows[e.RowIndex].Height = iconoEliminar.Height + 5;
                this.dgvCompra.Columns[e.ColumnIndex].Width = iconoEliminar.Width + 10;

                e.Handled = true;
            }
        }

        //metodo para buscar articulo
        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            al.btnAceptar.Visible = true;
            al.btnArtFactu.Visible = false;
            al.ShowDialog();
        }
        //cierra el formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea salir? se eliminaran los datos ingresados...!!! ", "CONFIRMAR", MessageBoxButtons.YesNo);


            if (resultado == DialogResult.Yes)
            {

                dgvCompra.Rows.Clear();
                txtArticulo.Text = "";
                cmbProveedores.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "1";
                txtNum_compra.Text = "";
                dtpFecha_ingreso.Text = DateTime.Today.ToString();
            }
            this.Close();
        }

        private void btnProcesar_MouseEnter(object sender, EventArgs e)
        {
            btnProcesar.BackColor = Color.LightBlue;
        }

        private void btnProcesar_MouseLeave(object sender, EventArgs e)
        {
            btnProcesar.BackColor = Color.White;
        }

        //metodo no permite que el costo sea nulo o igual a cero
        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            try { 
            if (double.Parse(txtPrecio.Text)==0)
            {
                txtPrecio.Text = ConexTablas.costo.ToString();
            }
            }
            catch { }
            }
        //metodo no permite que la cantidad ingresada sea nula o igual a cero
        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtCantidad.Text) == 0)
                {
                    txtCantidad.Text = "1";
                    MessageBox.Show("Debe ingresar una cantidad");
                }
            }
            catch { }
        }

        //evita que la cantidad ingresada a la celda sea nula o igual a cero
        private void dgvCompra_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string p = dgvCompra.CurrentCell.EditedFormattedValue.ToString();
            if (p == "")
            {
                dgvCompra.CurrentCell.Value = 1;

            }
        }


        private void dgvCompra_Click(object sender, EventArgs e)
        {
          
        }

        //no permite que la cantidad ingresada en la celda sea de valor nulo
        private void dgvCompra_KeyDown_1(object sender, KeyEventArgs e)
        {
            string p = dgvCompra.CurrentCell.EditedFormattedValue.ToString();
            if (p == "")
            {
                dgvCompra.CurrentCell.Value = 1;

            }
        }

        private void btnBuscarVendedor_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarArticulo.BackColor = Color.LightBlue;
        }

        private void btnBuscarArticulo_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarArticulo.BackColor = Color.White;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

