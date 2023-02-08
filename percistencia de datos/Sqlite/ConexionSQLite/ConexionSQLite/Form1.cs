using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;


namespace ConexionSQLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConexion_Click(object sender, EventArgs e)
        {


            //Utilizamos estos tres objetos de SQLite
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            SQLiteDataReader datareader_sqlite;

            //Crear una nueva conexión de la base de datos
            conexion_sqlite = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            
            //Abriremos la conexión
            conexion_sqlite.Open();

            //Creando el comando SQL
            cmd_sqlite = conexion_sqlite.CreateCommand();

            //El objeto SQLiteCommando va a conocer la consulta de SQL
            cmd_sqlite.CommandText = "CREATE TABLE demo(id integer primary key, texto varchar(100));";

            //Ejecutaremos la consulta que hemos creado
            cmd_sqlite.ExecuteNonQuery();

            //Insertando datos en la tabla
            cmd_sqlite.CommandText = "INSERT INTO demo(id, texto) VALUES (1, 'Este es el primer texto');";
            cmd_sqlite.ExecuteNonQuery();

            cmd_sqlite.CommandText = "INSERT INTO demo(id, texto) VALUES (2, 'Este es el segundo texto');";

            //Ejecutamos nuevamente la consulta
            cmd_sqlite.ExecuteNonQuery();

            cmd_sqlite.CommandText = "SELECT texto FROM demo";

            datareader_sqlite = cmd_sqlite.ExecuteReader();

            while (datareader_sqlite.Read())
            {
                //Mostrando los datos
                string lectura = datareader_sqlite.GetString(0);
                MessageBox.Show(lectura);
            
            }


            conexion_sqlite.Close();





        }



    }
}
