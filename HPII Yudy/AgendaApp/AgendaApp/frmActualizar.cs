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
    public partial class frmActualizar : Form
    {
        GestorDB gestor = new GestorDB();
        public frmActualizar()
        {
            InitializeComponent();
        }

     
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int documento = int.Parse(txtDocumento.Text);
            var contacto = gestor.BuscarContacto(documento);
            if (contacto != null)
            {
                txtNombre.Text = contacto.Nombre;
                txtApellido.Text = contacto.Apellido;
                txtEmail.Text = contacto.Email;
                txtTelefono.Text = contacto.Telefono.ToString();
                txtDireccion.Text = contacto.Direccion;
                cbProfesion.DataSource = gestor.ListarProfesiones();
                cbProfesion.SelectedIndex = contacto.IdProfesion - 1;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto();
            contacto.Documento = int.Parse(txtDocumento.Text);
            contacto.Nombre = txtNombre.Text;
            contacto.Apellido = txtApellido.Text;
            contacto.Email = txtEmail.Text;
            contacto.Telefono = int.Parse(txtTelefono.Text);
            contacto.IdProfesion = cbProfesion.SelectedIndex + 1;
            contacto.Direccion = txtDireccion.Text;
            int respuesta = gestor.Actualizarcontacto(contacto);
            if(respuesta>0)
            {
                MessageBox.Show("Contacto actualizado con éxito", "Confirmación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
                MessageBox.Show("No se pudo actualizar el contacto por: "+ gestor.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            groupBox1.Visible = false;
            txtDocumento.Text = "";

        }
    }
}
