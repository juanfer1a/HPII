
namespace Prueba
{
    partial class frmNacho
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
            this.txtNumeroA = new System.Windows.Forms.TextBox();
            this.cmbSignos = new System.Windows.Forms.ComboBox();
            this.lblNumeroA = new System.Windows.Forms.Label();
            this.txtNumeroB = new System.Windows.Forms.TextBox();
            this.lblNumeroB = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tmrA = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtNumeroA
            // 
            this.txtNumeroA.Location = new System.Drawing.Point(90, 64);
            this.txtNumeroA.Name = "txtNumeroA";
            this.txtNumeroA.Size = new System.Drawing.Size(95, 20);
            this.txtNumeroA.TabIndex = 0;
            // 
            // cmbSignos
            // 
            this.cmbSignos.FormattingEnabled = true;
            this.cmbSignos.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbSignos.Location = new System.Drawing.Point(197, 62);
            this.cmbSignos.Name = "cmbSignos";
            this.cmbSignos.Size = new System.Drawing.Size(35, 21);
            this.cmbSignos.TabIndex = 1;
            // 
            // lblNumeroA
            // 
            this.lblNumeroA.AutoSize = true;
            this.lblNumeroA.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroA.Location = new System.Drawing.Point(86, 39);
            this.lblNumeroA.Name = "lblNumeroA";
            this.lblNumeroA.Size = new System.Drawing.Size(99, 22);
            this.lblNumeroA.TabIndex = 2;
            this.lblNumeroA.Text = "1° Numero";
            // 
            // txtNumeroB
            // 
            this.txtNumeroB.Location = new System.Drawing.Point(238, 62);
            this.txtNumeroB.Name = "txtNumeroB";
            this.txtNumeroB.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroB.TabIndex = 3;
            // 
            // lblNumeroB
            // 
            this.lblNumeroB.AutoSize = true;
            this.lblNumeroB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroB.Location = new System.Drawing.Point(234, 39);
            this.lblNumeroB.Name = "lblNumeroB";
            this.lblNumeroB.Size = new System.Drawing.Size(99, 22);
            this.lblNumeroB.TabIndex = 4;
            this.lblNumeroB.Text = "2° Numero";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(162, 125);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(162, 151);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 33);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tmrA
            // 
            this.tmrA.Interval = 5000;
            this.tmrA.Tick += new System.EventHandler(this.tmrA_Tick);
            // 
            // frmNacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 319);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblNumeroB);
            this.Controls.Add(this.txtNumeroB);
            this.Controls.Add(this.lblNumeroA);
            this.Controls.Add(this.cmbSignos);
            this.Controls.Add(this.txtNumeroA);
            this.Name = "frmNacho";
            this.Text = "Nacho Opera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroA;
        private System.Windows.Forms.ComboBox cmbSignos;
        private System.Windows.Forms.Label lblNumeroA;
        private System.Windows.Forms.TextBox txtNumeroB;
        private System.Windows.Forms.Label lblNumeroB;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Timer tmrA;
    }
}

