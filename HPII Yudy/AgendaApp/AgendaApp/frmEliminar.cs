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
    public partial class frmEliminar : Form
    {
        GestorDB gestor = new GestorDB();
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int respuesta = gestor.EliminarContacto(int.Parse(txtDocumento.Text));

            if (respuesta > 0)
            {
                MessageBox.Show("Contacto eliminado con exito", "Confirmación",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            else
                MessageBox.Show("No fue posible eliminar el contacto por: "+gestor.ToString(),
                    "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDocumento.Text = "";
            groupBox1.Visible = false;
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
