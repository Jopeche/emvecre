namespace Reportes
{
    partial class frmVentasDepartamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.BtnExpo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(524, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "VENTAS POR DEPARTAMENTO";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Enabled = false;
            this.dgvVentas.Location = new System.Drawing.Point(0, 222);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.Size = new System.Drawing.Size(1516, 551);
            this.dgvVentas.TabIndex = 16;
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamentos.Location = new System.Drawing.Point(317, 161);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(209, 38);
            this.cmbDepartamentos.TabIndex = 19;
            this.cmbDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamentos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "DEPARTAMENTO";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(317, 109);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(209, 37);
            this.dtpHasta.TabIndex = 24;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "HASTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(14, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "DESDE";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(317, 66);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(209, 37);
            this.dtpDesde.TabIndex = 21;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // BtnExpo
            // 
            this.BtnExpo.BackColor = System.Drawing.Color.Blue;
            this.BtnExpo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExpo.FlatAppearance.BorderSize = 0;
            this.BtnExpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExpo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpo.ForeColor = System.Drawing.Color.Silver;
            this.BtnExpo.Location = new System.Drawing.Point(0, 779);
            this.BtnExpo.Name = "BtnExpo";
            this.BtnExpo.Size = new System.Drawing.Size(124, 36);
            this.BtnExpo.TabIndex = 134;
            this.BtnExpo.Text = "Exportar";
            this.BtnExpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExpo.UseVisualStyleBackColor = false;
            this.BtnExpo.Click += new System.EventHandler(this.BtnExpo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Reportes.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(1493, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 21);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 144;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmVentasDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1517, 1056);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnExpo);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDepartamentos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentasDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentasDepartamento";
            this.Load += new System.EventHandler(this.frmVentasDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button BtnExpo;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}