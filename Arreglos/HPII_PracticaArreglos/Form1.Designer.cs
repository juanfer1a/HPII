namespace HPII_PracticaArreglos
{
    partial class frmArreglos
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
            this.btnAsignarMatriz = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimirMatriz = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.btnAsignarVector = new System.Windows.Forms.Button();
            this.txtNumVector = new System.Windows.Forms.TextBox();
            this.btnImprimirVector = new System.Windows.Forms.Button();
            this.lblMostrarVector = new System.Windows.Forms.Label();
            this.btnOrdeVector = new System.Windows.Forms.Button();
            this.lblOrdenVector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAsignarMatriz
            // 
            this.btnAsignarMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarMatriz.Location = new System.Drawing.Point(101, 82);
            this.btnAsignarMatriz.Name = "btnAsignarMatriz";
            this.btnAsignarMatriz.Size = new System.Drawing.Size(159, 31);
            this.btnAsignarMatriz.TabIndex = 2;
            this.btnAsignarMatriz.Text = "Asignar a &Matriz";
            this.btnAsignarMatriz.UseVisualStyleBackColor = true;
            this.btnAsignarMatriz.Click += new System.EventHandler(this.btnAsignarMatriz_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(32, 88);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(49, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(28, 35);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(195, 20);
            this.lblIngreso.TabIndex = 8;
            this.lblIngreso.Text = "Ingreso Valores  Matriz";
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Location = new System.Drawing.Point(364, 81);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 20);
            this.lblMostrar.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(764, 438);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Cerrar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimirMatriz
            // 
            this.btnImprimirMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirMatriz.Location = new System.Drawing.Point(335, 35);
            this.btnImprimirMatriz.Name = "btnImprimirMatriz";
            this.btnImprimirMatriz.Size = new System.Drawing.Size(165, 31);
            this.btnImprimirMatriz.TabIndex = 3;
            this.btnImprimirMatriz.Text = "&Imprimir Matriz ";
            this.btnImprimirMatriz.UseVisualStyleBackColor = true;
            this.btnImprimirMatriz.Click += new System.EventHandler(this.btnImprimirMatriz_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(600, 35);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(165, 31);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "&Ordenar Matriz";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenar.Location = new System.Drawing.Point(631, 81);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(0, 20);
            this.lblOrdenar.TabIndex = 10;
            // 
            // btnAsignarVector
            // 
            this.btnAsignarVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarVector.Location = new System.Drawing.Point(101, 285);
            this.btnAsignarVector.Name = "btnAsignarVector";
            this.btnAsignarVector.Size = new System.Drawing.Size(159, 31);
            this.btnAsignarVector.TabIndex = 6;
            this.btnAsignarVector.Text = "Asignar a &Vector";
            this.btnAsignarVector.UseVisualStyleBackColor = true;
            this.btnAsignarVector.Click += new System.EventHandler(this.btnAsignarVector_Click);
            // 
            // txtNumVector
            // 
            this.txtNumVector.Location = new System.Drawing.Point(32, 291);
            this.txtNumVector.Name = "txtNumVector";
            this.txtNumVector.Size = new System.Drawing.Size(49, 20);
            this.txtNumVector.TabIndex = 5;
            this.txtNumVector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumVector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumVector_KeyPress);
            // 
            // btnImprimirVector
            // 
            this.btnImprimirVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirVector.Location = new System.Drawing.Point(335, 253);
            this.btnImprimirVector.Name = "btnImprimirVector";
            this.btnImprimirVector.Size = new System.Drawing.Size(165, 31);
            this.btnImprimirVector.TabIndex = 7;
            this.btnImprimirVector.Text = "Imprimir Vector";
            this.btnImprimirVector.UseVisualStyleBackColor = true;
            this.btnImprimirVector.Click += new System.EventHandler(this.btnImprimirVector_Click);
            // 
            // lblMostrarVector
            // 
            this.lblMostrarVector.AutoSize = true;
            this.lblMostrarVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarVector.Location = new System.Drawing.Point(344, 308);
            this.lblMostrarVector.Name = "lblMostrarVector";
            this.lblMostrarVector.Size = new System.Drawing.Size(0, 20);
            this.lblMostrarVector.TabIndex = 14;
            // 
            // btnOrdeVector
            // 
            this.btnOrdeVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdeVector.Location = new System.Drawing.Point(600, 253);
            this.btnOrdeVector.Name = "btnOrdeVector";
            this.btnOrdeVector.Size = new System.Drawing.Size(165, 31);
            this.btnOrdeVector.TabIndex = 8;
            this.btnOrdeVector.Text = "Ordenar Vector ";
            this.btnOrdeVector.UseVisualStyleBackColor = true;
            this.btnOrdeVector.Click += new System.EventHandler(this.btnOrdeVector_Click);
            // 
            // lblOrdenVector
            // 
            this.lblOrdenVector.AutoSize = true;
            this.lblOrdenVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenVector.Location = new System.Drawing.Point(611, 308);
            this.lblOrdenVector.Name = "lblOrdenVector";
            this.lblOrdenVector.Size = new System.Drawing.Size(0, 20);
            this.lblOrdenVector.TabIndex = 16;
            // 
            // frmArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 480);
            this.Controls.Add(this.lblOrdenVector);
            this.Controls.Add(this.btnOrdeVector);
            this.Controls.Add(this.lblMostrarVector);
            this.Controls.Add(this.btnImprimirVector);
            this.Controls.Add(this.txtNumVector);
            this.Controls.Add(this.btnAsignarVector);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnImprimirMatriz);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnAsignarMatriz);
            this.Name = "frmArreglos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriz 3 x 3 - Vector [9] ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAsignarMatriz;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimirMatriz;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.Button btnAsignarVector;
        private System.Windows.Forms.TextBox txtNumVector;
        private System.Windows.Forms.Button btnImprimirVector;
        private System.Windows.Forms.Label lblMostrarVector;
        private System.Windows.Forms.Button btnOrdeVector;
        private System.Windows.Forms.Label lblOrdenVector;
    }
}

