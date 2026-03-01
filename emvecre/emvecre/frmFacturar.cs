using System;
using System.Drawing;
using System.Windows.Forms;
using emvecre;

namespace emvecre
{
    public partial class frmFacturar : Form
    {
        //variables de instancia
        Art_lista al = new Art_lista();
        frmBuscarCliente buscar = new frmBuscarCliente();
        frmProcesarFactura pf = new frmProcesarFactura();

        //CONEXION A LA CLASE PARA LA CONSULTA DE LAS TABLAS
        ConexTablas ct = new ConexTablas();
    
        public bool permitir = false;
        public string tipoPago = "";
        public string nombreArticulo="";

        public frmFacturar()
        {
            InitializeComponent();
            
        }

        
        private void btnBuscarCliente_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarCliente.BackColor = Color.LightBlue;
        }

        private void btnBuscarCliente_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarCliente.BackColor = Color.White;
        }

        private void btnBuscarVendedor_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarVendedor.BackColor = Color.LightBlue;
        }

        private void btnBuscarVendedor_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarVendedor.BackColor = Color.White;
        }

        private void btnBuscarArticulo_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarArticulo.BackColor = Color.LightBlue;
        }

        private void btnBuscarArticulo_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarArticulo.BackColor = Color.White;
        }
         //abre el formulario para buscar cliente
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            
            buscar.ShowDialog();
            txtCliente.Focus();
        }
        //abre el formulario para buscar vendedor
        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            frmBuscarVendedor buscar = new frmBuscarVendedor();
            buscar.ShowDialog();
            txtVendedor.Focus();
        }

        private void btnProcesar_MouseEnter(object sender, EventArgs e)
        {
            btnProcesar.BackColor = Color.LightBlue;
        }

        private void btnProcesar_MouseLeave(object sender, EventArgs e)
        {
            btnProcesar.BackColor = Color.White;
        }

        //carga y personaliza las columnas necesarias para la facturacion
        private void frmFacturar_Load(object sender, EventArgs e)
        {
            txtArticulo.Focus();
            ConexTablas ct = new ConexTablas();


            dgvFactura.Columns.Add("Codigo", "Codigo");
            dgvFactura.Columns.Add("Descripcion", "Descripcion");
            dgvFactura.Columns.Add("Precio", "Precio");
            dgvFactura.Columns.Add("Cantidad", "Cantidad");
            dgvFactura.Columns.Add("Descuento", "Descuento");
            dgvFactura.Columns.Add("Subtotal", "Subtotal");

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Eliminar Articulo";
            btnDelete.HeaderText = "Eliminar Articulo";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.CellTemplate.Style.BackColor = Color.Red;
            dgvFactura.Columns.Add(btnDelete);

            dgvFactura.Columns[0].ReadOnly = true;
            dgvFactura.Columns[1].ReadOnly = true;
            dgvFactura.Columns[2].ReadOnly = false;
            dgvFactura.Columns[2].DefaultCellStyle.Format = "N2";
            dgvFactura.Columns[3].ReadOnly = false;
            dgvFactura.Columns[3].DefaultCellStyle.Format = "N2";
            dgvFactura.Columns[4].ReadOnly = false;
            dgvFactura.Columns[4].DefaultCellStyle.Format = "N2";
            dgvFactura.Columns[5].ReadOnly = true;
            dgvFactura.Columns[5].DefaultCellStyle.Format = "N2";
        }

        //habilita el boton para buscar el articulo en el otro formulario
        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            al.btnAceptar.Visible = false;
            al.btnArtFactu.Visible = true;
            al.ShowDialog();        
        }

        //verifica el codigo de articulo ingresado y al presionar "enter" el foco cambia a la caja de txto cantidad
        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
           
            bool resulta = false;
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (txtArticulo.Text!="") { 
                resulta = ct.buscarArticulo(txtArticulo.Text);
                if (resulta == true)
                {
                    txtCantidad.Text = "1";
                    txtCantidad.Focus();
                    lblNombreArticulo.Text = ct.nomArticulo();
                }
                else
                {
                    txtArticulo.Text = "";
                    lblNombreArticulo.Text = "";
                    txtArticulo.Focus();
                    MessageBox.Show("EL CODIGO INGRESADO NO EXISTE");
                    }
                }
                else
                {
                    MessageBox.Show("DEBE INGRESAR UN CODIGO DE ARTICULO");
                }
            }
        }

        //solo permite numeros en la caja de texto cantidad
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

        //carga el articulo y la cantidad en el datagridview
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            bool resulta = false;
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (txtCantidad.Text != "" && double.Parse(txtCantidad.Text) != 0 && txtArticulo.Text!="")
                {
                    string nombre = "";
                    decimal precio = 0;



                    string codigo1 = txtArticulo.Text;
                    ct.buscarArticulo(codigo1);

                    foreach (DataGridViewRow filas in dgvFactura.Rows)
                    {
                        if (codigo1 == Convert.ToString(filas.Cells["Codigo"].Value) || ConexTablas.codigo2 == Convert.ToString(filas.Cells["Codigo"].Value))
                        {
                            MessageBox.Show("El articulo ya fue ingresdo puede modificarlo manualmente");
                            txtArticulo.Focus();
                            txtCantidad.Text = "1";
                            txtArticulo.Text = "";
                            lblNombreArticulo.Text = "";
                            resulta = true;
                        }

                    }
                    if (resulta==false) {

                        resulta = ct.cargarArticulosVenta(dgvFactura, txtArticulo.Text, nombre, precio, decimal.Parse(txtCantidad.Text));
                        txtArticulo.Focus();
                        txtCantidad.Text = "1";
                        txtArticulo.Text = "";
                        lblNombreArticulo.Text = "";
                    }
                  
                
                    ct.calculoCompra(dgvFactura, txtSubtotal);
                    decimal total = Convert.ToDecimal(txtSubtotal.Text) + Convert.ToDecimal(txtImpuesto.Text);
                    total = decimal.Round(total, 2);
                    txtTotal.Text = total.ToString();
                }
                else
                {

                    MessageBox.Show("Debe ingresar la cantidad de articulos y un codigo de articulo");
                    txtArticulo.Focus();
                }
            }
        }

        //metodo verifica los datos al modificar una celda del datagridview
        private void dgvFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal descontar = 0;
            try
            {

                dgvFactura.CurrentRow.Cells["Precio"].Value = decimal.Round(Convert.ToDecimal(dgvFactura.CurrentRow.Cells["Precio"].Value.ToString()), 2);
                dgvFactura.CurrentRow.Cells["Cantidad"].Value = decimal.Round(Convert.ToDecimal(dgvFactura.CurrentRow.Cells["Cantidad"].Value.ToString()), 2);
                dgvFactura.CurrentRow.Cells["Descuento"].Value = decimal.Round(Convert.ToDecimal(dgvFactura.CurrentRow.Cells["Descuento"].Value.ToString()), 2);

                decimal costo = Convert.ToDecimal(dgvFactura.CurrentRow.Cells["Precio"].Value.ToString());
                decimal cantidad = Convert.ToDecimal(dgvFactura.CurrentRow.Cells["Cantidad"].Value.ToString());
                decimal descuento = Convert.ToDecimal(dgvFactura.CurrentRow.Cells["Descuento"].Value.ToString());

                if (descuento >= 100)
                {
                    MessageBox.Show("el descuento no puede ser igual ni mayor al 100%");
                    dgvFactura.CurrentRow.Cells["Descuento"].Value = 0;
                }
                else if (cantidad == 0)
                {
                    MessageBox.Show("La cantidad debe ser superior a cero");
                    dgvFactura.CurrentRow.Cells["Cantidad"].Value = 1;
                }
                else if (costo == 0)
                {
                    MessageBox.Show("El precio de venta debe ser superior a cero");
                    dgvFactura.CurrentRow.Cells["Precio"].Value = 1;
                }
                else
                {
                    if (dgvFactura.CurrentRow.Cells["Descuento"].Value.ToString() != "")
                    {
                        dgvFactura.Rows[e.RowIndex].Cells[5].Value = costo * cantidad;
                        decimal subtotal = Convert.ToDecimal(dgvFactura.Rows[e.RowIndex].Cells[5].Value);
                        descontar = subtotal * descuento / 100;
                        dgvFactura.Rows[e.RowIndex].Cells[5].Value = subtotal - descontar;

                        dgvFactura.Rows[e.RowIndex].Cells[5].Value = decimal.Round(Convert.ToDecimal(dgvFactura.Rows[e.RowIndex].Cells[5].Value), 2);

                        ct.calculoCompra(dgvFactura, txtSubtotal);

                        decimal impuesto = Convert.ToDecimal(ct.buscarGravados(dgvFactura));
                        impuesto = decimal.Round(impuesto, 2);
                        txtImpuesto.Text = impuesto.ToString();

                        decimal total = Convert.ToDecimal(txtSubtotal.Text) + Convert.ToDecimal(txtImpuesto.Text);
                        total = decimal.Round(total, 2);
                        txtTotal.Text = total.ToString();

                    }
                    else
                    {
                        dgvFactura.Rows[e.RowIndex].Cells[5].Value = costo * cantidad;

                        dgvFactura.Rows[e.RowIndex].Cells[5].Value = decimal.Round(Convert.ToDecimal(dgvFactura.Rows[e.RowIndex].Cells[5].Value), 2);

                        ct.calculoCompra(dgvFactura, txtSubtotal);

                        decimal impuesto = Convert.ToDecimal(ct.buscarGravados(dgvFactura));
                        impuesto = decimal.Round(impuesto, 2);
                        txtImpuesto.Text = impuesto.ToString();

                        decimal total = Convert.ToDecimal(txtSubtotal.Text) + Convert.ToDecimal(txtImpuesto.Text);
                        total = decimal.Round(total, 2);
                        txtTotal.Text = total.ToString();
                    }

                }
            }
            catch { }
        }

        //metodo de consulta para eliminar un articulo del datagridview al presionar sobre la celda de eliminar
        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
           
            DialogResult resultado;
            try
            {

                ct.buscarArticulo(dgvFactura.CurrentRow.Cells["Codigo"].Value.ToString());



                if (dgvFactura.CurrentRow.Cells["Eliminar Articulo"].Selected)
                {
                    resultado = MessageBox.Show("Desea eliminar la fila selecionada?", "ELIMINAR", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {


                        dgvFactura.Rows.RemoveAt(dgvFactura.CurrentRow.Index);
                    }
                    else if (resultado == DialogResult.No)
                    {

                    }

                }

            }

            catch { }
        }

        //metodo para agregar el icono eliminar en la ultima columna
        private void dgvFactura_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvFactura.Columns[e.ColumnIndex].Name == "Eliminar Articulo" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvFactura.Rows[e.RowIndex].Cells["Eliminar Articulo"] as DataGridViewButtonCell;
                Icon iconoEliminar = new Icon(Environment.CurrentDirectory + @"\imagenes\Eliminar.ico");

                e.Graphics.DrawIcon(iconoEliminar, e.CellBounds.Left + 20, e.CellBounds.Top + 3);
                this.dgvFactura.Rows[e.RowIndex].Height = iconoEliminar.Height + 10;
                this.dgvFactura.Columns[e.ColumnIndex].Width = iconoEliminar.Width + 45;


                e.Handled = true;
            }
        }
        //cierra el formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        //calcula el subtotal, impuesto y total cada vez que se agrega un nuevo articulo al datagridview
        private void dgvFactura_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ct.calculoCompra(dgvFactura, txtSubtotal);
            txtImpuesto.Text = Convert.ToDecimal(ct.buscarGravados(dgvFactura)).ToString();
            txtTotal.Text = (Convert.ToDecimal(txtSubtotal.Text) + Convert.ToDecimal(txtImpuesto.Text)).ToString();
        }

        //calcula el subtotal, impuesto y total cada vez que se elimina un articulo al datagridview
        private void dgvFactura_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ct.calculoCompra(dgvFactura, txtSubtotal);
            txtImpuesto.Text = Convert.ToDecimal(ct.buscarGravados(dgvFactura)).ToString();
            txtTotal.Text = (Convert.ToDecimal(txtSubtotal.Text) + Convert.ToDecimal(txtImpuesto.Text)).ToString();
        }

        //solo permite numeros dentro de las celdas especificas del datagridview
        private void dgvFactura_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl OnlyNumbers = (DataGridViewTextBoxEditingControl)e.Control;
            OnlyNumbers.KeyPress -= new KeyPressEventHandler(dgvFactura_KeyPress);
            OnlyNumbers.KeyPress += new KeyPressEventHandler(dgvFactura_KeyPress);

           
        }

        //metodo que solo permite numeros y un punto para los decimales en el datagridview
        private void dgvFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            try
            {

                string p = dgvFactura.CurrentCell.EditedFormattedValue.ToString();
                int pun = 0;

                if (p == "" && !Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

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

        //metodo para llevar el total la formulario de procesar factura para finalizar la venta
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            frmBuscarVendedor bv = new frmBuscarVendedor();

            if (dgvFactura.Rows.Count > 0)
            {
                pf.lblTotal.Text = txtTotal.Text;
                pf.txtEfectivo.Text=txtTotal.Text;
                pf.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay articulos cargados en la factura");
            }
            if (permitir == true)
            {

                ct.buscarCliente(txtCliente.Text);
                ct.buscarVendedor(txtVendedor.Text, bv.dgvVendedores);
                DateTime fecha = DateTime.Now;
                char estado = 'n';
           
                ct.guardarVenta(ConexTablas.idCliente, ConexTablas.idVendedor, tipoPago, fecha, Convert.ToDecimal(txtTotal.Text),estado);

                ct.buscarVenta();


                ct.guardarDetalleVenta(dgvFactura, ConexTablas.idVenta);

                MessageBox.Show("FACTURA PROCESADA CORRECTAMENTE");

                dgvFactura.Rows.Clear();
                txtArticulo.Text = "";
                txtCantidad.Text = "1";
                txtCliente.Text = "Cliente Contado";
                txtVendedor.Text = "SISTEMA";
                permitir = false; 

            }
        }

        //metodo para limpiar los datos ingresados en la factura actual
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resultado;


            resultado = MessageBox.Show("Desea cancelar la factura", "ELIMINAR", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                dgvFactura.Rows.Clear();
                txtCliente.Text = "Cliente Contado";
                txtVendedor.Text = "SISTEMA";
                txtArticulo.Text = "";
                txtCantidad.Text = "1";

            }
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.LightBlue;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.White;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightBlue;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.White;
        }

        //metodo que no permite que la cantidad de articulo a facturar sea menor o igual a 0
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


    

        //metodo para evitar que el usuario valide una cantidad nula o igual a cero dentro de las celdas
        private void dgvFactura_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string p = dgvFactura.CurrentCell.EditedFormattedValue.ToString();
            if (p == "")
            {
                dgvFactura.CurrentCell.Value = 1;
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImpuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVendedor_Click(object sender, EventArgs e)
        {

        }


        private void btnFactu1_Click(object sender, EventArgs e)
        {
            Facturas f = new Facturas();
            ElemenFactura elemento = new ElemenFactura();
            f.llenarFactura(elemento, dgvFactura);
        }
       
    }
}
