using System;
using System.Collections.Generic;
using System.Text;

namespace TallerHerenciaPolimorfismoMiltonPaniagua
{
    //clase derivada de clase base trabajador
    class TrabajadorFijo : Trabajador
    {
        //constructores

        public TrabajadorFijo()
        {
        }

        public TrabajadorFijo(int documento, string nombre, string apellido, string direccion, double salario) : base(documento, nombre, apellido, direccion, salario)
        {
        }

        public TrabajadorFijo(int documento, string nombre, string apellido, string direccion, double salario, string jefe) : base(documento, nombre, apellido, direccion, salario, jefe)
        {
        }

        //metodo sobreescrito de la clase base object para mostrar los datos 

        public override string ToString()
        {
            return $"Documento: {Documento}\nNombre: {Nombre}\nApellido: {Apellido}\nDireccion: {Direccion}\nSalario: {Salario}\n" +
                   $"Jefe: {Jefe}";
        }
    }

    class TrabajadorJefe : TrabajadorFijo
    {
        public TrabajadorJefe()
        {
        }

        public TrabajadorJefe(int documento, string nombre, string apellido, string direccion, double salario) : base(documento, nombre, apellido, direccion, salario)
        {
        }

        public override string ToString()
        {
            return $"Documento: {Documento}\nNombre: {Nombre}\nApellido: {Apellido}\nDireccion: {Direccion}\nSalario: {Salario}\n";
        }

    }


    //clase derivada de clase base trabajador
    class Comisiones :Trabajador
    {
        //atributos 
        double ventas;
        double porcentaje;
        
        //propiedades de campos
        public double Ventas { get => ventas; set => ventas = value; }
        public double Porcentaje { get => porcentaje; set => porcentaje = value; }

        //constructores
        public Comisiones()
        {
        }
        public Comisiones(double ventas, double porcentaje)
        {
            this.ventas = ventas;
            this.porcentaje = porcentaje/100;
        }


        public Comisiones(int documento, string nombre, string apellido, string direccion, double salario, string jefe) : base(documento, nombre, apellido, direccion, salario, jefe)
        {
        }

        //sobreescritura de metodo heredado de clase base
        public override void sueldo()
        {
               
            Salario = ventas * porcentaje;
        }


        //sebreescritura de metodo string de super clase objet
        public override string ToString()
        {
            return $"Documento: {Documento}\nNombre: {Nombre}\nApellido: {Apellido}\nDireccion: {Direccion}\nSalario: {Salario}\nJefe: {Jefe}";
        }


    }


    //clase derivada de clase base trabajador
    class TrabajadorXhoras : Trabajador
    {
        //atributos
        double cantHoras;
        double valorHoraOrdinaria;
        double valorHoraExtra;

        //constructores
        public TrabajadorXhoras()
        {
        }

        public TrabajadorXhoras(double cantHoras, double valorHoraOrdinaria, double valorHoraExtra)
        {
            this.cantHoras = cantHoras;
            this.valorHoraOrdinaria = valorHoraOrdinaria;
            this.valorHoraExtra = valorHoraExtra;
        }

        public TrabajadorXhoras(int documento, string nombre, string apellido, string direccion, double salario, string jefe) : base(documento, nombre, apellido, direccion, salario, jefe)
        {
        }

        public double CantHoras { get => cantHoras; set => cantHoras = value; }
        public double ValorHoraOrdinaria { get => valorHoraOrdinaria; set => valorHoraOrdinaria = value; }
        public double ValorHoraExtra { get => valorHoraExtra; set => valorHoraExtra = value; }


        //metodo sobre escrito heredado la clase base
        public override void sueldo()
        {
            if (CantHoras <= 40)
            {
                Salario = CantHoras * valorHoraOrdinaria;
            }
            if(cantHoras > 40)
            {   
                Salario = valorHoraOrdinaria * 40;
                Salario += (cantHoras - 40) * valorHoraExtra; 
            }
        }

        //metodo sobreescrito de super clase object
        public override string ToString()
        {
            return $"Documento: {Documento}\nNombre: {Nombre}\nApellido: {Apellido}\nDireccion: {Direccion}\nSalario: {Salario}\nJefe: {Jefe}";
        }
    }

   
}

