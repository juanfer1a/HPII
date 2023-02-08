namespace Matriz
{
    partial class Frm_Matriz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Nud_Filas = new System.Windows.Forms.NumericUpDown();
            this.Nud_Columnas = new System.Windows.Forms.NumericUpDown();
            this.lbl_Filas = new System.Windows.Forms.Label();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.lbl_TamañoMariz = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMostrarMatriz = new System.Windows.Forms.Label();
            this.dgvMostrarMatriz = new System.Windows.Forms.DataGridView();
            this.dtgvSumaFilas = new System.Windows.Forms.DataGridView();
            this.dtgvSumaColumnas = new System.Windows.Forms.DataGridView();
            this.btnSumaFilas = new System.Windows.Forms.Button();
            this.btnSumaColumnas = new System.Windows.Forms.Button();
            this.btnMayor = new System.Windows.Forms.Button();
            this.lblMayor = new System.Windows.Forms.Label();
            this.btnMenor = new System.Windows.Forms.Button();
            this.lblMenor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPoblar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReinicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Filas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Columnas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSumaFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSumaColumnas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nud_Filas
            // 
            this.Nud_Filas.Location = new System.Drawing.Point(161, 75);
            this.Nud_Filas.Name = "Nud_Filas";
            this.Nud_Filas.Size = new System.Drawing.Size(57, 22);
            this.Nud_Filas.TabIndex = 0;
            this.Nud_Filas.ValueChanged += new System.EventHandler(this.Nud_Filas_ValueChanged);
            // 
            // Nud_Columnas
            // 
            this.Nud_Columnas.Location = new System.Drawing.Point(161, 117);
            this.Nud_Columnas.Name = "Nud_Columnas";
            this.Nud_Columnas.Size = new System.Drawing.Size(57, 22);
            this.Nud_Columnas.TabIndex = 1;
            this.Nud_Columnas.ValueChanged += new System.EventHandler(this.Nud_Columnas_ValueChanged);
            // 
            // lbl_Filas
            // 
            this.lbl_Filas.AutoSize = true;
            this.lbl_Filas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filas.Location = new System.Drawing.Point(25, 75);
            this.lbl_Filas.Name = "lbl_Filas";
            this.lbl_Filas.Size = new System.Drawing.Size(47, 20);
            this.lbl_Filas.TabIndex = 2;
            this.lbl_Filas.Text = "Filas";
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnas.Location = new System.Drawing.Point(25, 117);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(88, 20);
            this.lblColumnas.TabIndex = 3;
            this.lblColumnas.Text = "Columnas";
            // 
            // lbl_TamañoMariz
            // 
            this.lbl_TamañoMariz.AutoSize = true;
            this.lbl_TamañoMariz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TamañoMariz.Location = new System.Drawing.Point(57, 39);
            this.lbl_TamañoMariz.Name = "lbl_TamañoMariz";
            this.lbl_TamañoMariz.Size = new System.Drawing.Size(127, 20);
            this.lbl_TamañoMariz.TabIndex = 4;
            this.lbl_TamañoMariz.Text = "Tamaño Matriz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_TamañoMariz);
            this.groupBox1.Controls.Add(this.lblColumnas);
            this.groupBox1.Controls.Add(this.lbl_Filas);
            this.groupBox1.Controls.Add(this.Nud_Columnas);
            this.groupBox1.Controls.Add(this.Nud_Filas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capacidad";
            // 
            // lblMostrarMatriz
            // 
            this.lblMostrarMatriz.AutoSize = true;
            this.lblMostrarMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarMatriz.Location = new System.Drawing.Point(56, 22);
            this.lblMostrarMatriz.Name = "lblMostrarMatriz";
            this.lblMostrarMatriz.Size = new System.Drawing.Size(0, 20);
            this.lblMostrarMatriz.TabIndex = 5;
            // 
            // dgvMostrarMatriz
            // 
            this.dgvMostrarMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMostrarMatriz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostrarMatriz.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMostrarMatriz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarMatriz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarMatriz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarMatriz.ColumnHeadersVisible = false;
            this.dgvMostrarMatriz.EnableHeadersVisualStyles = false;
            this.dgvMostrarMatriz.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvMostrarMatriz.Location = new System.Drawing.Point(14, 22);
            this.dgvMostrarMatriz.Name = "dgvMostrarMatriz";
            this.dgvMostrarMatriz.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarMatriz.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrarMatriz.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMostrarMatriz.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMostrarMatriz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrarMatriz.Size = new System.Drawing.Size(241, 213);
            this.dgvMostrarMatriz.TabIndex = 7;
            // 
            // dtgvSumaFilas
            // 
            this.dtgvSumaFilas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvSumaFilas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvSumaFilas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvSumaFilas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSumaFilas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSumaFilas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvSumaFilas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSumaFilas.ColumnHeadersVisible = false;
            this.dtgvSumaFilas.EnableHeadersVisualStyles = false;
            this.dtgvSumaFilas.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtgvSumaFilas.Location = new System.Drawing.Point(261, 21);
            this.dtgvSumaFilas.Name = "dtgvSumaFilas";
            this.dtgvSumaFilas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSumaFilas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvSumaFilas.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvSumaFilas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvSumaFilas.Size = new System.Drawing.Size(59, 213);
            this.dtgvSumaFilas.TabIndex = 8;
            // 
            // dtgvSumaColumnas
            // 
            this.dtgvSumaColumnas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvSumaColumnas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvSumaColumnas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvSumaColumnas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSumaColumnas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSumaColumnas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvSumaColumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSumaColumnas.ColumnHeadersVisible = false;
            this.dtgvSumaColumnas.EnableHeadersVisualStyles = false;
            this.dtgvSumaColumnas.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtgvSumaColumnas.Location = new System.Drawing.Point(14, 243);
            this.dtgvSumaColumnas.Name = "dtgvSumaColumnas";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSumaColumnas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvSumaColumnas.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvSumaColumnas.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvSumaColumnas.Size = new System.Drawing.Size(269, 45);
            this.dtgvSumaColumnas.TabIndex = 9;
            // 
            // btnSumaFilas
            // 
            this.btnSumaFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumaFilas.Location = new System.Drawing.Point(10, 108);
            this.btnSumaFilas.Name = "btnSumaFilas";
            this.btnSumaFilas.Size = new System.Drawing.Size(162, 35);
            this.btnSumaFilas.TabIndex = 3;
            this.btnSumaFilas.Text = "Suma &Filas";
            this.btnSumaFilas.UseVisualStyleBackColor = true;
            this.btnSumaFilas.Click += new System.EventHandler(this.btnSumaFilas_Click);
            // 
            // btnSumaColumnas
            // 
            this.btnSumaColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumaColumnas.Location = new System.Drawing.Point(10, 149);
            this.btnSumaColumnas.Name = "btnSumaColumnas";
            this.btnSumaColumnas.Size = new System.Drawing.Size(162, 35);
            this.btnSumaColumnas.TabIndex = 4;
            this.btnSumaColumnas.Text = "Suma &Columnas";
            this.btnSumaColumnas.UseVisualStyleBackColor = true;
            this.btnSumaColumnas.Click += new System.EventHandler(this.btnSumaColumnas_Click);
            // 
            // btnMayor
            // 
            this.btnMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayor.Location = new System.Drawing.Point(10, 190);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(162, 35);
            this.btnMayor.TabIndex = 5;
            this.btnMayor.Text = "Buscar &Mayor";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor.Location = new System.Drawing.Point(103, 310);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(0, 20);
            this.lblMayor.TabIndex = 5;
            // 
            // btnMenor
            // 
            this.btnMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenor.Location = new System.Drawing.Point(10, 233);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(162, 35);
            this.btnMenor.TabIndex = 6;
            this.btnMenor.Text = "&Buscar Menor";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.Location = new System.Drawing.Point(257, 310);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(0, 20);
            this.lblMenor.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mayor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Menor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvSumaColumnas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblMenor);
            this.groupBox2.Controls.Add(this.dtgvSumaFilas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvMostrarMatriz);
            this.groupBox2.Controls.Add(this.lblMostrarMatriz);
            this.groupBox2.Controls.Add(this.lblMayor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(485, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 354);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Impresion de datos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMenor);
            this.groupBox3.Controls.Add(this.btnMayor);
            this.groupBox3.Controls.Add(this.btnSumaColumnas);
            this.groupBox3.Controls.Add(this.btnSumaFilas);
            this.groupBox3.Controls.Add(this.btnPoblar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(291, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 277);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones";
            // 
            // btnPoblar
            // 
            this.btnPoblar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoblar.Location = new System.Drawing.Point(46, 51);
            this.btnPoblar.Name = "btnPoblar";
            this.btnPoblar.Size = new System.Drawing.Size(84, 35);
            this.btnPoblar.TabIndex = 2;
            this.btnPoblar.Text = "&Poblar";
            this.btnPoblar.UseVisualStyleBackColor = true;
            this.btnPoblar.Click += new System.EventHandler(this.btnPoblar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(148, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReinicio
            // 
            this.btnReinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinicio.Location = new System.Drawing.Point(43, 315);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(84, 35);
            this.btnReinicio.TabIndex = 7;
            this.btnReinicio.Text = "&Reiniciar";
            this.btnReinicio.UseVisualStyleBackColor = true;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // Frm_Matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 377);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Matriz";
            this.Text = "Matriz";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Filas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Columnas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSumaFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSumaColumnas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Nud_Filas;
        private System.Windows.Forms.NumericUpDown Nud_Columnas;
        private System.Windows.Forms.Label lbl_Filas;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Label lbl_TamañoMariz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMostrarMatriz;
        private System.Windows.Forms.DataGridView dgvMostrarMatriz;
        private System.Windows.Forms.DataGridView dtgvSumaFilas;
        private System.Windows.Forms.DataGridView dtgvSumaColumnas;
        private System.Windows.Forms.Button btnSumaFilas;
        private System.Windows.Forms.Button btnSumaColumnas;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPoblar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReinicio;
    }
}