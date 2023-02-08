using System;

namespace TallerHerenciaPolimorfismoMiltonPaniagua
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //arreglo de tipo trabajador
            Trabajador[] empleados = new Trabajador[20];
            //atributos
            int cont = 0;
            bool band = false;           
           
           //menu para dar las diferentes opciones al usuario
            int op = 1;
            while (op != 0)
            {
                Console.WriteLine("**************** Empleados*************");
                Console.WriteLine("\n¿Qué tipo de accion desea realizar");
                Console.WriteLine("1. Crear Trabajador fijo");
                Console.WriteLine("2. Crear Jefe");
                Console.WriteLine("3. Crear Trabajador x horas");
                Console.WriteLine("4. Crear Trabajador x comisiones");
                Console.WriteLine("5. Ver lista de trabajadores");
                Console.WriteLine("6. Ver nomina total");
                Console.WriteLine("0. Salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1://trabajador fijo
                        {

                            Console.Clear();
                            Console.WriteLine("**********Trabajador fijo****************");
                            Console.WriteLine("Ingrese el documento del trabajador");
                            int documento = int.Parse(Console.ReadLine());
                            //ciclo para evaluar si el trabajador ya a sido incresado con anterioridad
                            for (int i = 0; i < cont; i++)
                            {
                                if (documento == empleados[i].Documento)
                                {
                                    //si el documento es encontrado dentro del arreglo la bandera cambia a true 
                                    band = true;
                                }
                            }
                            Console.Clear();
                            if (band == false)
                            {
                                Console.WriteLine("Ingrese el nombre");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el apellido");
                                string apellido = Console.ReadLine();
                                Console.WriteLine("Ingrese el direccion");
                                string direccion = Console.ReadLine();
                                Console.WriteLine("Ingrese el salario ");
                                int salario = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el nombre del jefe inmediato");
                                string jefe = Console.ReadLine();
                                empleados[cont] = new TrabajadorFijo(documento, nombre, apellido, direccion, salario, jefe);
                                Console.WriteLine("*************Trabajador fijo creado*****************");
                                Console.WriteLine(empleados[cont].ToString());
                                Console.ReadKey();
                                cont++;
                            }
                            else
                            {
                                band = false;
                                Console.Clear();
                                Console.WriteLine("El trabajador ya a sido creado");
                                Console.ReadKey();
                            }


                        }

                        break;

                    case 2://trabajador jefe
                        {
                            Console.Clear();
                            Console.WriteLine("**********Trabajador Jefe****************");
                            Console.WriteLine("Ingrese el documento del trabajador");
                            int documento = int.Parse(Console.ReadLine());
                            for (int i = 0; i < cont; i++)
                            {
                                if (documento == empleados[i].Documento)
                                {
                                    band = true;
                                }
                            }
                            Console.Clear();
                            if (band == false)
                            {
                                Console.WriteLine("Ingrese el nombre");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el apellido");
                                string apellido = Console.ReadLine();
                                Console.WriteLine("Ingrese la direccion");
                                string direccion = Console.ReadLine();
                                Console.WriteLine("Ingrese el salario ");
                                int salario = int.Parse(Console.ReadLine());
                                empleados[cont] = new TrabajadorFijo(documento, nombre, apellido, direccion, salario);
                                Console.Clear();
                                Console.WriteLine("*************Trabajador jefe creado*****************");
                                Console.WriteLine(empleados[cont].ToString());
                                Console.ReadKey();
                                cont++;
                            }
                            else
                            {
                                band = false;
                                Console.Clear();
                                Console.WriteLine("El trabajador ya a sido creado");
                                Console.ReadKey();
                            }

                        }

                        break;

                    case 3://trabajdaro x horas
                        {
                            Console.Clear();
                            Console.WriteLine("**********Trabajador x horas****************");
                            Console.WriteLine("Ingrese el documento del trabajador");
                            int documento = int.Parse(Console.ReadLine());
                            for (int i = 0; i < cont; i++)
                            {
                                if (documento == empleados[i].Documento)
                                {
                                    band = true;
                                }
                            }
                            Console.Clear();
                            if (band == false)
                            {
                                Console.WriteLine("Ingrese el nombre");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el apellido");
                                string apellido = Console.ReadLine();
                                Console.WriteLine("Ingrese la direccion");
                                string direccion = Console.ReadLine();
                                Console.WriteLine("Ingrese la cantidad de horas trabajadas al mes ");
                                double horas = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el valor para la hora ordinaria ");
                                double vHoraOr = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el valor para las horas extraordinarias ");
                                double vHoraExtra = double.Parse(Console.ReadLine());
                                TrabajadorXhoras TxH = new TrabajadorXhoras(horas, vHoraOr, vHoraExtra);
                                TxH.sueldo();
                                Console.WriteLine("Ingrese el nombre del jefe inmediato");
                                string jefe = Console.ReadLine();
                                empleados[cont] = new TrabajadorFijo(documento, nombre, apellido, direccion, TxH.Salario, jefe);
                                Console.Clear();
                                Console.WriteLine("*************Trabajador x horas creado*****************");
                                Console.WriteLine(empleados[cont].ToString());
                                Console.ReadKey();
                                cont++;
                            }
                            else
                            {
                                band = false;
                                Console.Clear();
                                Console.WriteLine("El trabajador ya a sido creado");
                                Console.ReadKey();
                            }

                        }

                        break;

                    case 4://trabajador comisionista
                        {
                            Console.Clear();
                            Console.WriteLine("**********Trabajador comisionista****************");
                            Console.WriteLine("Ingrese el documento del trabajador");
                            int documento = int.Parse(Console.ReadLine());
                            for (int i = 0; i < cont; i++)
                            {
                                if (documento == empleados[i].Documento)
                                {
                                    band = true;
                                }
                            }
                            Console.Clear();
                            if (band == false)
                            {
                                Console.WriteLine("Ingrese el nombre");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el apellido");
                                string apellido = Console.ReadLine();
                                Console.WriteLine("Ingrese la direccion");
                                string direccion = Console.ReadLine();
                                Console.WriteLine("Ingrese las ventas generadas en el mes ");
                                double ventas = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el porcentaje para calcular comision ");
                                double porcentaje = double.Parse(Console.ReadLine());
                                Comisiones comisionista = new Comisiones(ventas, porcentaje);
                                comisionista.sueldo();
                                Console.WriteLine("Ingrese el nombre del jefe inmediato");
                                string jefe = Console.ReadLine();
                                empleados[cont] = new TrabajadorFijo(documento, nombre, apellido, direccion, comisionista.Salario, jefe);
                                Console.Clear();
                                Console.WriteLine("***********Trabajador comisionista creado***************");
                                Console.WriteLine(empleados[cont].ToString());
                                Console.ReadKey();
                                cont++;
                            }
                            else
                            {
                                band = false;
                                Console.Clear();
                                Console.WriteLine("El trabajador ya a sido creado");
                                Console.ReadKey();
                            }

                        }

                        break;

                    case 5://mosrar los datos de todos los trabajadores incresados
                        {
                            Console.Clear();
                            if (cont >= 1)
                            {
                                for (int i = 0; i < cont; i++)
                                {
                                    Console.WriteLine("*********************************");
                                    Console.WriteLine(empleados[i].ToString());
                                }
                            }
                            else Console.WriteLine("Aun no a ingresado datos de ningun trabajador");

                            Console.ReadKey();
                        }
                        break;

                    case 6://sacar el total de la nomina 
                        {
                            Console.Clear();
                            double nomina = 0;
                            for (int i = 0; i < cont; i++)
                            {
                                //recorremos el arreglo y sumamos los valores de los salarios
                                nomina += empleados[i].Salario;
                            }
                            Console.WriteLine("****************Nomina Total*****************");
                            Console.WriteLine(nomina);
                            Console.ReadKey();
                        }
                        break;
                }

            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

    }

}


