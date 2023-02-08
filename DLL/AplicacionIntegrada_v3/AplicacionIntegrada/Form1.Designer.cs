
namespace AplicacionIntegrada
{
    partial class frmArregloMatriz
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
            this.lblColumnas = new System.Windows.Forms.Label();
            this.lblFilas = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblMAleatoria = new System.Windows.Forms.Label();
            this.lblEnunciado1 = new System.Windows.Forms.Label();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.lblPunto4 = new System.Windows.Forms.Label();
            this.lblPunto3 = new System.Windows.Forms.Label();
            this.lblPunto2 = new System.Windows.Forms.Label();
            this.lblPunto1 = new System.Windows.Forms.Label();
            this.lblEnunciado2 = new System.Windows.Forms.Label();
            this.btnPunto4 = new System.Windows.Forms.Button();
            this.btnPunto3 = new System.Windows.Forms.Button();
            this.btnPunto2 = new System.Windows.Forms.Button();
            this.btnPunto1 = new System.Windows.Forms.Button();
            this.lblNota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Location = new System.Drawing.Point(271, 43);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(74, 13);
            this.lblColumnas.TabIndex = 32;
            this.lblColumnas.Text = "Elija columnas";
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(167, 43);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(47, 13);
            this.lblFilas.TabIndex = 31;
            this.lblFilas.Text = "Elija filas";
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(274, 68);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(60, 20);
            this.txtColumnas.TabIndex = 37;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(382, 65);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 36;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblMAleatoria
            // 
            this.lblMAleatoria.AutoSize = true;
            this.lblMAleatoria.Location = new System.Drawing.Point(206, 132);
            this.lblMAleatoria.Name = "lblMAleatoria";
            this.lblMAleatoria.Size = new System.Drawing.Size(13, 13);
            this.lblMAleatoria.TabIndex = 35;
            this.lblMAleatoria.Text = "L";
            // 
            // lblEnunciado1
            // 
            this.lblEnunciado1.AutoSize = true;
            this.lblEnunciado1.Location = new System.Drawing.Point(206, 108);
            this.lblEnunciado1.Name = "lblEnunciado1";
            this.lblEnunciado1.Size = new System.Drawing.Size(109, 13);
            this.lblEnunciado1.TabIndex = 34;
            this.lblEnunciado1.Text = "La matriz aleatoria es:";
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(170, 68);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(60, 20);
            this.txtFilas.TabIndex = 33;
            // 
            // lblPunto4
            // 
            this.lblPunto4.AutoSize = true;
            this.lblPunto4.Location = new System.Drawing.Point(444, 323);
            this.lblPunto4.Name = "lblPunto4";
            this.lblPunto4.Size = new System.Drawing.Size(13, 13);
            this.lblPunto4.TabIndex = 47;
            this.lblPunto4.Text = "L";
            // 
            // lblPunto3
            // 
            this.lblPunto3.AutoSize = true;
            this.lblPunto3.Location = new System.Drawing.Point(327, 323);
            this.lblPunto3.Name = "lblPunto3";
            this.lblPunto3.Size = new System.Drawing.Size(13, 13);
            this.lblPunto3.TabIndex = 46;
            this.lblPunto3.Text = "L";
            // 
            // lblPunto2
            // 
            this.lblPunto2.AutoSize = true;
            this.lblPunto2.Location = new System.Drawing.Point(162, 323);
            this.lblPunto2.Name = "lblPunto2";
            this.lblPunto2.Size = new System.Drawing.Size(13, 13);
            this.lblPunto2.TabIndex = 45;
            this.lblPunto2.Text = "L";
            // 
            // lblPunto1
            // 
            this.lblPunto1.AutoSize = true;
            this.lblPunto1.Location = new System.Drawing.Point(29, 323);
            this.lblPunto1.Name = "lblPunto1";
            this.lblPunto1.Size = new System.Drawing.Size(13, 13);
            this.lblPunto1.TabIndex = 44;
            this.lblPunto1.Text = "L";
            // 
            // lblEnunciado2
            // 
            this.lblEnunciado2.AutoSize = true;
            this.lblEnunciado2.Location = new System.Drawing.Point(162, 248);
            this.lblEnunciado2.Name = "lblEnunciado2";
            this.lblEnunciado2.Size = new System.Drawing.Size(237, 13);
            this.lblEnunciado2.TabIndex = 43;
            this.lblEnunciado2.Text = "Elija la operación a realizar con la matriz aleatoria";
            // 
            // btnPunto4
            // 
            this.btnPunto4.Location = new System.Drawing.Point(447, 273);
            this.btnPunto4.Name = "btnPunto4";
            this.btnPunto4.Size = new System.Drawing.Size(85, 23);
            this.btnPunto4.TabIndex = 42;
            this.btnPunto4.Text = "Numero Menor";
            this.btnPunto4.UseVisualStyleBackColor = true;
            this.btnPunto4.Click += new System.EventHandler(this.btnPunto4_Click);
            // 
            // btnPunto3
            // 
            this.btnPunto3.Location = new System.Drawing.Point(314, 273);
            this.btnPunto3.Name = "btnPunto3";
            this.btnPunto3.Size = new System.Drawing.Size(88, 23);
            this.btnPunto3.TabIndex = 41;
            this.btnPunto3.Text = "Numero Mayor";
            this.btnPunto3.UseVisualStyleBackColor = true;
            this.btnPunto3.Click += new System.EventHandler(this.btnPunto3_Click);
            // 
            // btnPunto2
            // 
            this.btnPunto2.Location = new System.Drawing.Point(158, 273);
            this.btnPunto2.Name = "btnPunto2";
            this.btnPunto2.Size = new System.Drawing.Size(95, 23);
            this.btnPunto2.TabIndex = 40;
            this.btnPunto2.Text = "Suma Columnas";
            this.btnPunto2.UseVisualStyleBackColor = true;
            this.btnPunto2.Click += new System.EventHandler(this.btnPunto2_Click);
            // 
            // btnPunto1
            // 
            this.btnPunto1.Location = new System.Drawing.Point(18, 273);
            this.btnPunto1.Name = "btnPunto1";
            this.btnPunto1.Size = new System.Drawing.Size(75, 23);
            this.btnPunto1.TabIndex = 39;
            this.btnPunto1.Text = "Suma Filas";
            this.btnPunto1.UseVisualStyleBackColor = true;
            this.btnPunto1.Click += new System.EventHandler(this.btnPunto1_Click);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(167, 9);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(321, 13);
            this.lblNota.TabIndex = 48;
            this.lblNota.Text = "NOTA: Elija las filas y columna para generar una matriz cuadrada :)";
            // 
            // frmArregloMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 382);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblPunto4);
            this.Controls.Add(this.lblPunto3);
            this.Controls.Add(this.lblPunto2);
            this.Controls.Add(this.lblPunto1);
            this.Controls.Add(this.lblEnunciado2);
            this.Controls.Add(this.btnPunto4);
            this.Controls.Add(this.btnPunto3);
            this.Controls.Add(this.btnPunto2);
            this.Controls.Add(this.btnPunto1);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblMAleatoria);
            this.Controls.Add(this.lblEnunciado1);
            this.Controls.Add(this.txtFilas);
            this.Controls.Add(this.lblColumnas);
            this.Controls.Add(this.lblFilas);
            this.Name = "frmArregloMatriz";
            this.Text = "Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblMAleatoria;
        private System.Windows.Forms.Label lblEnunciado1;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Label lblPunto4;
        private System.Windows.Forms.Label lblPunto3;
        private System.Windows.Forms.Label lblPunto2;
        private System.Windows.Forms.Label lblPunto1;
        private System.Windows.Forms.Label lblEnunciado2;
        private System.Windows.Forms.Button btnPunto4;
        private System.Windows.Forms.Button btnPunto3;
        private System.Windows.Forms.Button btnPunto2;
        private System.Windows.Forms.Button btnPunto1;
        private System.Windows.Forms.Label lblNota;
    }
}

