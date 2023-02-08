namespace Paralelismo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblhilo1 = new System.Windows.Forms.Label();
            this.lblHilo2 = new System.Windows.Forms.Label();
            this.lblH2 = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.tmrH1 = new System.Windows.Forms.Timer(this.components);
            this.tmrH2 = new System.Windows.Forms.Timer(this.components);
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhilo1
            // 
            this.lblhilo1.AutoSize = true;
            this.lblhilo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhilo1.Location = new System.Drawing.Point(82, 50);
            this.lblhilo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhilo1.Name = "lblhilo1";
            this.lblhilo1.Size = new System.Drawing.Size(58, 24);
            this.lblhilo1.TabIndex = 0;
            this.lblhilo1.Text = "Hilo 1";
            // 
            // lblHilo2
            // 
            this.lblHilo2.AutoSize = true;
            this.lblHilo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHilo2.Location = new System.Drawing.Point(253, 50);
            this.lblHilo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHilo2.Name = "lblHilo2";
            this.lblHilo2.Size = new System.Drawing.Size(58, 24);
            this.lblHilo2.TabIndex = 1;
            this.lblHilo2.Text = "Hilo 2";
            // 
            // lblH2
            // 
            this.lblH2.AutoSize = true;
            this.lblH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH2.Location = new System.Drawing.Point(253, 142);
            this.lblH2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblH2.Name = "lblH2";
            this.lblH2.Size = new System.Drawing.Size(0, 24);
            this.lblH2.TabIndex = 3;
            // 
            // lblH1
            // 
            this.lblH1.AutoSize = true;
            this.lblH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH1.Location = new System.Drawing.Point(82, 142);
            this.lblH1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(0, 24);
            this.lblH1.TabIndex = 2;
            // 
            // tmrH1
            // 
            this.tmrH1.Interval = 500;
            this.tmrH1.Tick += new System.EventHandler(this.tmrH1_Tick);
            // 
            // tmrH2
            // 
            this.tmrH2.Tick += new System.EventHandler(this.tmrH2_Tick);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(176, 241);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(70, 38);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 289);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblH2);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.lblHilo2);
            this.Controls.Add(this.lblhilo1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhilo1;
        private System.Windows.Forms.Label lblHilo2;
        private System.Windows.Forms.Label lblH2;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.Timer tmrH1;
        private System.Windows.Forms.Timer tmrH2;
        private System.Windows.Forms.Button btnIniciar;
    }
}

