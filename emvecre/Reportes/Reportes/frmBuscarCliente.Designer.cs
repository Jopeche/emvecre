namespace Reportes
{
    partial class frmBuscarCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(293, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar Cliente";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 88);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 500;
            this.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(776, 309);
            this.dgvCliente.TabIndex = 11;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(12, 62);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(776, 20);
            this.txtCliente.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(12, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 147;
            this.label2.Text = "Selecionar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.ErrorImage = null;
            this.btnAceptar.Image = global::Reportes.Properties.Resources.Aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(27, 403);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 78);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAceptar.TabIndex = 146;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseEnter += new System.EventHandler(this.btnAceptar_MouseEnter);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Reportes.Properties.Resources.equis1;
            this.btnClose.Location = new System.Drawing.Point(747, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 145;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarCliente";
            this.Load += new System.EventHandler(this.frmBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnAceptar;
        private System.Windows.Forms.Label label2;
    }
}