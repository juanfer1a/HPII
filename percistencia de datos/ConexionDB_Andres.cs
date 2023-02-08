using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bibliote_Master_Chief
{
    class ConexionDB
    {
        string conecxionSting;
  


        //Metodo para ejecutar las consultas en la DB
        public void conectarComando(string comando)
        {
            //Conectamos con el servidos
            conecxionSting = "server= localhost ; database= Biblioteca; integrated security=true";
            SqlConnection conexion = new SqlConnection(conecxionSting);

            //Abrimos la conexión con la DB
            conexion.Open();
            //Ejecutamos los comandos 
            SqlCommand cmd = new SqlCommand(comando, conexion);
            cmd.ExecuteNonQuery();
            //Cerramos la conexión con la DB
            conexion.Close();
        }

        //Metodo para mostrar los datos en un DatagridView
        public void MostrarTabla(string comando, DataGridView datagrid)
        {
            //Conectamos con el servidos
            conecxionSting = "server= localhost ; database= Biblioteca; integrated security=true";
            SqlConnection conexion = new SqlConnection(conecxionSting);

            SqlCommand cmd = new SqlCommand(comando, conexion);
            //Estamos tomando la conexión y la consultada de la variable "traer todo"
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            //Representación de una tabla en memoria 
            DataTable tabla = new DataTable();
            //llenamos tabla con los datos consigandos en la data 
            data.Fill(tabla);
            //Mostramos en el datagrid
            datagrid.DataSource = tabla;


        }
     
        /* //Metodo para abrir la base de datos
        public void OpenConection()
        {
            
            SqlConnection conexion = new SqlConnection(conecxionSting);
            conexion.Open();
            MessageBox.Show("Conexión Exitosa con la DB");
        }

        //Metodo para Cerrar la base de datos
        public void CloseConection()
        {
            SqlConnection conexion = new SqlConnection(conecxionSting);
            conexion.Close();
            MessageBox.Show("Se cerro la conexión con la DB");
        }
     */
    }
}
