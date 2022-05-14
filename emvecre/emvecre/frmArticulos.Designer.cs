namespace emvecre
{
    partial class frmArticulos
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
            this.BtnExpo = new System.Windows.Forms.Button();
            this.cmbDep = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtimpuesto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.Txtcodigo2 = new System.Windows.Forms.TextBox();
            this.Txtcodigo1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.btnCacelar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCacelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExpo
            // 
            this.BtnExpo.BackColor = System.Drawing.Color.Blue;
            this.BtnExpo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExpo.FlatAppearance.BorderSize = 0;
            this.BtnExpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExpo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpo.ForeColor = System.Drawing.Color.Silver;
            this.BtnExpo.Location = new System.Drawing.Point(525, 709);
            this.BtnExpo.Name = "BtnExpo";
            this.BtnExpo.Size = new System.Drawing.Size(124, 36);
            this.BtnExpo.TabIndex = 106;
            this.BtnExpo.Text = "Exportar";
            this.BtnExpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExpo.UseVisualStyleBackColor = false;
            this.BtnExpo.Click += new System.EventHandler(this.BtnExpo_Click);
            // 
            // cmbDep
            // 
            this.cmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDep.ItemHeight = 19;
            this.cmbDep.Location = new System.Drawing.Point(194, 312);
            this.cmbDep.Name = "cmbDep";
            this.cmbDep.Size = new System.Drawing.Size(325, 27);
            this.cmbDep.TabIndex = 105;
            this.cmbDep.SelectedIndexChanged += new System.EventHandler(this.cmbDep_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 30);
            this.label5.TabIndex = 104;
            this.label5.Text = "Departamento";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtimpuesto
            // 
            this.txtimpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtimpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtimpuesto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimpuesto.ForeColor = System.Drawing.Color.White;
            this.txtimpuesto.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.txtimpuesto.Location = new System.Drawing.Point(194, 357);
            this.txtimpuesto.Name = "txtimpuesto";
            this.txtimpuesto.Size = new System.Drawing.Size(325, 27);
            this.txtimpuesto.TabIndex = 103;
            this.txtimpuesto.SelectedIndexChanged += new System.EventHandler(this.txtimpuesto_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 30);
            this.label10.TabIndex = 102;
            this.label10.Text = "Nombre: ";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtnombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.Location = new System.Drawing.Point(194, 134);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(325, 26);
            this.txtnombre.TabIndex = 101;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeight = 30;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvArticulos.Location = new System.Drawing.Point(525, 64);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1190, 639);
            this.dgvArticulos.TabIndex = 100;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridArticulos_CellContentClick);
            this.dgvArticulos.Validating += new System.ComponentModel.CancelEventHandler(this.dgvArticulos_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(749, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 30);
            this.label9.TabIndex = 99;
            this.label9.Text = "Buscar: ";
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.Txtbuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbuscar.ForeColor = System.Drawing.Color.White;
            this.Txtbuscar.Location = new System.Drawing.Point(863, 35);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.Size = new System.Drawing.Size(542, 26);
            this.Txtbuscar.TabIndex = 98;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            this.Txtbuscar.Validating += new System.ComponentModel.CancelEventHandler(this.Txtbuscar_Validating);
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtprecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.ForeColor = System.Drawing.Color.White;
            this.txtprecio.Location = new System.Drawing.Point(194, 246);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(325, 26);
            this.txtprecio.TabIndex = 97;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtcosto
            // 
            this.txtcosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtcosto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto.ForeColor = System.Drawing.Color.White;
            this.txtcosto.Location = new System.Drawing.Point(194, 208);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(325, 26);
            this.txtcosto.TabIndex = 96;
            this.txtcosto.TextChanged += new System.EventHandler(this.txtcosto_TextChanged);
            this.txtcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcosto_KeyPress);
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtstock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.ForeColor = System.Drawing.Color.White;
            this.txtstock.Location = new System.Drawing.Point(194, 171);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(325, 26);
            this.txtstock.TabIndex = 95;
            this.txtstock.TextChanged += new System.EventHandler(this.txtstock_TextChanged);
            this.txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersStock);
            // 
            // Txtcodigo2
            // 
            this.Txtcodigo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.Txtcodigo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcodigo2.ForeColor = System.Drawing.Color.White;
            this.Txtcodigo2.Location = new System.Drawing.Point(194, 100);
            this.Txtcodigo2.Name = "Txtcodigo2";
            this.Txtcodigo2.Size = new System.Drawing.Size(325, 26);
            this.Txtcodigo2.TabIndex = 94;
            this.Txtcodigo2.TextChanged += new System.EventHandler(this.Txtcodigo2_TextChanged);
            // 
            // Txtcodigo1
            // 
            this.Txtcodigo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.Txtcodigo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcodigo1.ForeColor = System.Drawing.Color.White;
            this.Txtcodigo1.Location = new System.Drawing.Point(194, 64);
            this.Txtcodigo1.Name = "Txtcodigo1";
            this.Txtcodigo1.Size = new System.Drawing.Size(325, 26);
            this.Txtcodigo1.TabIndex = 93;
            this.Txtcodigo1.TextChanged += new System.EventHandler(this.Txtcodigo1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 30);
            this.label8.TabIndex = 91;
            this.label8.Text = "Impuesto: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.TabIndex = 90;
            this.label7.Text = "Precio: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 30);
            this.label6.TabIndex = 89;
            this.label6.Text = "Costo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 30);
            this.label4.TabIndex = 88;
            this.label4.Text = "Existencias: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 87;
            this.label3.Text = "Codigo 2: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 86;
            this.label2.Text = "Codigo1: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(999, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(238, 23);
            this.label11.TabIndex = 107;
            this.label11.Text = "ARTICULOS";
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Image = global::emvecre.Properties.Resources.Modificar;
            this.btnModificar.Location = new System.Drawing.Point(1415, 751);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 99);
            this.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnModificar.TabIndex = 10;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.MouseEnter += new System.EventHandler(this.btnModificar_MouseEnter);
            this.btnModificar.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::emvecre.Properties.Resources.Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(1182, 751);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 99);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseEnter += new System.EventHandler(this.btnEliminar_MouseEnter);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::emvecre.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(959, 751);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 99);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseEnter += new System.EventHandler(this.btnGuadar_MouseEnter);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            // 
            // btnCacelar
            // 
            this.btnCacelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCacelar.Image = global::emvecre.Properties.Resources.Cancelar;
            this.btnCacelar.Location = new System.Drawing.Point(730, 751);
            this.btnCacelar.Name = "btnCacelar";
            this.btnCacelar.Size = new System.Drawing.Size(132, 99);
            this.btnCacelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCacelar.TabIndex = 7;
            this.btnCacelar.TabStop = false;
            this.btnCacelar.Click += new System.EventHandler(this.btnCacelar_Click);
            this.btnCacelar.MouseEnter += new System.EventHandler(this.btnCacelar_MouseEnter);
            this.btnCacelar.MouseLeave += new System.EventHandler(this.btnCacelar_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::emvecre.Properties.Resources.Regresar;
            this.btnSalir.Location = new System.Drawing.Point(525, 751);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 99);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 6;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(550, 853);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 108;
            this.label1.Text = "Salir";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label12.Location = new System.Drawing.Point(729, 853);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 33);
            this.label12.TabIndex = 109;
            this.label12.Text = "Cancelar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label13.Location = new System.Drawing.Point(969, 853);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 33);
            this.label13.TabIndex = 110;
            this.label13.Text = "Guardar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label14.Location = new System.Drawing.Point(1191, 853);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 33);
            this.label14.TabIndex = 111;
            this.label14.Text = "Eliminar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label15.Location = new System.Drawing.Point(1409, 853);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 33);
            this.label15.TabIndex = 112;
            this.label15.Text = "Modificar";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1705, 907);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnExpo);
            this.Controls.Add(this.cmbDep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtimpuesto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txtbuscar);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.Txtcodigo2);
            this.Controls.Add(this.Txtcodigo1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCacelar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArticulos";
            this.Text = "frmArticulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCacelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnModificar;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.PictureBox btnCacelar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Button BtnExpo;
        public System.Windows.Forms.ComboBox cmbDep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtimpuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txtbuscar;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox Txtcodigo2;
        private System.Windows.Forms.TextBox Txtcodigo1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}