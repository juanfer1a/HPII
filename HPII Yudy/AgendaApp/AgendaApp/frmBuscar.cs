using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaApp
{
    public partial class frmBuscar : Form
    {
        GestorDB gestor = new GestorDB();
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int documento = int.Parse(txtDocumento.Text);
            var contacto = gestor.BuscarContacto(documento);
            if (contacto != null)
            {
                lblNombre.Text = contacto.Nombre;
                lblApellido.Text = contacto.Apellido;
                lblEmail.Text = contacto.Email;
                lblTelefono.Text = contacto.Telefono.ToString();
                lblDireccion.Text = contacto.Direccion;
                lblProfesion.Text = contacto.Profesion;
                groupBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Documento no encontrado", "Resultado",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumento.Text = "";
                groupBox1.Visible = false;
            }
               
        }
    }
}
