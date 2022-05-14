namespace emvecre
{
    partial class Ingresar_compra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.IMPUESTO = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum_compra = new System.Windows.Forms.TextBox();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnBuscarArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcesar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha_ingreso
            // 
            this.dtpFecha_ingreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_ingreso.CalendarForeColor = System.Drawing.Color.LightBlue;
            this.dtpFecha_ingreso.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.dtpFecha_ingreso.CalendarTitleBackColor = System.Drawing.Color.LightBlue;
            this.dtpFecha_ingreso.CalendarTitleForeColor = System.Drawing.Color.LightBlue;
            this.dtpFecha_ingreso.CalendarTrailingForeColor = System.Drawing.Color.LightBlue;
            this.dtpFecha_ingreso.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_ingreso.Location = new System.Drawing.Point(1023, 38);
            this.dtpFecha_ingreso.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpFecha_ingreso.Name = "dtpFecha_ingreso";
            this.dtpFecha_ingreso.Size = new System.Drawing.Size(246, 34);
            this.dtpFecha_ingreso.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1277, 830);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 30);
            this.label9.TabIndex = 47;
            this.label9.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.LightBlue;
            this.txtTotal.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1282, 864);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(411, 34);
            this.txtTotal.TabIndex = 46;
            this.txtTotal.Text = "0";
            // 
            // IMPUESTO
            // 
            this.IMPUESTO.AutoSize = true;
            this.IMPUESTO.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMPUESTO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IMPUESTO.Location = new System.Drawing.Point(630, 831);
            this.IMPUESTO.Name = "IMPUESTO";
            this.IMPUESTO.Size = new System.Drawing.Size(136, 30);
            this.IMPUESTO.TabIndex = 45;
            this.IMPUESTO.Text = "IMPUESTO";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.BackColor = System.Drawing.Color.LightBlue;
            this.txtImpuesto.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Location = new System.Drawing.Point(635, 863);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(369, 34);
            this.txtImpuesto.TabIndex = 44;
            this.txtImpuesto.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(10, 830);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 30);
            this.label7.TabIndex = 43;
            this.label7.Text = "SUBTOTAL";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.LightBlue;
            this.txtSubtotal.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(12, 863);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(341, 34);
            this.txtSubtotal.TabIndex = 42;
            this.txtSubtotal.Text = "0";
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.Format = "E2";
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompra.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCompra.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCompra.EnableHeadersVisualStyles = false;
            this.dgvCompra.Location = new System.Drawing.Point(3, 152);
            this.dgvCompra.MultiSelect = false;
            this.dgvCompra.Name = "dgvCompra";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = "0";
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCompra.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Navy;
            this.dgvCompra.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCompra.Size = new System.Drawing.Size(1716, 675);
            this.dgvCompra.TabIndex = 41;
            this.dgvCompra.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellEndEdit);
            this.dgvCompra.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCompra_CellPainting_1);
            this.dgvCompra.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellValidated);
            this.dgvCompra.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCompra_EditingControlShowing);
            this.dgvCompra.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCompra_RowsAdded_1);
            this.dgvCompra.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvCompra_RowsRemoved);
            this.dgvCompra.Click += new System.EventHandler(this.dgvCompra_Click);
            this.dgvCompra.Enter += new System.EventHandler(this.dgvCompra_Enter);
            this.dgvCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCompra_KeyDown_1);
            this.dgvCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCompra_KeyPress_1);
            this.dgvCompra.Validated += new System.EventHandler(this.dgvCompra_Validated);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.LightBlue;
            this.txtCantidad.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(1023, 114);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(246, 34);
            this.txtCantidad.TabIndex = 36;
            this.txtCantidad.Text = "1";
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown_1);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersCantidad);
            this.txtCantidad.Validated += new System.EventHandler(this.txtCantidad_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(873, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 30);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cantidad";
            this.label6.UseMnemonic = false;
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.Color.LightBlue;
            this.txtArticulo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulo.Location = new System.Drawing.Point(128, 111);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(153, 34);
            this.txtArticulo.TabIndex = 34;
            this.txtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyDown);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.LightBlue;
            this.txtPrecio.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(460, 114);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(356, 34);
            this.txtPrecio.TabIndex = 33;
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersPrecio);
            this.txtPrecio.Validated += new System.EventHandler(this.txtPrecio_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "Articulo";
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(361, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "Costo";
            this.label5.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1018, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Fecha de ingreso";
            this.label3.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Proveedor";
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(455, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "Numero de comprobante";
            this.label1.UseMnemonic = false;
            // 
            // txtNum_compra
            // 
            this.txtNum_compra.BackColor = System.Drawing.Color.LightBlue;
            this.txtNum_compra.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum_compra.Location = new System.Drawing.Point(460, 38);
            this.txtNum_compra.Name = "txtNum_compra";
            this.txtNum_compra.Size = new System.Drawing.Size(356, 34);
            this.txtNum_compra.TabIndex = 26;
            this.txtNum_compra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_compra_KeyDown);
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.cmbProveedores.BackColor = System.Drawing.Color.SteelBlue;
            this.cmbProveedores.CausesValidation = false;
            this.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedores.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedores.Location = new System.Drawing.Point(12, 41);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(266, 35);
            this.cmbProveedores.Sorted = true;
            this.cmbProveedores.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(40, 1006);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 30);
            this.label8.TabIndex = 109;
            this.label8.Text = "Salir";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1555, 1006);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 30);
            this.label10.TabIndex = 110;
            this.label10.Text = "Procesar";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.White;
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.ErrorImage = null;
            this.btnProcesar.Image = global::emvecre.Properties.Resources.Procesar;
            this.btnProcesar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProcesar.Location = new System.Drawing.Point(1547, 904);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(132, 99);
            this.btnProcesar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProcesar.TabIndex = 55;
            this.btnProcesar.TabStop = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            this.btnProcesar.MouseEnter += new System.EventHandler(this.btnProcesar_MouseEnter);
            this.btnProcesar.MouseLeave += new System.EventHandler(this.btnProcesar_MouseLeave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.ErrorImage = null;
            this.btnCancelar.Image = global::emvecre.Properties.Resources.Regresar;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(12, 904);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 99);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBuscarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarArticulo.Image = global::emvecre.Properties.Resources.Buscar;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(287, 111);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(39, 34);
            this.btnBuscarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarArticulo.TabIndex = 50;
            this.btnBuscarArticulo.TabStop = false;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarVendedor_Click);
            this.btnBuscarArticulo.MouseEnter += new System.EventHandler(this.btnBuscarVendedor_MouseEnter);
            this.btnBuscarArticulo.MouseLeave += new System.EventHandler(this.btnBuscarArticulo_MouseLeave);
            // 
            // Ingresar_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1719, 1059);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.cmbProveedores);
            this.Controls.Add(this.dtpFecha_ingreso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.IMPUESTO);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum_compra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresar_compra";
            this.Text = "Ingresar_compra";
            this.Load += new System.EventHandler(this.Ingresar_compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcesar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha_ingreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label IMPUESTO;
        public System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.DataGridView dgvCompra;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtArticulo;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum_compra;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.PictureBox btnBuscarArticulo;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnProcesar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}