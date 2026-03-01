namespace emvecre
{
    partial class frmMenuFacturacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOperaciones = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCierreCaja = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnDevolucion = new System.Windows.Forms.PictureBox();
            this.btnReimprimir = new System.Windows.Forms.PictureBox();
            this.btnFacturar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCierreCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDevolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReimprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFacturar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOperaciones
            // 
            this.panelOperaciones.BackColor = System.Drawing.Color.SteelBlue;
            this.panelOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOperaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelOperaciones.Location = new System.Drawing.Point(203, 0);
            this.panelOperaciones.Name = "panelOperaciones";
            this.panelOperaciones.Size = new System.Drawing.Size(1547, 1022);
            this.panelOperaciones.TabIndex = 3;
            this.panelOperaciones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOperaciones_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(55, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Facturar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(55, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Imprimir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label3.Location = new System.Drawing.Point(38, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Devolucion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label4.Location = new System.Drawing.Point(71, 995);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Salir";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCierreCaja);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnDevolucion);
            this.panel1.Controls.Add(this.btnReimprimir);
            this.panel1.Controls.Add(this.btnFacturar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 1027);
            this.panel1.TabIndex = 0;
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCierreCaja.ErrorImage = null;
            this.btnCierreCaja.Image = global::emvecre.Properties.Resources.CierreCaja;
            this.btnCierreCaja.Location = new System.Drawing.Point(3, 569);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(198, 121);
            this.btnCierreCaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCierreCaja.TabIndex = 20;
            this.btnCierreCaja.TabStop = false;
            this.btnCierreCaja.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btnCierreCaja.MouseEnter += new System.EventHandler(this.btnCierreCaja_MouseEnter);
            this.btnCierreCaja.MouseLeave += new System.EventHandler(this.btnCierreCaja_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(23, 693);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cierre De Caja";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ErrorImage = null;
            this.btnSalir.Image = global::emvecre.Properties.Resources.Regresar;
            this.btnSalir.Location = new System.Drawing.Point(-1, 871);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(198, 121);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolucion.ErrorImage = null;
            this.btnDevolucion.Image = global::emvecre.Properties.Resources.Devolucion;
            this.btnDevolucion.Location = new System.Drawing.Point(3, 368);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(198, 121);
            this.btnDevolucion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDevolucion.TabIndex = 5;
            this.btnDevolucion.TabStop = false;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            this.btnDevolucion.MouseEnter += new System.EventHandler(this.btnDevolucion_MouseEnter);
            this.btnDevolucion.MouseLeave += new System.EventHandler(this.btnDevolucion_MouseLeave);
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReimprimir.ErrorImage = null;
            this.btnReimprimir.Image = global::emvecre.Properties.Resources.Reimprimir;
            this.btnReimprimir.Location = new System.Drawing.Point(3, 187);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(198, 121);
            this.btnReimprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReimprimir.TabIndex = 4;
            this.btnReimprimir.TabStop = false;
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
            this.btnReimprimir.MouseEnter += new System.EventHandler(this.btnReimprimir_MouseEnter);
            this.btnReimprimir.MouseLeave += new System.EventHandler(this.btnReimprimir_MouseLeave);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.ErrorImage = null;
            this.btnFacturar.Image = global::emvecre.Properties.Resources.Facturar;
            this.btnFacturar.Location = new System.Drawing.Point(3, 3);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(198, 121);
            this.btnFacturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFacturar.TabIndex = 3;
            this.btnFacturar.TabStop = false;
            this.btnFacturar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFacturar_MouseClick);
            this.btnFacturar.MouseEnter += new System.EventHandler(this.btnFacturar_MouseEnter);
            this.btnFacturar.MouseLeave += new System.EventHandler(this.btnFacturar_MouseLeave);
            // 
            // frmMenuFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1750, 1027);
            this.Controls.Add(this.panelOperaciones);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCierreCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDevolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReimprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFacturar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelOperaciones;
        private System.Windows.Forms.PictureBox btnFacturar;
        private System.Windows.Forms.PictureBox btnReimprimir;
        private System.Windows.Forms.PictureBox btnDevolucion;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnCierreCaja;
    }
}

