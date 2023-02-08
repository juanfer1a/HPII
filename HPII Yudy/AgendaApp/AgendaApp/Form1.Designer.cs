namespace AgendaApp
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelPpal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActalizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnListar);
            this.panelMenu.Controls.Add(this.btnEliminar);
            this.panelMenu.Controls.Add(this.btnActalizar);
            this.panelMenu.Controls.Add(this.btnBuscar);
            this.panelMenu.Controls.Add(this.btnAgregar);
            this.panelMenu.Location = new System.Drawing.Point(0, 66);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(172, 459);
            this.panelMenu.TabIndex = 0;
            // 
            // panelPpal
            // 
            this.panelPpal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelPpal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPpal.Location = new System.Drawing.Point(178, 66);
            this.panelPpal.Name = "panelPpal";
            this.panelPpal.Size = new System.Drawing.Size(610, 470);
            this.panelPpal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgendaApp.Properties.Resources.directorio;
            this.pictureBox1.Location = new System.Drawing.Point(46, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnListar
            // 
            this.btnListar.Image = global::AgendaApp.Properties.Resources.lista_de_contactos;
            this.btnListar.Location = new System.Drawing.Point(4, 386);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(161, 57);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar contactos";
            this.btnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::AgendaApp.Properties.Resources.no_amigo;
            this.btnEliminar.Location = new System.Drawing.Point(4, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 54);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Contacto ";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActalizar
            // 
            this.btnActalizar.Image = global::AgendaApp.Properties.Resources.actualizar;
            this.btnActalizar.Location = new System.Drawing.Point(3, 266);
            this.btnActalizar.Name = "btnActalizar";
            this.btnActalizar.Size = new System.Drawing.Size(161, 54);
            this.btnActalizar.TabIndex = 2;
            this.btnActalizar.Text = "Actalizar contacto";
            this.btnActalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActalizar.UseVisualStyleBackColor = true;
            this.btnActalizar.Click += new System.EventHandler(this.btnActalizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::AgendaApp.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(3, 206);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 54);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar contacto";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::AgendaApp.Properties.Resources.add_friend;
            this.btnAgregar.Location = new System.Drawing.Point(4, 146);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 54);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Contacto";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 552);
            this.Controls.Add(this.panelPpal);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Agenda";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPpal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActalizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
    }
}

