using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 1 marzo 2021
/// Juan Quiceno 
/// Practica Arreglos
/// 1. Realiza llenado de  una matriz, y posteriormente despliegue los elementos de ese arreglo bidimensional.
/// 2. Ordena los elementos de un arreglo bidimensional de forma ascendente por columna 
/// 3. Ordena los elementos de un arreglo unidimensional de forma ascendente  
/// </summary>

namespace HPII_PracticaArreglos
{
    public partial class frmArreglos : Form
    {
        int[] vector = new int[9];
        int[] vectorMatriz;
        int[,] matriz = new int[3, 3];
        int pos, posX, posY = 0;

        public frmArreglos()
        {
            InitializeComponent();

        }

        //Evento click que asigna el valor ingresado en la matirz
        private void btnAsignarMatriz_Click(object sender, EventArgs e)
        {
            //condicion para controlar el llenado de la matriz sin exceder sus indices y enviar un mensaje al llenar
            
            if (posX < matriz.GetLength(1))
            {
                asignarMatriz();
                txtNum.Text = null;
            }
            else
            {
                txtNum.Text = null;
                MessageBox.Show("Matriz llena");
            }

        }

        //evento keypress de textbox 
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para asignar el valor ingresado en la caja al apretar la tecla enter y enviar mensaje al lleanar


            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (posX < matriz.GetLength(1))
                {
                    asignarMatriz();
                    txtNum.Text = null;
                }
                else
                {
                    txtNum.Text = null;
                    MessageBox.Show("Matriz llena");

                }
            }

            //condicion que anula el llenado con letras 
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Matriz de datos numericos");
            }



            Focus();
        }


        //evento de buttton que imprime matriz en label 
        private void btnImprimirMatriz_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = null;
            imprimir(lblMostrar, matriz);
        }

        //evento click para imprimir la matriz ordenada ascendente por columnas
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lblOrdenar.Text = null;
            ordenar();
            imprimir(lblOrdenar, matriz);

        }


        //evento click de boton para asignar valor a vector
        private void btnAsignarVector_Click(object sender, EventArgs e)
        {

            if (pos < vector.Length)
            {
                asignarVector();
                txtNumVector.Text = null;
            }
            else
            {
                txtNumVector.Text = null;
                MessageBox.Show("Vector lleno");

            }



        }

        //evento keypress que asigna valor al vector con la tecla enter
        private void txtNumVector_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (pos < vector.Length)
                {
                    asignarVector();
                    txtNumVector.Text = null;
                }
                else
                {
                    txtNumVector.Text = null;
                    MessageBox.Show("Vector lleno");

                }
            }


        }

        //evento click de boton para asignar valor a vector
        private void btnImprimirVector_Click(object sender, EventArgs e)
        {
            lblMostrarVector.Text = null;
            string datos = string.Join(",", vector);
            lblMostrarVector.Text += datos;
        }

        //evento click que asigna valor a vector por medio del boton
        private void btnOrdeVector_Click(object sender, EventArgs e)
        {
            Array.Sort(vector);
            string datos = string.Join(",", vector);
            lblOrdenVector.Text += datos;
        }

        //metodo que asigna los valores en matriz y muestra la posicion a la que fue asignado
        public void asignarMatriz()
        {
            if (posX < matriz.GetLength(0))
            {
                matriz[posX, posY] = Convert.ToInt32(txtNum.Text);
                MessageBox.Show($"Dato asignado a la posicion {posX},{posY}");
                posY++;

                if (posY == matriz.GetLength(0))
                {
                    posY = 0;
                    posX++;
                }
            }


        }

        //metodo para imprimir matriz 
        public void imprimir(Label label, Array array)
        {
            //se recorre la matriz con foreach para su impresion 
            int cont = 0;
            foreach (int i in array)
            {
                label.Text += $"[{i}]";
                cont++;
                //condicion que para evaluar final de fila y hacer salto de linea en label para imprimir organizadamente la matriz
                if (cont == matriz.GetLength(1))
                {
                    label.Text += "\n";
                    cont = 0;
                }
            }

        }

        //metodo ordenar matriz
        public void ordenar()
        {
            int cont1 = 0;

            do
            {   //se iniciliza vector 
                vectorMatriz = new int[matriz.GetLength(1)];

                //int aux;

                //estructura que pasa los valores de cada columna a vector para su posterior ordenamiento 
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    vectorMatriz[i] = matriz[i, cont1];

                }

                //estructura que compara cada valor del vectorMatriz y lo ordenada ascendentemente
                Array.Sort(vectorMatriz);

                //lo habia implemenado de la siguiente manera y funciona, pero descubri el metodo  Array.Sort(), quise probarlo
                //for (int j = 0; j < vectorMatriz.Length; j++)
                //{
                //    for (int k = 0; k < vectorMatriz.Length - 1; k++)
                //    {
                //        if (vectorMatriz[k].CompareTo(vectorMatriz[k + 1]) > 0)
                //        {
                //            aux = vectorMatriz[k];
                //            vectorMatriz[k] = vectorMatriz[k + 1];
                //            vectorMatriz[k + 1] = aux;

                //        }
                //    }
                //}

                //estructura para llevar valores ordenados de nuevo a la columna correspondiente de la matriz 
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    matriz[i, cont1] = vectorMatriz[i];

                }
                cont1++;

            } while (cont1 != matriz.GetLength(1));

        }

        //asignar valor a vector
        public void asignarVector()
        {
            if (pos < vector.Length)
            {
                vector[pos] = Convert.ToInt32(txtNumVector.Text);
                MessageBox.Show($"Dato asignado a la posicion {pos}");
                pos++;

            }
        }

        //evento click de boton para cerrar el programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }








    }
}

