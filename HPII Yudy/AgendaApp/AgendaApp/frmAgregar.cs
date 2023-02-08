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
    public partial class frmAgregar : Form
    {
        GestorDB gestor = new GestorDB();

        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            cbProfesion.DataSource = gestor.ListarProfesiones();   
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumento.Text) ||
                string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Por favor no deje campos sin llenar", "Adventecia"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
            else
            {
                Contacto contacto = new Contacto();
                try
                {
                    contacto.Documento = int.Parse(txtDocumento.Text);
                    contacto.Nombre = txtNombre.Text;
                    contacto.Apellido = txtApellido.Text;
                    contacto.Direccion = txtDireccion.Text;
                    contacto.Email = txtEmail.Text;
                    contacto.Telefono= int.Parse(txtTelefono.Text);
                    contacto.IdProfesion = cbProfesion.SelectedIndex + 1;
                    if(gestor.ContactoExiste(contacto.Documento))
                    {

                        MessageBox.Show("El documento ya existe en la base de datos", "Adventecia"
                            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int respuesta = gestor.Guardarcontacto(contacto);
                        if(respuesta>0)
                            MessageBox.Show("Contacto guardado con exito", "Confirmación"
                                                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MessageBox.Show("No fue posible guardar el contacto", "Adventecia"
                           , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }


                }
                catch(Exception)
                {

                    MessageBox.Show("Asegurese que el telefono y/o documento sean numericos", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
