namespace Reportes
{
    partial class frmBuscarVendedor
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
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.AllowUserToAddRows = false;
            this.dgvVendedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Location = new System.Drawing.Point(12, 91);
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.ReadOnly = true;
            this.dgvVendedor.RowHeadersVisible = false;
            this.dgvVendedor.RowHeadersWidth = 500;
            this.dgvVendedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvVendedor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendedor.Size = new System.Drawing.Size(773, 308);
            this.dgvVendedor.TabIndex = 12;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(9, 53);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(776, 20);
            this.txtVendedor.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(284, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar Vendedor";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Reportes.Properties.Resources.equis1;
            this.btnClose.Location = new System.Drawing.Point(748, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 146;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(10, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 149;
            this.label2.Text = "Selecionar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.ErrorImage = null;
            this.btnAceptar.Image = global::Reportes.Properties.Resources.Aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(25, 414);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 78);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAceptar.TabIndex = 148;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseEnter += new System.EventHandler(this.btnAceptar_MouseEnter);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            // 
            // frmBuscarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVendedor);
            this.Controls.Add(this.txtVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarVendedor";
            this.Load += new System.EventHandler(this.frmBuscarVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvVendedor;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnAceptar;
    }
}