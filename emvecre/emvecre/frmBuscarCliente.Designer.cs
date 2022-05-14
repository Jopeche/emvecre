namespace emvecre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(105, 43);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(646, 26);
            this.txtBuscarCliente.TabIndex = 3;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblClientes.Location = new System.Drawing.Point(276, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(265, 31);
            this.lblClientes.TabIndex = 2;
            this.lblClientes.Text = "BUSCAR CLIENTE";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ErrorImage = null;
            this.btnSalir.Image = global::emvecre.Properties.Resources.Regresar;
            this.btnSalir.Location = new System.Drawing.Point(10, 483);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 78);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 8;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.Location = new System.Drawing.Point(10, 75);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Navy;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(827, 363);
            this.dgvClientes.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.ErrorImage = null;
            this.btnAceptar.Image = global::emvecre.Properties.Resources.Aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(691, 483);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 78);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseEnter += new System.EventHandler(this.btnAceptar_MouseEnter);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Salir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(672, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selecionar";
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(839, 605);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.lblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarCliente";
            this.Load += new System.EventHandler(this.frmBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.PictureBox btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}