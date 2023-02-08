using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ConexionDB
{
    class conexion
    {
        string connexionString;
        DataTable dataTable = new DataTable();
        MySqlConnection connection;

        public conexion()
        {
        }

        public string ConnexionString { get => connexionString; set => connexionString = value; }
        public DataTable DataTable { get => dataTable; set => dataTable = value; }
        public MySqlConnection Connection { get => connection; set => connection = value; }

        //metodo para conectar con gestor base de datos mySql, recive dos metodos: el comando y el nombre de la base de datos 
        public void crudMySql(string comando, string db)
        {
            this.connexionString = $"server= localhost ; database={db};UID=root;Password =;";
            Connection = new MySqlConnection(connexionString);
            MySqlCommand command = new MySqlCommand(comando, Connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            Connection.ConnectionString = connexionString;
            Connection.Open();
            dataAdapter.Fill(dataTable);
        }


        //public void crudSqlServer(string comando, string db)
        //{
        //    //Conectamos con el servidor
        //    this.connexionString = $"server= localhost ; database={db}; integrated security=true";
        //    SqlConnection conexion = new SqlConnection(connexionString);
        //    conexion.Open();

        //    SqlCommand cmd = new SqlCommand(comando, conexion);

        //    //Estamos tomando la conexión y la consultada de la variable "traer todo"
        //    SqlDataAdapter data = new SqlDataAdapter(cmd);

        //    //Representación de una tabla en memoria 
        //    DataTable = new DataTable();

        //    //Poblamos tabla con los datos consignados en la data 
        //    data.Fill(DataTable);
        //}
    }
}
