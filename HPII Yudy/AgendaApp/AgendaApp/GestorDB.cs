using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AgendaApp
{
    class GestorDB
    {
        string strConexion = ConfigurationManager.ConnectionStrings["strCon"].ToString();
        SqlConnection connection;
        SqlCommand command;
        string mensaje = "";
        SqlDataReader reader;
          
        public GestorDB()
        {

        }
        private void Conectar()
        {
            try
            {
                connection = new SqlConnection(strConexion);
                connection.Open();
            }catch(SqlException ex)
            {
                mensaje = "Se presentó un error por: " + ex.Message;
            }
        }
        public List<string> ListarProfesiones()
        {
            List<string> Profesiones = new List<string>();
            Conectar();
            try
            {
                string query = "SELECT * FROM tblProfesion";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    Profesiones.Add(reader.GetString(1));
                }
            }
            catch(SqlException ex)
            {
                mensaje = "Se presentó un error por: " + ex.Message;
            }
            connection.Close();
            return Profesiones;
        }

        public bool ContactoExiste(int documento)
        {
            bool Existe = false;
            Conectar();
            try
            {
                string query = "SELECT * FROM tblContactos WHERE documento= "+documento;
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Existe = true;
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Se presentó un error por: " + ex.Message;
            }
            connection.Close();
            return Existe;

        }

        public Contacto BuscarContacto(int documento)
        {
            Contacto contacto = null;
            Conectar();
            try
            {
                string query = "SELECT * FROM tblContactos inner join " +
                    "tblProfesion on tblContactos.idProfesion = tblProfesion.idProfesion" +
                    " WHERE documento = " + documento;
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacto = new Contacto();
                    contacto.Documento = reader.GetInt32(0);
                    contacto.Nombre = reader.GetString(1);
                    contacto.Apellido = reader.GetString(2);
                    contacto.Email = reader.GetString(3);
                    contacto.Telefono = reader.GetInt32(4);
                    contacto.IdProfesion = reader.GetInt32(5);
                    contacto.Direccion= reader.GetString(6);
                    contacto.Profesion = reader.GetString(8);

                }
            }
            catch (Exception ex)
            {
                mensaje = "Se presentó un error por: " + ex.Message;
            }
           
            connection.Close();
            return contacto;

        }

        public List<Contacto> ListarContactos()
        {
            List<Contacto> contactos = new List<Contacto>();
            Conectar();
            try
            {
                string query = "SELECT * FROM tblContactos inner join " +
                    "tblProfesion on tblContactos.idProfesion = tblProfesion.idProfesion";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Contacto contacto = new Contacto();
                    contacto.Documento = reader.GetInt32(0);
                    contacto.Nombre = reader.GetString(1);
                    contacto.Apellido = reader.GetString(2);
                    contacto.Email = reader.GetString(3);
                    contacto.Telefono = reader.GetInt32(4);
                    contacto.IdProfesion = reader.GetInt32(5);
                    contacto.Direccion = reader.GetString(6);
                    contacto.Profesion = reader.GetString(8);
                    contactos.Add(contacto);

                }
            }
            catch (Exception ex)
            {
                mensaje = "Se presentó un error por: " + ex.Message;
            }

            connection.Close();
            return contactos;

        }
        public int Guardarcontacto(Contacto contacto)
        {
            int respuesta = 0;
            Conectar();
            try
            {
                string query = "INSERT INTO tblContactos(documento, nombre, apellido, email, telefono, idProfesion,direccion)" +
                    "VALUES(@doc, @nombre,@Apellido,@mail,@tel,@idProf, @dir)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@doc", contacto.Documento);
                command.Parameters.AddWithValue("@nombre", contacto.Nombre);
                command.Parameters.AddWithValue("@Apellido", contacto.Apellido);
                command.Parameters.AddWithValue("@mail", contacto.Email);
                command.Parameters.AddWithValue("@tel", contacto.Telefono);
                command.Parameters.AddWithValue("@idProf", contacto.IdProfesion);
                command.Parameters.AddWithValue("@dir", contacto.Direccion);
                respuesta = command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                mensaje = "Se presentó un error por: " + ex.Message;
            }
            connection.Close();
            return respuesta;
        }
        public int Actualizarcontacto(Contacto contacto)
        {
            int respuesta = 0;
            Conectar();
            try
            {
                string query = "UPDATE tblContactos SET nombre = @nombre, apellido = @Apellido," +
                    "email =@mail,telefono = @tel,idProfesion = @idProf," +
                    "direccion = @dir where documento = @doc";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@doc", contacto.Documento);
                command.Parameters.AddWithValue("@nombre", contacto.Nombre);
                command.Parameters.AddWithValue("@Apellido", contacto.Apellido);
                command.Parameters.AddWithValue("@mail", contacto.Email);
                command.Parameters.AddWithValue("@tel", contacto.Telefono);
                command.Parameters.AddWithValue("@idProf", contacto.IdProfesion);
                command.Parameters.AddWithValue("@dir", contacto.Direccion);
                respuesta = command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                mensaje = "Se presentó un error por: " + ex.Message;
            }
            connection.Close();
            return respuesta;
        }
        public override string ToString()
        {
            return mensaje;
        }
        public int EliminarContacto(int documento)
        {
            int respuesta = 0;
            Conectar();
            try{
                string query = "DELETE FROM tblContactos WHERE documento = " + documento;
                command = new SqlCommand(query, connection);
                respuesta = command.ExecuteNonQuery();
                }
            catch (SqlException ex)
            {
                mensaje = "Se presentó un error por: " + ex.Message;
            }
            connection.Close();
            return respuesta;
        }

    }
}
