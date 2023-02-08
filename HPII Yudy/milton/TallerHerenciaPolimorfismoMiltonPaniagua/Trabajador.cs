using System;
using System.Collections.Generic;
using System.Text;

namespace TallerHerenciaPolimorfismoMiltonPaniagua
{
    //clase base trabajador 
    class Trabajador
    {
        //campos de clase
        int documento;
        string nombre;
        string apellido;
        string direccion;
        double salario;
        string jefe;

        //propiedad de campos
        public int Documento { get => documento; set => documento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Jefe { get => jefe; set => jefe = value; }

        //constructores
        public Trabajador(int documento, string nombre, string apellido, string direccion,double salario)
        {
            this.Documento = documento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Salario = salario;
        }

        public Trabajador()
        {
        }

        public Trabajador(int documento, string nombre, string apellido, string direccion)
        {
            this.documento = documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
        }

        public Trabajador(int documento, string nombre, string apellido, string direccion, double salario, string jefe) : this(documento, nombre, apellido, direccion, salario)
        {
            this.jefe = jefe;
        }


        //metodo virtual para tener la posibilidad de darle comportamientos deferentees desde clases derivadas
        public virtual void sueldo()
        {
            this.salario = salario;
        }

        //metodo que resive parametro 
        public void nombreJefe(string jefe)
        {
            this.jefe = jefe;
        }             

    }
}
