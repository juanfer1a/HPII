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
/// 18 feb 2021
/// Julian Galeano
/// Recorridos en Arreglos
/// </summary>

namespace Arreglos
{


public partial class frmArreglos : Form
    {
        int[] vector = new int[4];
        //int[,] matriz = new int[2, 2];
        //private int[,] mat;
        int fila, columna, pos = 0; //inicialización
       

        public frmArreglos()
        {
            InitializeComponent();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {


            // ¿Cómo disparar un segmento de código con la tecla Enter?
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                asignar();  //llamar el metodo
                txtNum.Text = "";
            }

            //Mecanismos de validación de datos / evitar que el usuario ingrese basura!!

            //if (char.IsLetter(e.KeyChar))
            //{
            //   e.Handled = true;
            //}
        }

        private void Nud_X_Click(object sender, EventArgs e)
        {
            if (Nud_X.Value >3)
            {
                Nud_X.Value = 3;
             //   MessageBox.Show("Sobrepasa el valor del arreglo");
            }

        }
        /// <summary>
        /// ¿Existen mecanismos para escribir el código de una manera más sencilla en la herramienta que uso?
        ///  Operadores ternarios: 
        ///  string classify;
        ///  El siguiente código:
        ////if (input >= 0)
        ////{
        ////    classify = "nonnegative";
        ////}
        ////else
        ////{
        ////    classify = "negative";
        ////}
        /// es igual a esto:
        /// classify = (input >= 0) ? "nonnegative" : "negative";
        /// </summary>




        private void btnAsignar_Click(object sender, EventArgs e)
        {
            asignar(); //llamar el metodo
        }

        void asignar()
        {
            if (pos < vector.Length)
            {
                vector[pos] = Convert.ToInt32(txtNum.Text);
                pos++;                
            }
            else
            {
                string elementos;
                elementos = string.Join(",", vector);
                MessageBox.Show("Arreglo lleno! " + elementos);

            }
        }
    }
}
  

