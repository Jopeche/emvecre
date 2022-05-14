namespace Reportes
{
    partial class FrmMenuReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuReporte));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRepDepart = new System.Windows.Forms.PictureBox();
            this.btnRepVenta = new System.Windows.Forms.PictureBox();
            this.panelOperaciones = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRepDepart);
            this.panel1.Controls.Add(this.btnRepVenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 1059);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label8.Location = new System.Drawing.Point(59, 993);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 30);
            this.label8.TabIndex = 139;
            this.label8.Text = "Salir";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.ErrorImage = null;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(2, 869);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(198, 121);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelar.TabIndex = 138;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(-3, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 62);
            this.label2.TabIndex = 16;
            this.label2.Text = "         Ventas          Departamento ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(52, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ventas";
            // 
            // btnRepDepart
            // 
            this.btnRepDepart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepDepart.ErrorImage = null;
            this.btnRepDepart.Image = ((System.Drawing.Image)(resources.GetObject("btnRepDepart.Image")));
            this.btnRepDepart.Location = new System.Drawing.Point(3, 187);
            this.btnRepDepart.Name = "btnRepDepart";
            this.btnRepDepart.Size = new System.Drawing.Size(198, 121);
            this.btnRepDepart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRepDepart.TabIndex = 4;
            this.btnRepDepart.TabStop = false;
            this.btnRepDepart.Click += new System.EventHandler(this.btnReimprimir_Click);
            this.btnRepDepart.MouseEnter += new System.EventHandler(this.btnReimprimir_MouseEnter);
            this.btnRepDepart.MouseLeave += new System.EventHandler(this.btnRepDepart_MouseLeave);
            // 
            // btnRepVenta
            // 
            this.btnRepVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepVenta.ErrorImage = null;
            this.btnRepVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnRepVenta.Image")));
            this.btnRepVenta.Location = new System.Drawing.Point(3, 3);
            this.btnRepVenta.Name = "btnRepVenta";
            this.btnRepVenta.Size = new System.Drawing.Size(198, 121);
            this.btnRepVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRepVenta.TabIndex = 3;
            this.btnRepVenta.TabStop = false;
            this.btnRepVenta.Click += new System.EventHandler(this.btnFacturar_Click);
            this.btnRepVenta.MouseEnter += new System.EventHandler(this.btnFacturar_MouseEnter);
            this.btnRepVenta.MouseLeave += new System.EventHandler(this.btnRepVenta_MouseLeave);
            // 
            // panelOperaciones
            // 
            this.panelOperaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelOperaciones.Location = new System.Drawing.Point(201, 0);
            this.panelOperaciones.Name = "panelOperaciones";
            this.panelOperaciones.Size = new System.Drawing.Size(1518, 1059);
            this.panelOperaciones.TabIndex = 4;
            // 
            // FrmMenuReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 1059);
            this.Controls.Add(this.panelOperaciones);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuReporte";
            this.Text = "FrmMenuReporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRepDepart;
        private System.Windows.Forms.PictureBox btnRepVenta;
        private System.Windows.Forms.Panel panelOperaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnCancelar;
    }
}