namespace ConsumoDLL
{
    partial class frmOperaciones
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
            this.grSuma = new System.Windows.Forms.GroupBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblRtadoSuma = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.txtopS2 = new System.Windows.Forms.TextBox();
            this.txtOpS1 = new System.Windows.Forms.TextBox();
            this.grResta = new System.Windows.Forms.GroupBox();
            this.btnResta = new System.Windows.Forms.Button();
            this.lblRtadoResta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpR = new System.Windows.Forms.Label();
            this.txtOpR2 = new System.Windows.Forms.TextBox();
            this.txtOpR1 = new System.Windows.Forms.TextBox();
            this.grMulti = new System.Windows.Forms.GroupBox();
            this.btnMulti = new System.Windows.Forms.Button();
            this.lblRtadoMulti = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpM2 = new System.Windows.Forms.TextBox();
            this.txtOpM1 = new System.Windows.Forms.TextBox();
            this.grDivi = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRtadoDiv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOpD2 = new System.Windows.Forms.TextBox();
            this.txtOpD1 = new System.Windows.Forms.TextBox();
            this.grSuma.SuspendLayout();
            this.grResta.SuspendLayout();
            this.grMulti.SuspendLayout();
            this.grDivi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grSuma
            // 
            this.grSuma.Controls.Add(this.btnDiv);
            this.grSuma.Controls.Add(this.lblRtadoSuma);
            this.grSuma.Controls.Add(this.lblIgual);
            this.grSuma.Controls.Add(this.lblOperacion);
            this.grSuma.Controls.Add(this.txtopS2);
            this.grSuma.Controls.Add(this.txtOpS1);
            this.grSuma.Location = new System.Drawing.Point(46, 15);
            this.grSuma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grSuma.Name = "grSuma";
            this.grSuma.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grSuma.Size = new System.Drawing.Size(418, 101);
            this.grSuma.TabIndex = 0;
            this.grSuma.TabStop = false;
            this.grSuma.Text = "SUMA";
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(357, 65);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(56, 31);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "Sumar";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // lblRtadoSuma
            // 
            this.lblRtadoSuma.AutoSize = true;
            this.lblRtadoSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRtadoSuma.Location = new System.Drawing.Point(273, 38);
            this.lblRtadoSuma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRtadoSuma.Name = "lblRtadoSuma";
            this.lblRtadoSuma.Size = new System.Drawing.Size(26, 29);
            this.lblRtadoSuma.TabIndex = 4;
            this.lblRtadoSuma.Text = "0";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.Location = new System.Drawing.Point(220, 37);
            this.lblIgual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(27, 29);
            this.lblIgual.TabIndex = 3;
            this.lblIgual.Text = "=";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(104, 38);
            this.lblOperacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(27, 29);
            this.lblOperacion.TabIndex = 2;
            this.lblOperacion.Text = "+";
            // 
            // txtopS2
            // 
            this.txtopS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtopS2.Location = new System.Drawing.Point(145, 37);
            this.txtopS2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtopS2.Name = "txtopS2";
            this.txtopS2.Size = new System.Drawing.Size(54, 32);
            this.txtopS2.TabIndex = 1;
            // 
            // txtOpS1
            // 
            this.txtOpS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpS1.Location = new System.Drawing.Point(34, 37);
            this.txtOpS1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpS1.Name = "txtOpS1";
            this.txtOpS1.Size = new System.Drawing.Size(54, 32);
            this.txtOpS1.TabIndex = 0;
            // 
            // grResta
            // 
            this.grResta.Controls.Add(this.btnResta);
            this.grResta.Controls.Add(this.lblRtadoResta);
            this.grResta.Controls.Add(this.label1);
            this.grResta.Controls.Add(this.lblOpR);
            this.grResta.Controls.Add(this.txtOpR2);
            this.grResta.Controls.Add(this.txtOpR1);
            this.grResta.Location = new System.Drawing.Point(46, 142);
            this.grResta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grResta.Name = "grResta";
            this.grResta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grResta.Size = new System.Drawing.Size(418, 101);
            this.grResta.TabIndex = 1;
            this.grResta.TabStop = false;
            this.grResta.Text = "RESTA";
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(357, 70);
            this.btnResta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(56, 31);
            this.btnResta.TabIndex = 9;
            this.btnResta.Text = "Restar";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // lblRtadoResta
            // 
            this.lblRtadoResta.AutoSize = true;
            this.lblRtadoResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRtadoResta.Location = new System.Drawing.Point(273, 36);
            this.lblRtadoResta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRtadoResta.Name = "lblRtadoResta";
            this.lblRtadoResta.Size = new System.Drawing.Size(26, 29);
            this.lblRtadoResta.TabIndex = 8;
            this.lblRtadoResta.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "=";
            // 
            // lblOpR
            // 
            this.lblOpR.AutoSize = true;
            this.lblOpR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpR.Location = new System.Drawing.Point(94, 36);
            this.lblOpR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpR.Name = "lblOpR";
            this.lblOpR.Size = new System.Drawing.Size(21, 29);
            this.lblOpR.TabIndex = 6;
            this.lblOpR.Text = "-";
            // 
            // txtOpR2
            // 
            this.txtOpR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpR2.Location = new System.Drawing.Point(136, 34);
            this.txtOpR2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpR2.Name = "txtOpR2";
            this.txtOpR2.Size = new System.Drawing.Size(54, 32);
            this.txtOpR2.TabIndex = 5;
            // 
            // txtOpR1
            // 
            this.txtOpR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpR1.Location = new System.Drawing.Point(26, 34);
            this.txtOpR1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpR1.Name = "txtOpR1";
            this.txtOpR1.Size = new System.Drawing.Size(54, 32);
            this.txtOpR1.TabIndex = 4;
            // 
            // grMulti
            // 
            this.grMulti.Controls.Add(this.btnMulti);
            this.grMulti.Controls.Add(this.lblRtadoMulti);
            this.grMulti.Controls.Add(this.label3);
            this.grMulti.Controls.Add(this.label4);
            this.grMulti.Controls.Add(this.txtOpM2);
            this.grMulti.Controls.Add(this.txtOpM1);
            this.grMulti.Location = new System.Drawing.Point(46, 260);
            this.grMulti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grMulti.Name = "grMulti";
            this.grMulti.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grMulti.Size = new System.Drawing.Size(418, 101);
            this.grMulti.TabIndex = 2;
            this.grMulti.TabStop = false;
            this.grMulti.Text = "MULTIPLICACIÓN";
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(338, 70);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(76, 31);
            this.btnMulti.TabIndex = 9;
            this.btnMulti.Text = "Multiplica";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // lblRtadoMulti
            // 
            this.lblRtadoMulti.AutoSize = true;
            this.lblRtadoMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRtadoMulti.Location = new System.Drawing.Point(273, 37);
            this.lblRtadoMulti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRtadoMulti.Name = "lblRtadoMulti";
            this.lblRtadoMulti.Size = new System.Drawing.Size(26, 29);
            this.lblRtadoMulti.TabIndex = 8;
            this.lblRtadoMulti.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "*";
            // 
            // txtOpM2
            // 
            this.txtOpM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpM2.Location = new System.Drawing.Point(145, 35);
            this.txtOpM2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpM2.Name = "txtOpM2";
            this.txtOpM2.Size = new System.Drawing.Size(54, 32);
            this.txtOpM2.TabIndex = 5;
            // 
            // txtOpM1
            // 
            this.txtOpM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpM1.Location = new System.Drawing.Point(34, 35);
            this.txtOpM1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpM1.Name = "txtOpM1";
            this.txtOpM1.Size = new System.Drawing.Size(54, 32);
            this.txtOpM1.TabIndex = 4;
            // 
            // grDivi
            // 
            this.grDivi.Controls.Add(this.button1);
            this.grDivi.Controls.Add(this.lblRtadoDiv);
            this.grDivi.Controls.Add(this.label5);
            this.grDivi.Controls.Add(this.label6);
            this.grDivi.Controls.Add(this.txtOpD2);
            this.grDivi.Controls.Add(this.txtOpD1);
            this.grDivi.Location = new System.Drawing.Point(46, 402);
            this.grDivi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grDivi.Name = "grDivi";
            this.grDivi.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grDivi.Size = new System.Drawing.Size(418, 101);
            this.grDivi.TabIndex = 3;
            this.grDivi.TabStop = false;
            this.grDivi.Text = "DIVISIÓN";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(338, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "División";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblRtadoDiv
            // 
            this.lblRtadoDiv.AutoSize = true;
            this.lblRtadoDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRtadoDiv.Location = new System.Drawing.Point(273, 39);
            this.lblRtadoDiv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRtadoDiv.Name = "lblRtadoDiv";
            this.lblRtadoDiv.Size = new System.Drawing.Size(26, 29);
            this.lblRtadoDiv.TabIndex = 8;
            this.lblRtadoDiv.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "/";
            // 
            // txtOpD2
            // 
            this.txtOpD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpD2.Location = new System.Drawing.Point(136, 39);
            this.txtOpD2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpD2.Name = "txtOpD2";
            this.txtOpD2.Size = new System.Drawing.Size(54, 32);
            this.txtOpD2.TabIndex = 5;
            // 
            // txtOpD1
            // 
            this.txtOpD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpD1.Location = new System.Drawing.Point(26, 39);
            this.txtOpD1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpD1.Name = "txtOpD1";
            this.txtOpD1.Size = new System.Drawing.Size(54, 32);
            this.txtOpD1.TabIndex = 4;
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 553);
            this.Controls.Add(this.grDivi);
            this.Controls.Add(this.grMulti);
            this.Controls.Add(this.grResta);
            this.Controls.Add(this.grSuma);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmOperaciones";
            this.Text = "Nacho Opera + Aritmética";
            this.grSuma.ResumeLayout(false);
            this.grSuma.PerformLayout();
            this.grResta.ResumeLayout(false);
            this.grResta.PerformLayout();
            this.grMulti.ResumeLayout(false);
            this.grMulti.PerformLayout();
            this.grDivi.ResumeLayout(false);
            this.grDivi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grSuma;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblRtadoSuma;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.TextBox txtopS2;
        private System.Windows.Forms.TextBox txtOpS1;
        private System.Windows.Forms.GroupBox grResta;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Label lblRtadoResta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpR;
        private System.Windows.Forms.TextBox txtOpR2;
        private System.Windows.Forms.TextBox txtOpR1;
        private System.Windows.Forms.GroupBox grMulti;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Label lblRtadoMulti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpM2;
        private System.Windows.Forms.TextBox txtOpM1;
        private System.Windows.Forms.GroupBox grDivi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRtadoDiv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOpD2;
        private System.Windows.Forms.TextBox txtOpD1;
    }
}

