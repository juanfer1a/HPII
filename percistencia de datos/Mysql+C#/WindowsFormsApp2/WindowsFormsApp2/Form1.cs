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


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static MySqlConnection Conex = new MySqlConnection();
        static string serv = "Server=localhost;";
        static string db = "Database=db_hexocoins;";
        static string usuario = "UID=root;";
        static string pwd = "Password =;";
        string CadenaDeConexion = serv + db + usuario + pwd;

       

        private void Form1_Load(object sender, EventArgs e)
        {
          //  string answer = Interaction.InputBox("Please enter the server address");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry = "select * from tbl_log";
             MySqlCommand Comando = new MySqlCommand(qry, Conex);
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();

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
                        Console.WriteLine(miLector.GetString(0) + " - " + miLector.GetString(1));
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
    }
}
