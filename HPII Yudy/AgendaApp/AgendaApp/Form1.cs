using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AgendaApp
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            AbrirFormulario(agregar);
        }

        private void AbrirFormulario(Form formHijo)
        {
            if (this.panelPpal.Controls.Count > 0)
                this.panelPpal.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.panelPpal.Controls.Add(formHijo);
            formHijo.Show();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar buscar = new frmBuscar();
            AbrirFormulario(buscar);
        }

        private void btnActalizar_Click(object sender, EventArgs e)
        {
            frmActualizar actualizar = new frmActualizar();
            AbrirFormulario(actualizar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar eliminar = new frmEliminar();
            AbrirFormulario(eliminar);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListar listar = new frmListar();
            AbrirFormulario(listar);
        }
    }
}
