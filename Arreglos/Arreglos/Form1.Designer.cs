namespace Arreglos
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
            this.lblPosicionX = new System.Windows.Forms.Label();
            this.lblPosicionY = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.lblPosX = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.Nud_Y = new System.Windows.Forms.NumericUpDown();
            this.Nud_X = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_X)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPosicionX
            // 
            this.lblPosicionX.AutoSize = true;
            this.lblPosicionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionX.Location = new System.Drawing.Point(23, 46);
            this.lblPosicionX.Name = "lblPosicionX";
            this.lblPosicionX.Size = new System.Drawing.Size(138, 25);
            this.lblPosicionX.TabIndex = 0;
            this.lblPosicionX.Text = "Posición en X:";
            // 
            // lblPosicionY
            // 
            this.lblPosicionY.AutoSize = true;
            this.lblPosicionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionY.Location = new System.Drawing.Point(24, 21);
            this.lblPosicionY.Name = "lblPosicionY";
            this.lblPosicionY.Size = new System.Drawing.Size(137, 25);
            this.lblPosicionY.TabIndex = 1;
            this.lblPosicionY.Text = "Posición en Y:";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosY.Location = new System.Drawing.Point(214, 122);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(0, 25);
            this.lblPosY.TabIndex = 3;
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosX.Location = new System.Drawing.Point(214, 80);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(0, 25);
            this.lblPosX.TabIndex = 2;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(187, 97);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(315, 25);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "Ingrese el número para la posición:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(276, 147);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 2;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(276, 204);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(100, 63);
            this.btnAsignar.TabIndex = 3;
            this.btnAsignar.Text = "&Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // Nud_Y
            // 
            this.Nud_Y.Location = new System.Drawing.Point(181, 21);
            this.Nud_Y.Name = "Nud_Y";
            this.Nud_Y.Size = new System.Drawing.Size(120, 22);
            this.Nud_Y.TabIndex = 0;
            // 
            // Nud_X
            // 
            this.Nud_X.Location = new System.Drawing.Point(181, 55);
            this.Nud_X.Name = "Nud_X";
            this.Nud_X.Size = new System.Drawing.Size(120, 22);
            this.Nud_X.TabIndex = 1;
            this.Nud_X.Click += new System.EventHandler(this.Nud_X_Click);
            // 
            // frmArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 403);
            this.Controls.Add(this.Nud_X);
            this.Controls.Add(this.Nud_Y);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblPosY);
            this.Controls.Add(this.lblPosX);
            this.Controls.Add(this.lblPosicionY);
            this.Controls.Add(this.lblPosicionX);
            this.Name = "frmArreglos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arreglos";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_X)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosicionX;
        private System.Windows.Forms.Label lblPosicionY;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.NumericUpDown Nud_Y;
        private System.Windows.Forms.NumericUpDown Nud_X;
    }
}

