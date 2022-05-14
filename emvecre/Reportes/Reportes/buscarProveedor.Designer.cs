namespace Reportes
{
    partial class buscarProveedor
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
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(9, 106);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowHeadersWidth = 500;
            this.dgvProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(779, 312);
            this.dgvProveedores.TabIndex = 6;
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.White;
            this.txtProveedor.Location = new System.Drawing.Point(9, 62);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(779, 20);
            this.txtProveedor.TabIndex = 5;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(288, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar Proveedor";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Reportes.Properties.Resources.equis1;
            this.btnClose.Location = new System.Drawing.Point(747, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 146;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.ErrorImage = null;
            this.btnAceptar.Image = global::Reportes.Properties.Resources.Aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(25, 433);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 78);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAceptar.TabIndex = 147;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseEnter += new System.EventHandler(this.btnAceptar_MouseEnter);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(9, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 148;
            this.label1.Text = "Selecionar";
            // 
            // buscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.txtProveedor);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "buscarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buscarProveedor";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.buscarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnAceptar;
        private System.Windows.Forms.Label label1;
    }
}