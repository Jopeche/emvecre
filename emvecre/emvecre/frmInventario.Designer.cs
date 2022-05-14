namespace emvecre
{
    partial class frmInventario
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
            this.PanelControlInventario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnDepartamentos = new System.Windows.Forms.PictureBox();
            this.btnArticulos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControlInventario
            // 
            this.PanelControlInventario.Location = new System.Drawing.Point(2, 132);
            this.PanelControlInventario.Name = "PanelControlInventario";
            this.PanelControlInventario.Size = new System.Drawing.Size(1705, 892);
            this.PanelControlInventario.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(53, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 111;
            this.label2.Text = "Articulos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label3.Location = new System.Drawing.Point(291, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 30);
            this.label3.TabIndex = 112;
            this.label3.Text = "Departamentos";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::emvecre.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(1694, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 21);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 144;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_2);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter_2);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave_1);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartamentos.Image = global::emvecre.Properties.Resources.Departamentos;
            this.btnDepartamentos.Location = new System.Drawing.Point(287, 2);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(193, 94);
            this.btnDepartamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDepartamentos.TabIndex = 9;
            this.btnDepartamentos.TabStop = false;
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            this.btnDepartamentos.MouseEnter += new System.EventHandler(this.btnDepartamentos_MouseEnter);
            this.btnDepartamentos.MouseLeave += new System.EventHandler(this.btnDepartamentos_MouseLeave);
            // 
            // btnArticulos
            // 
            this.btnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulos.Image = global::emvecre.Properties.Resources.Productos;
            this.btnArticulos.Location = new System.Drawing.Point(18, 2);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(193, 94);
            this.btnArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnArticulos.TabIndex = 8;
            this.btnArticulos.TabStop = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnArticulos.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnArticulos.MouseLeave += new System.EventHandler(this.btnArticulos_MouseLeave);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1719, 961);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelControlInventario);
            this.Controls.Add(this.btnDepartamentos);
            this.Controls.Add(this.btnArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnDepartamentos;
        private System.Windows.Forms.PictureBox btnArticulos;
        private System.Windows.Forms.Panel PanelControlInventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}