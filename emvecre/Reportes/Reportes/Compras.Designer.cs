namespace Reportes
{
    partial class Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnExpo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnBuscarProveedor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompras.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCompras.Location = new System.Drawing.Point(1, 166);
            this.dgvCompras.Name = "dgvCompras";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.Size = new System.Drawing.Size(1717, 686);
            this.dgvCompras.TabIndex = 13;
            this.dgvCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellClick);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(148, 58);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(270, 37);
            this.dtpHasta.TabIndex = 12;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Desde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(148, 22);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(270, 37);
            this.dtpDesde.TabIndex = 9;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(148, 111);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(270, 37);
            this.txtProveedor.TabIndex = 16;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Proveedor";
            // 
            // BtnExpo
            // 
            this.BtnExpo.BackColor = System.Drawing.Color.Blue;
            this.BtnExpo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExpo.FlatAppearance.BorderSize = 0;
            this.BtnExpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExpo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpo.ForeColor = System.Drawing.Color.Silver;
            this.BtnExpo.Location = new System.Drawing.Point(1, 858);
            this.BtnExpo.Name = "BtnExpo";
            this.BtnExpo.Size = new System.Drawing.Size(124, 36);
            this.BtnExpo.TabIndex = 135;
            this.BtnExpo.Text = "Exportar";
            this.BtnExpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExpo.UseVisualStyleBackColor = false;
            this.BtnExpo.Click += new System.EventHandler(this.BtnExpo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Reportes.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(1695, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 21);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 142;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProveedor.Image")));
            this.btnBuscarProveedor.Location = new System.Drawing.Point(424, 111);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(42, 37);
            this.btnBuscarProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarProveedor.TabIndex = 136;
            this.btnBuscarProveedor.TabStop = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1719, 1059);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.BtnExpo);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDesde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        public System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnExpo;
        private System.Windows.Forms.PictureBox btnBuscarProveedor;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}