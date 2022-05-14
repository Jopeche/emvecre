namespace emvecre
{
    partial class frmFacturar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblClientes = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnProcesar = new System.Windows.Forms.PictureBox();
            this.btnBuscarArticulo = new System.Windows.Forms.PictureBox();
            this.btnBuscarVendedor = new System.Windows.Forms.PictureBox();
            this.btnBuscarCliente = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcesar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblClientes.Location = new System.Drawing.Point(17, 14);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(109, 33);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(158, 13);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(1004, 30);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.Text = "CLIENTE CONTADO";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Location = new System.Drawing.Point(158, 66);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(1004, 30);
            this.txtVendedor.TabIndex = 3;
            this.txtVendedor.Text = "SISTEMA";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVendedor.Location = new System.Drawing.Point(17, 66);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(140, 33);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor";
            this.lblVendedor.Click += new System.EventHandler(this.lblVendedor_Click);
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblArticulo.Location = new System.Drawing.Point(17, 144);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(121, 33);
            this.lblArticulo.TabIndex = 6;
            this.lblArticulo.Text = "Articulo";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulo.Location = new System.Drawing.Point(154, 147);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(357, 30);
            this.txtArticulo.TabIndex = 7;
            this.txtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyDown);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(1053, 144);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(156, 30);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.Text = "1";
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersCantidad);
            this.txtCantidad.Validated += new System.EventHandler(this.txtCantidad_Validated);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCantidad.Location = new System.Drawing.Point(914, 144);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(133, 33);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToResizeColumns = false;
            this.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFactura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvFactura.EnableHeadersVisualStyles = false;
            this.dgvFactura.Location = new System.Drawing.Point(6, 183);
            this.dgvFactura.Name = "dgvFactura";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFactura.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy;
            this.dgvFactura.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFactura.Size = new System.Drawing.Size(1502, 582);
            this.dgvFactura.TabIndex = 6;
            this.dgvFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellClick);
            this.dgvFactura.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellEndEdit);
            this.dgvFactura.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellLeave);
            this.dgvFactura.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvFactura_CellPainting);
            this.dgvFactura.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellValidated);
            this.dgvFactura.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvFactura_EditingControlShowing);
            this.dgvFactura.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvFactura_RowsAdded);
            this.dgvFactura.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvFactura_RowsRemoved);
            this.dgvFactura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFactura_KeyDown);
            this.dgvFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvFactura_KeyPress);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(6, 830);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(299, 30);
            this.txtSubtotal.TabIndex = 13;
            this.txtSubtotal.Text = "0";
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSubtotal.Location = new System.Drawing.Point(12, 797);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(156, 33);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "SUBTOTAL";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Location = new System.Drawing.Point(617, 830);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(301, 30);
            this.txtImpuesto.TabIndex = 17;
            this.txtImpuesto.Text = "0";
            this.txtImpuesto.TextChanged += new System.EventHandler(this.txtImpuesto_TextChanged);
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblImpuesto.Location = new System.Drawing.Point(623, 797);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(154, 33);
            this.lblImpuesto.TabIndex = 16;
            this.lblImpuesto.Text = "IMPUESTO";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1244, 830);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(292, 30);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Text = "0";
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotal.Location = new System.Drawing.Point(1250, 797);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 33);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "TOTAL";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.ErrorImage = null;
            this.btnCancelar.Image = global::emvecre.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(655, 870);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(198, 121);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ErrorImage = null;
            this.btnSalir.Image = global::emvecre.Properties.Resources.Regresar;
            this.btnSalir.Location = new System.Drawing.Point(47, 870);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(198, 121);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 53;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.ErrorImage = null;
            this.btnProcesar.Image = global::emvecre.Properties.Resources.Procesar;
            this.btnProcesar.Location = new System.Drawing.Point(1289, 870);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(198, 121);
            this.btnProcesar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProcesar.TabIndex = 52;
            this.btnProcesar.TabStop = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            this.btnProcesar.MouseEnter += new System.EventHandler(this.btnProcesar_MouseEnter);
            this.btnProcesar.MouseLeave += new System.EventHandler(this.btnProcesar_MouseLeave);
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarArticulo.Image = global::emvecre.Properties.Resources.Buscar;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(517, 147);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(40, 30);
            this.btnBuscarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarArticulo.TabIndex = 8;
            this.btnBuscarArticulo.TabStop = false;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            this.btnBuscarArticulo.MouseEnter += new System.EventHandler(this.btnBuscarArticulo_MouseEnter);
            this.btnBuscarArticulo.MouseLeave += new System.EventHandler(this.btnBuscarArticulo_MouseLeave);
            // 
            // btnBuscarVendedor
            // 
            this.btnBuscarVendedor.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscarVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarVendedor.Image = global::emvecre.Properties.Resources.Buscar;
            this.btnBuscarVendedor.Location = new System.Drawing.Point(1168, 66);
            this.btnBuscarVendedor.Name = "btnBuscarVendedor";
            this.btnBuscarVendedor.Size = new System.Drawing.Size(41, 33);
            this.btnBuscarVendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarVendedor.TabIndex = 5;
            this.btnBuscarVendedor.TabStop = false;
            this.btnBuscarVendedor.Click += new System.EventHandler(this.btnBuscarVendedor_Click);
            this.btnBuscarVendedor.MouseEnter += new System.EventHandler(this.btnBuscarVendedor_MouseEnter);
            this.btnBuscarVendedor.MouseLeave += new System.EventHandler(this.btnBuscarVendedor_MouseLeave);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.Image = global::emvecre.Properties.Resources.Buscar;
            this.btnBuscarCliente.Location = new System.Drawing.Point(1168, 13);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(41, 34);
            this.btnBuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.TabStop = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            this.btnBuscarCliente.MouseEnter += new System.EventHandler(this.btnBuscarCliente_MouseEnter);
            this.btnBuscarCliente.MouseLeave += new System.EventHandler(this.btnBuscarCliente_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(99, 994);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 33);
            this.label4.TabIndex = 55;
            this.label4.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(692, 994);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 33);
            this.label1.TabIndex = 56;
            this.label1.Text = "Cancelar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(1328, 994);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 57;
            this.label2.Text = "Procesar";
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1547, 1027);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.btnBuscarVendedor);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturar";
            this.Text = "frmFacturar";
            this.Load += new System.EventHandler(this.frmFacturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcesar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.PictureBox btnBuscarCliente;
        private System.Windows.Forms.PictureBox btnBuscarVendedor;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.PictureBox btnBuscarArticulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.TextBox txtVendedor;
        public System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.PictureBox btnProcesar;
        public System.Windows.Forms.TextBox txtArticulo;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.DataGridView dgvFactura;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}