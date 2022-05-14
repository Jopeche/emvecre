namespace emvecre
{
    partial class frmProcesarFactura
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
            this.lblCambio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnFacturar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFacturar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblCambio.Location = new System.Drawing.Point(169, 134);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(27, 30);
            this.lblCambio.TabIndex = 15;
            this.lblCambio.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(30, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "CAMBIO:";
            // 
            // txtPaga
            // 
            this.txtPaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtPaga.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaga.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPaga.Location = new System.Drawing.Point(174, 38);
            this.txtPaga.Name = "txtPaga";
            this.txtPaga.Size = new System.Drawing.Size(327, 26);
            this.txtPaga.TabIndex = 11;
            this.txtPaga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaga_KeyDown);
            this.txtPaga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersCantidad);
            this.txtPaga.Leave += new System.EventHandler(this.txtPaga_Leave);
            this.txtPaga.Validating += new System.ComponentModel.CancelEventHandler(this.txtPaga_Validating);
            this.txtPaga.Validated += new System.EventHandler(this.txtPaga_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(30, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Paga con:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lblTotal.Location = new System.Drawing.Point(169, 99);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 30);
            this.lblTotal.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(30, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "TOTAL:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::emvecre.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(5, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 113);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = global::emvecre.Properties.Resources.Procesar;
            this.btnFacturar.Location = new System.Drawing.Point(471, 380);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(158, 113);
            this.btnFacturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFacturar.TabIndex = 17;
            this.btnFacturar.TabStop = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click_1);
            this.btnFacturar.MouseEnter += new System.EventHandler(this.btnFacturar_MouseEnter);
            this.btnFacturar.MouseLeave += new System.EventHandler(this.btnFacturar_MouseLeave);
            this.btnFacturar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnFacturar_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(12, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "CANCELAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(482, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "PROCESAR";
            // 
            // frmProcesarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(634, 578);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPaga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProcesarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProcesarFactura";
            this.Load += new System.EventHandler(this.frmProcesarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFacturar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCancelar;
        public System.Windows.Forms.TextBox txtPaga;
        private System.Windows.Forms.PictureBox btnFacturar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}