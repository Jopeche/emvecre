namespace emvecre
{
    partial class frmCierreCaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.cvCierreCaja = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIERRE DE CAJA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reporte Tarjetas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reporte Efectivo";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(193, 106);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(158, 20);
            this.txtTarjeta.TabIndex = 3;
            this.txtTarjeta.Text = "0";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(193, 68);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(158, 20);
            this.txtEfectivo.TabIndex = 4;
            this.txtEfectivo.Text = "0";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::emvecre.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(16, 198);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 50);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::emvecre.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(251, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 50);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cvCierreCaja
            // 
            this.cvCierreCaja.ActiveViewIndex = -1;
            this.cvCierreCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cvCierreCaja.Cursor = System.Windows.Forms.Cursors.Default;
            this.cvCierreCaja.Location = new System.Drawing.Point(409, 9);
            this.cvCierreCaja.Name = "cvCierreCaja";
            this.cvCierreCaja.Size = new System.Drawing.Size(817, 771);
            this.cvCierreCaja.TabIndex = 10;
            // 
            // frmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 792);
            this.Controls.Add(this.cvCierreCaja);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCierreCaja";
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cvCierreCaja;
    }
}