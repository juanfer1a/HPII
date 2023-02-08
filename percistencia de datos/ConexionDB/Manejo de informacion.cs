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
    public partial class frmManejo_de_informacion : Form
    {
        public frmManejo_de_informacion()
        {
            InitializeComponent();
        }

        //evento click para crear un usuario en la db 
        private void btnCrear_Click(object sender, EventArgs e)
        {   
            //pedimos los campos id y nombre como minimo requisito para crear un usuario esto con el fin de poder de 
            //que el usuario se pueda logear 
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("LOS CAMPOS ID Y NOMBRE SON OBLIGATORIOS");
            }

            //se utiliza un sp para definido en la db para la inserccion  de datos en al tabla
            else
            {
                conexion myconexion = new conexion();
                string comando = $"CALL INSERT_INTO({int.Parse(txtId.Text)},'{txtNombre.Text}','{txtApellido.Text}','{txtCorreo.Text}'" +
                    $",'{txtDireccion.Text}')";
                myconexion.crudMySql(comando, "dboherramientas");

                //se instancia formulario que muestra  la informacion
                frmMostrar mostrar = new frmMostrar();
                mostrar.comman($"CALL MOSTRAR_PERSONA({int.Parse(txtId.Text)})");
                mostrar.Show();
                myconexion.Connection.Close();
            }

            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
        }

        //evento consultar 
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //si el usuario ingresa el id la busqueda se hace especifica 
            if (txtId.Text != "")
            {
                conexion myconexion = new conexion();
                frmMostrar mostrar = new frmMostrar();
                mostrar.comman($"CALL MOSTRAR_PERSONA({int.Parse(txtId.Text)})");
                mostrar.Show();

            }
            
            //si el usuario no ingresa el id se muestra la informacion general de al tabla 
            else
            {
                mostrarTabla();
            }
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
        }

        //metodo borrar usuario
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //si valida que el usuario ingrese el id correspondiente para eliminar
            if (txtId.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL ID DEL USUARIO A ELIMINAR");
            }

            //se hace uso del sp correspondiente al borrado
            else
            {
                //isntancia de la clase conexion
                conexion myconexion = new conexion();
                string comando = $"CALL DELETE_PERSONA({int.Parse(txtId.Text)})";
                myconexion.crudMySql(comando, "dboherramientas");
                myconexion.Connection.Close();
            }
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
            mostrarTabla();
        }

        //evento update
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //se de ingresar el id que se va a actualizar
            if (txtId.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL ID DEL USUARIO A MODIFICAR");
            }

            //se evalua cada campo, para hacer la correspondiente actulizacion de la fila 
            else
            {
                if (txtApellido.Text != "")
                {
                    conexion myconexion = new conexion();
                    string comando = $"CALL UPDATE_APELLIDO({int.Parse(txtId.Text)},'{txtApellido.Text}')";
                    myconexion.crudMySql(comando, "dboherramientas");
                    myconexion.Connection.Close();
                }
                if (txtNombre.Text != "")
                {
                    conexion myconexion = new conexion();
                    string comando = $"CALL UPDATE_NOMBRE({int.Parse(txtId.Text)},'{txtNombre.Text}')";
                    myconexion.crudMySql(comando, "dboherramientas");
                    myconexion.Connection.Close();
                }
                if (txtCorreo.Text != "")
                {
                    conexion myconexion = new conexion();
                    string comando = $"CALL UPDATE_CORREO({int.Parse(txtId.Text)},'{txtCorreo.Text}')";
                    myconexion.crudMySql(comando, "dboherramientas");
                    myconexion.Connection.Close();
                }

                if (txtDireccion.Text != "")
                {
                    conexion myconexion = new conexion();
                    string comando = $"CALL UPDATE_DIRECCION({int.Parse(txtId.Text)},'{txtDireccion.Text}')";
                    myconexion.crudMySql(comando, "dboherramientas");
                    myconexion.Connection.Close();
                }
                mostrarTabla();
            }

            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";

        }

        //metodo estatico para mostrar tabla
        static void mostrarTabla()
        {
            frmMostrar mostrar = new frmMostrar();
            mostrar.comman($"CALL MOSTRAR_TABLA()");
            mostrar.Show();
        }

    }
}
