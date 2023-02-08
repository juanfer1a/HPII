using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_1;
using NumeroMayorMatriz;
using MenorElemento;
using operacionSuma;

namespace AplicacionIntegrada
{
    /// <summary>
    /// 
    /// Nombres: ¬
    /// David Alejandro Ciro Ortiz
    /// Jocelyn Mishel Perez Castro
    /// Felipe Monsalve
    /// Juan Fernando Quiceno Velasquez
    /// 
    /// Fecha: 19 de marzo de 2021
    /// 
    /// Nacho Opera: Este programa realiza las siguientes operaciones con librerias :
    /// (Suma filas de una matriz, suma columnas de una matriz, identifica el numero mayor de la matriz e identifica el numero menor de la matriz)
    /// </summary>
    public partial class frmArregloMatriz : Form
    {
        Random rnd = new Random();
        int[,] matriz = null;
        int filas;
        int columnas;
        public frmArregloMatriz()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            lblMAleatoria.Text = "";
            if (txtFilas.Text != "" && txtColumnas.Text != "")
            {
                //Declaración de variables
                filas = int.Parse(txtFilas.Text);
                columnas = int.Parse(txtColumnas.Text);
                matriz = new int[filas, columnas];

                //Se llena la matriz aleatoria
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matriz[i, j] = rnd.Next(20);
                    }
                }

                //Se muestra la matriz aleatoria
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        lblMAleatoria.Text += "[ " + matriz[i, j] + " ]  ".ToString();
                    }
                    lblMAleatoria.Text += "\n";
                }

            txtColumnas.Text = "";
            txtFilas.Text = "";
            }
            else { MessageBox.Show("Debe definir valores para dimensionar la matriz"); };



        }

        private void btnPunto1_Click(object sender, EventArgs e)
        {
            if (matriz != null)
            {
                //Se llama la librería
                int[,] sumasfilas = new int[filas, 1];
                sumasfilas = PUNTO_1.Class1.Primero(matriz);

                //Se muestra el resultado
                for (int i = 0; i < sumasfilas.GetLength(0); i++)
                {
                    for (int j = 0; j < sumasfilas.GetLength(1); j++)
                    {
                        lblPunto1.Text += "[ " + sumasfilas[i, j] + " ]  ".ToString();
                    }
                } 
            }
            else { MessageBox.Show("Debe definir valores para dimensionar la matriz"); };
        }

        private void btnPunto2_Click(object sender, EventArgs e)
        {
            if (matriz != null)
            {
                //Se llama la librería
                int[,] sumarcolumnas = new int[1, columnas];
                sumarcolumnas = operacionSuma.Columnas.Suma(matriz);

                //Se muestra el resultado
                for (int i = 0; i < sumarcolumnas.GetLength(1); i++)
                {
                    for (int j = 0; j < sumarcolumnas.GetLength(0); j++)
                    {
                        lblPunto2.Text += "[ " + sumarcolumnas[j, i] + "]  ".ToString();
                    }
                } 
            }
            else { MessageBox.Show("Debe definir valores para dimensionar la matriz"); };
        }

        private void btnPunto3_Click(object sender, EventArgs e)
        {
            if (matriz != null)
            {
                //Se llama la librería
                int mayor;
                mayor = NumeroMayorMatriz.NumMayor.Mayor(matriz);

                //Se muestra el resultado
                lblPunto3.Text = mayor.ToString(); 
            }
            else { MessageBox.Show("Debe definir valores para dimensionar la matriz"); };
        }

        private void btnPunto4_Click(object sender, EventArgs e)
        {
            if (matriz != null)
            {

                //Se llama la librería
                int menor;
                menor = MenorElemento.NumMenor.DatoMenor(matriz);

                //Se muestra el resultado
                lblPunto4.Text = menor.ToString(); 
            }
              else { MessageBox.Show("Debe definir valores para dimensionar la matriz"); };
        }
    }
}
