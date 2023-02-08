namespace Metodos_Propiedades
{
    partial class FrmLineas
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.btnDibujarLinea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cxbXinicial = new System.Windows.Forms.ComboBox();
            this.cxbXFinal = new System.Windows.Forms.ComboBox();
            this.cxbYInicial = new System.Windows.Forms.ComboBox();
            this.cxbYFinal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(236, 133);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(98, 13);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "Cantidad de Lineas";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(265, 149);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(48, 20);
            this.txtCantidad.TabIndex = 13;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(144, 31);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(43, 13);
            this.lblY.TabIndex = 12;
            this.lblY.Text = "Y inicial";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(23, 31);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(43, 13);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "X inicial";
            // 
            // btnDibujarLinea
            // 
            this.btnDibujarLinea.Location = new System.Drawing.Point(51, 149);
            this.btnDibujarLinea.Name = "btnDibujarLinea";
            this.btnDibujarLinea.Size = new System.Drawing.Size(109, 23);
            this.btnDibujarLinea.TabIndex = 10;
            this.btnDibujarLinea.Text = "Dibujar Linea";
            this.btnDibujarLinea.UseVisualStyleBackColor = true;
            this.btnDibujarLinea.Click += new System.EventHandler(this.btnDibujarLinea_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "X final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Y final";
            // 
            // cxbXinicial
            // 
            this.cxbXinicial.FormattingEnabled = true;
            this.cxbXinicial.Location = new System.Drawing.Point(72, 28);
            this.cxbXinicial.Name = "cxbXinicial";
            this.cxbXinicial.Size = new System.Drawing.Size(53, 21);
            this.cxbXinicial.TabIndex = 21;
            // 
            // cxbXFinal
            // 
            this.cxbXFinal.FormattingEnabled = true;
            this.cxbXFinal.Location = new System.Drawing.Point(72, 73);
            this.cxbXFinal.Name = "cxbXFinal";
            this.cxbXFinal.Size = new System.Drawing.Size(53, 21);
            this.cxbXFinal.TabIndex = 22;
            // 
            // cxbYInicial
            // 
            this.cxbYInicial.FormattingEnabled = true;
            this.cxbYInicial.Location = new System.Drawing.Point(209, 28);
            this.cxbYInicial.Name = "cxbYInicial";
            this.cxbYInicial.Size = new System.Drawing.Size(53, 21);
            this.cxbYInicial.TabIndex = 23;
            // 
            // cxbYFinal
            // 
            this.cxbYFinal.FormattingEnabled = true;
            this.cxbYFinal.Location = new System.Drawing.Point(209, 74);
            this.cxbYFinal.Name = "cxbYFinal";
            this.cxbYFinal.Size = new System.Drawing.Size(53, 21);
            this.cxbYFinal.TabIndex = 24;
            // 
            // FrmLineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 494);
            this.Controls.Add(this.cxbYFinal);
            this.Controls.Add(this.cxbYInicial);
            this.Controls.Add(this.cxbXFinal);
            this.Controls.Add(this.cxbXinicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnDibujarLinea);
            this.Name = "FrmLineas";
            this.Text = "Dibujar Lineas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnDibujarLinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cxbXinicial;
        private System.Windows.Forms.ComboBox cxbXFinal;
        private System.Windows.Forms.ComboBox cxbYInicial;
        private System.Windows.Forms.ComboBox cxbYFinal;
    }
}

