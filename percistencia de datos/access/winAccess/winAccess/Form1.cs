using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;  //Framework de conexión con MS-Access y otros Motores DB

namespace winAccess
{
    public partial class Form1 : Form
    {
        //Instanciar conexión
        OleDbConnection conexion = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckConn_Click(object sender, EventArgs e)
        {     
       //Cadena de conexión
        conexion.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source= D:\clientes.accdb;
        Persist Security Info = False;";

            //Captura de Errores!
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión con MS-Access - OK!");
                conexion.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar conectar!!");
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM  cliente";
                OleDbDataReader reader = comando.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    MessageBox.Show(reader[0].ToString() + "-" + reader[1].ToString() + "-" + reader[2].ToString() + "-" + reader[3].ToString());
                    count++;
                    txtId.Text = reader[0].ToString();
                    txtNom.Text = reader[1].ToString();
                    txtUser.Text = reader[2].ToString();
                    txtPass.Text = reader[3].ToString();
                    txtRol.Text = reader[4].ToString();
                }
                //Cerrar conexión
                conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Error al consultar DB");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO cliente (id,Nombre, usuario,clave,rol) values('" + txtId.Text + "','" + txtNom.Text + "','" + txtUser.Text + "','" + txtPass.Text + "','" + txtRol.Text + "')";
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ConsultaRol";
                OleDbDataReader reader = comando.ExecuteReader();
                //Recorrer del DataReader(matriz) con los datos devueltos por el motor(MS-Access) al frontend(VC#)
                int count = 0;
                while (reader.Read())
                {                    
                    count++;
                    txtNom.Text = reader[0].ToString();
                    txtPass.Text = reader[1].ToString();
                    txtRol.Text = reader[2].ToString();
                 
                }
                //Cerrar conexión
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error al consultar DB");
            }
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }
    }
}
