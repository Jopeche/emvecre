namespace emvecre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.txtBuscarVendedor = new System.Windows.Forms.TextBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.ErrorImage = null;
            this.btnAceptar.Image = global::emvecre.Properties.Resources.Aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(681, 474);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 88);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseEnter += new System.EventHandler(this.btnAceptar_MouseEnter);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendedores.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue;
            this.dgvVendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendedores.Location = new System.Drawing.Point(12, 79);
            this.dgvVendedores.MultiSelect = false;
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVendedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVendedores.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy;
            this.dgvVendedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendedores.Size = new System.Drawing.Size(815, 374);
            this.dgvVendedores.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ErrorImage = null;
            this.btnSalir.Image = global::emvecre.Properties.Resources.Regresar;
            this.btnSalir.Location = new System.Drawing.Point(34, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 88);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 16;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // txtBuscarVendedor
            // 
            this.txtBuscarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarVendedor.Location = new System.Drawing.Point(12, 47);
            this.txtBuscarVendedor.Name = "txtBuscarVendedor";
            this.txtBuscarVendedor.Size = new System.Drawing.Size(815, 26);
            this.txtBuscarVendedor.TabIndex = 15;
            this.txtBuscarVendedor.TextChanged += new System.EventHandler(this.txtBuscarVendedor_TextChanged);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblClientes.Location = new System.Drawing.Point(258, 13);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(305, 31);
            this.lblClientes.TabIndex = 14;
            this.lblClientes.Text = "BUSCAR VENDEDOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(54, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Salir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(660, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Seleccionar";
            // 
            // frmBuscarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(839, 605);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvVendedores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtBuscarVendedor);
            this.Controls.Add(this.lblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarVendedor";
            this.Load += new System.EventHandler(this.frmBuscarVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAceptar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.TextBox txtBuscarVendedor;
        private System.Windows.Forms.Label lblClientes;
        public System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}