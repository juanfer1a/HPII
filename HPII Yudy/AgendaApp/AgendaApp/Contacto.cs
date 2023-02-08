using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp
{
    class Contacto
    {
        string nombre;
        string apellido;
        int documento;
        string direccion;
        string email;
        int telefono;
        int idProfesion;
        string profesion;

        public Contacto()
        {

        }
        public Contacto(string nombre, string apellido, int documento, string direccion, 
            string email, int telefono, int idProfesion, string profesion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
            this.direccion = direccion;
            this.email = email;
            this.telefono = telefono;
            this.idProfesion = idProfesion;
            this.profesion = profesion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Documento { get => documento; set => documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int IdProfesion { get => idProfesion; set => idProfesion = value; }
        public string Profesion { get => profesion; set => profesion = value; }
    }
}
