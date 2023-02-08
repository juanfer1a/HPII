using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexionDB
{
    public partial class frmLogin : Form
    {
    /// <summary>
    /// Programa que conecta con gestor de base de datos mySql con login y formulario para operaciones CRUD
    /// Realizado por Juan Fernando Quiceno
    /// se anexa copia de la base de datos en carpeta del programa
    /// </summary>
        string comando;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion myconexion = new conexion();
                comando = "CALL MOSTRAR_TABLA()";
                myconexion.crudMySql(comando, "dboherramientas");
                bool usuarioOK = false;
                bool claveOK = false;

                if (myconexion.DataTable != null)
                {
                    foreach (DataRow item in myconexion.DataTable.Rows)
                    {
                        if (item[1].ToString() == txtUsuario.Text)
                        {
                            usuarioOK = true;
                        }

                        if (item[0].ToString() == txtPassword.Text)
                        {
                            claveOK = true;
                        }
                    }

                }
                if (usuarioOK == true && claveOK == true)
                {
                    MessageBox.Show("Acceso autorizado");
                    this.Hide();
                    frmManejo_de_informacion crud = new frmManejo_de_informacion();
                    crud.Show();

                }
                else
                {
                    txtUsuario.Text = null;
                    txtPassword.Text = null;
                    MessageBox.Show("SUS DATOS O ALGUNO DE ELLOS SON INCORRECTOS INTENTE NUEVAMENTE", "ERROR DE AUTENTICACION");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DE CONEXION");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


