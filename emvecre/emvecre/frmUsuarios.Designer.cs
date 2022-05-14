namespace emvecre
{
    partial class frmUsuarios
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
            this.label11 = new System.Windows.Forms.Label();
            this.BtnExpo = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.btnCacelar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCacelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(982, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 23);
            this.label11.TabIndex = 161;
            this.label11.Text = "USUARIOS";
            // 
            // BtnExpo
            // 
            this.BtnExpo.BackColor = System.Drawing.Color.Blue;
            this.BtnExpo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExpo.FlatAppearance.BorderSize = 0;
            this.BtnExpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExpo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpo.ForeColor = System.Drawing.Color.Silver;
            this.BtnExpo.Location = new System.Drawing.Point(512, 720);
            this.BtnExpo.Name = "BtnExpo";
            this.BtnExpo.Size = new System.Drawing.Size(124, 36);
            this.BtnExpo.TabIndex = 160;
            this.BtnExpo.Text = "Exportar";
            this.BtnExpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExpo.UseVisualStyleBackColor = false;
            this.BtnExpo.Click += new System.EventHandler(this.BtnExpo_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeight = 30;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvUsuarios.Location = new System.Drawing.Point(512, 75);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1190, 639);
            this.dgvUsuarios.TabIndex = 159;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(738, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 30);
            this.label9.TabIndex = 158;
            this.label9.Text = "Buscar: ";
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.Txtbuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbuscar.ForeColor = System.Drawing.Color.White;
            this.Txtbuscar.Location = new System.Drawing.Point(862, 47);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.Size = new System.Drawing.Size(533, 26);
            this.Txtbuscar.TabIndex = 157;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(221, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(285, 26);
            this.txtNombre.TabIndex = 156;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(221, 75);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(285, 26);
            this.txtId.TabIndex = 155;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 30);
            this.label3.TabIndex = 154;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 153;
            this.label2.Text = "ID USUARIO";
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Image = global::emvecre.Properties.Resources.Modificar;
            this.btnModificar.Location = new System.Drawing.Point(1385, 763);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 99);
            this.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnModificar.TabIndex = 152;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.MouseEnter += new System.EventHandler(this.btnModificar_MouseEnter);
            this.btnModificar.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::emvecre.Properties.Resources.Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(1169, 763);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 99);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminar.TabIndex = 151;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseEnter += new System.EventHandler(this.btnEliminar_MouseEnter);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::emvecre.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(948, 763);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 99);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGuardar.TabIndex = 150;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseEnter += new System.EventHandler(this.btnGuadar_MouseEnter);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            // 
            // btnCacelar
            // 
            this.btnCacelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCacelar.Image = global::emvecre.Properties.Resources.Cancelar;
            this.btnCacelar.Location = new System.Drawing.Point(714, 763);
            this.btnCacelar.Name = "btnCacelar";
            this.btnCacelar.Size = new System.Drawing.Size(132, 99);
            this.btnCacelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCacelar.TabIndex = 149;
            this.btnCacelar.TabStop = false;
            this.btnCacelar.Click += new System.EventHandler(this.btnCacelar_Click);
            this.btnCacelar.MouseEnter += new System.EventHandler(this.btnCacelar_MouseEnter);
            this.btnCacelar.MouseLeave += new System.EventHandler(this.btnCacelar_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::emvecre.Properties.Resources.Regresar;
            this.btnSalir.Location = new System.Drawing.Point(511, 763);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 99);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 148;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtContrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.White;
            this.txtContrasena.Location = new System.Drawing.Point(221, 151);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(285, 26);
            this.txtContrasena.TabIndex = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 30);
            this.label1.TabIndex = 162;
            this.label1.Text = "CONTRASEÑA";
            // 
            // txtAdmin
            // 
            this.txtAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAdmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin.ForeColor = System.Drawing.Color.White;
            this.txtAdmin.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.txtAdmin.Location = new System.Drawing.Point(397, 189);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(109, 27);
            this.txtAdmin.TabIndex = 165;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 30);
            this.label8.TabIndex = 164;
            this.label8.Text = "ADMINISTRADOR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label15.Location = new System.Drawing.Point(1379, 865);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 33);
            this.label15.TabIndex = 170;
            this.label15.Text = "Modificar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label14.Location = new System.Drawing.Point(1178, 865);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 33);
            this.label14.TabIndex = 169;
            this.label14.Text = "Eliminar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label13.Location = new System.Drawing.Point(958, 865);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 33);
            this.label13.TabIndex = 168;
            this.label13.Text = "Guardar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label12.Location = new System.Drawing.Point(713, 865);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 33);
            this.label12.TabIndex = 167;
            this.label12.Text = "Cancelar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label4.Location = new System.Drawing.Point(533, 865);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 33);
            this.label4.TabIndex = 166;
            this.label4.Text = "Salir";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1705, 907);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnExpo);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txtbuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCacelar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCacelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnExpo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txtbuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnModificar;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.PictureBox btnCacelar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtAdmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
    }
}