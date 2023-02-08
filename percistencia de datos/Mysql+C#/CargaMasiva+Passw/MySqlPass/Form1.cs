using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace sqlPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        static MySqlConnection Conex = new MySqlConnection();
        static string serv = "Server=localhost;";  //127.0.0.1
        static string db = "Database=db_hexocoins;";
        static string usuario = "UID=root;";
        static string pwd = "Password =;";
        string CadenaDeConexion = serv + db + usuario + pwd;

       
        private void Form1_Load(object sender, EventArgs e)
        {
            //string answer = Interaction.InputBox("Please enter the server address");
               //string answer = Interaction.InputBox("127.0.0.1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry = "select * from tbl_usuario";
            MySqlCommand Comando = new MySqlCommand(qry, Conex);
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();
            bool usuarioOK = false;
            bool claveOK = false;
            try
            {

                Conex.ConnectionString = CadenaDeConexion;
                Conex.Open();
                MySqlDataReader miLector = Comando.ExecuteReader();
                MessageBox.Show("La BD está ahora conectada!");
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        MessageBox.Show(miLector.GetString(1));
                        if (miLector.GetString(1) == txtNombre.Text)
                        {
                            usuarioOK = true;
                            // MessageBox.Show("Usuario validado");
                        }
                        if ((miLector.GetString(6) == txtClave.Text) && (usuarioOK))
                        {
                            claveOK = true;
                            //MessageBox.Show("Clave OK!! / Bienvenido!!");                            
                        }


                        // MessageBox.Show(miLector.GetString(0) + " - " + miLector.GetString(1) + " - " + miLector.GetString(2));
                        //Console.WriteLine(miLector.GetString(0) + " - " + miLector.GetString(1));
                    }
                    if (usuarioOK == true && claveOK == true)
                    {
                        MessageBox.Show("Puede Acceder");
                        //frmPpal Ppal = new frmPpal();
                       // Ppal.Show();
                    }
                    else
                    {
                        MessageBox.Show("No ultraje el sistema/ retírese!!");
                    }

                }


                Conex.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al conectar a la BD");
                //throw;
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
