namespace WindowsFormsApp2
{
    partial class frmCarga
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
            this.btnArchivo = new System.Windows.Forms.Button();
            this.dtGCSV = new System.Windows.Forms.DataGridView();
            this.FDialogArchivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtGCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(24, 30);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(97, 41);
            this.btnArchivo.TabIndex = 0;
            this.btnArchivo.Text = "Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // dtGCSV
            // 
            this.dtGCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGCSV.Location = new System.Drawing.Point(158, 30);
            this.dtGCSV.Name = "dtGCSV";
            this.dtGCSV.RowTemplate.Height = 24;
            this.dtGCSV.Size = new System.Drawing.Size(616, 350);
            this.dtGCSV.TabIndex = 1;
            // 
            // FDialogArchivo
            // 
            this.FDialogArchivo.FileName = "openFileDialog1";
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGCSV);
            this.Controls.Add(this.btnArchivo);
            this.Name = "frmCarga";
            this.Text = "Carga masiva de datos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGCSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.DataGridView dtGCSV;
        private System.Windows.Forms.OpenFileDialog FDialogArchivo;
    }
}