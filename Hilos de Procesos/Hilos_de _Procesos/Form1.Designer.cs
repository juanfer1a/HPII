namespace Hilos_de__Procesos
{
    partial class FrmHilosDeProcesos
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
            this.tmr100 = new System.Windows.Forms.Timer(this.components);
            this.tmr20 = new System.Windows.Forms.Timer(this.components);
            this.tmr50 = new System.Windows.Forms.Timer(this.components);
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr100
            // 
            this.tmr100.Interval = 300;
            this.tmr100.Tick += new System.EventHandler(this.tmr100_Tick_1);
            // 
            // tmr20
            // 
            this.tmr20.Interval = 300;
            this.tmr20.Tick += new System.EventHandler(this.tmr20_Tick_1);
            // 
            // tmr50
            // 
            this.tmr50.Interval = 300;
            this.tmr50.Tick += new System.EventHandler(this.tmr50_Tick_1);
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100.Location = new System.Drawing.Point(52, 30);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(29, 20);
            this.lbl100.TabIndex = 0;
            this.lbl100.Text = "00";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.Location = new System.Drawing.Point(123, 30);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(29, 20);
            this.lbl20.TabIndex = 1;
            this.lbl20.Text = "00";
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl50.Location = new System.Drawing.Point(189, 30);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(29, 20);
            this.lbl50.TabIndex = 2;
            this.lbl50.Text = "00";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(140, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 31);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "&Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(45, 173);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(67, 31);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl50);
            this.groupBox1.Controls.Add(this.lbl20);
            this.groupBox1.Controls.Add(this.lbl100);
            this.groupBox1.Location = new System.Drawing.Point(67, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contadores";
            // 
            // FrmHilosDeProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmHilosDeProcesos";
            this.Text = "Hilos de Procesos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHilosDeProcesos_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr100;
        private System.Windows.Forms.Timer tmr20;
        private System.Windows.Forms.Timer tmr50;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

