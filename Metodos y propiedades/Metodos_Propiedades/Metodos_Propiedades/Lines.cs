using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Propiedades
{
    class Lines
    {
        private int x;  //  variable para la coordenada en x
        private int y; // variable para la coordenada en y

        private static int contar = 0; // Variable estática para contar la cantidad de lineas

        // método para construir un objeto sin parámetros
        public Lines()
        {  
            x = 0; // por defecto estos son los valores de x,y si no se mandan como parámetro
            y = 0;
        }

        // método para construir un objeto con parámetros
        public Lines(int x, int y) //Se mandan los valore de x,y
        {
            this.x = x;
            this.y = y;

        }
        //Aquí observamos la sobrecarga de métodos, por que se pueden mandar valores de tipo
        // double también.
        public Lines(double x, double y)
        {
            // En las siguientes instrucciones se hace una conversión e double a entero
            this.x = (int)x;
            this.y = (int)y;
        }

        public int GetX()
        {   // método que te dá el valor de la coordenada x
            return x;
        }


        public int GetY()
        {   // método que te dá el valor de la coordenada y
            return y;
        }
        // método que sirve para cambiar el valor //de la coordenada x
        public void SetX(int x)
        {
            this.x = x;   // this se utiliza porque se esta utilizando (x)         
            // como parámetro y como 
            // variable de instancia y esto es para que no se confunda
        }
        // método que te sirve para cambiar el valor de la  coordenada y
        public void SetY(int y)
        {
            this.y = y;  // this se utiliza porque se esta utilizando (y)  
            //como parámetro y como 
            // variable de instancia y esto es para que no se confunda Java
        }
        // Método estático, es un método a nivel de clase que se puede invocar a través
        // de ella.
        public static int Contar()
        {
            contar += 1;
            return contar;
        }
    }
}
