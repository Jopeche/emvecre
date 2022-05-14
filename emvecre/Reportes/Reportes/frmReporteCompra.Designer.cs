namespace Reportes
{
    partial class frmReporteCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCompra));
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblFecha.Location = new System.Drawing.Point(232, 107);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 23);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "label6";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblProveedor.Location = new System.Drawing.Point(232, 67);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(64, 23);
            this.lblProveedor.TabIndex = 14;
            this.lblProveedor.Text = "label5";
            // 
            // lblComprobante
            // 
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblComprobante.Location = new System.Drawing.Point(232, 26);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(64, 23);
            this.lblComprobante.TabIndex = 13;
            this.lblComprobante.Text = "label4";
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompra.Enabled = false;
            this.dgvCompra.Location = new System.Drawing.Point(0, 180);
            this.dgvCompra.Name = "dgvCompra";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompra.RowHeadersVisible = false;
            this.dgvCompra.Size = new System.Drawing.Size(800, 309);
            this.dgvCompra.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "FECHA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "PROVEEDOR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "COMPROBANTE:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblTotal.Location = new System.Drawing.Point(232, 146);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 23);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(21, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "TOTAL:";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(747, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 18;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label14.Location = new System.Drawing.Point(2, 612);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 23);
            this.label14.TabIndex = 141;
            this.label14.Text = "Eliminar Compra";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(12, 507);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 99);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminar.TabIndex = 140;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btnEliminar.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            // 
            // frmReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblComprobante);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReporteCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label lblProveedor;
        public System.Windows.Forms.Label lblComprobante;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox btnEliminar;
    }
}