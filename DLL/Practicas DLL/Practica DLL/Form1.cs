using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OperacionesAritmeticasArrays;
/// <summary>
/// 16 Marzo 2021
/// Juan Fernando Quiceno
/// Practica biblioteca de clases DLL
/// </summary>

namespace Matriz
{
    public partial class Frm_Matriz : Form
    {
        int[,] Matriz;
        int fila, columna;
        
        public Frm_Matriz()
        {
            InitializeComponent();
        }

        //Evento que para asignar valor a la varible fila y dar el valor maximo que queremos dejar para seleccionar
        private void Nud_Filas_ValueChanged(object sender, EventArgs e)
        {
            Nud_Filas.Maximum = 10;
            fila = (int)Nud_Filas.Value;
        }

        //Evento que para asignar valor a la varible columna y dar el valor maximo que queremos dejar para seleccionar
        private void Nud_Columnas_ValueChanged(object sender, EventArgs e)
        {
            Nud_Columnas.Maximum = 10;
            columna = (int)Nud_Columnas.Value;
        }

        private void btnPoblar_Click(object sender, EventArgs e)
        {  
            //condicion para evitar que caiga el programa si no se dimensiona matriz
            if (Nud_Filas.Value > 0 & Nud_Columnas.Value > 0)
            {
                Matriz = new int[fila, columna];//se inicializa el arreglo con los tamaños seleccionados 
                //deshabilitamos controles de seleccion para el tamaño de matriz
                Nud_Filas.Enabled = false;
                Nud_Columnas.Enabled = false;
                
                poblarMatriz(Matriz);
                imprimirDataGrid(dgvMostrarMatriz, Matriz, fila, columna);
            }
            else MessageBox.Show("Seleccione la capacidad para la matriz");
        }

        private void btnSumaFilas_Click(object sender, EventArgs e)
        {

            if (Nud_Filas.Value > 0 & Nud_Columnas.Value > 0)
            {   
                // se declara variable y se inicializa en true para que el metodo suma, opere en filas
                bool band = true;
                //metodo para imprimir en datagrid la suma de cada fila la cual se hace en metodo que pasamos por parametro
                imprimirDataGrid(dtgvSumaFilas, Operaciones.Suma(Matriz, band), fila, 1); 
            }
            else MessageBox.Show("Seleccione la capacidad para la matriz");

        }

        private void btnSumaColumnas_Click(object sender, EventArgs e)
        {
            if (Nud_Filas.Value > 0 & Nud_Columnas.Value > 0)

            {   // se declara variable y se inicializa en false para que el metodo suma, opere en columnas
                bool band = false;
                
                //metodo para imprimir en datagrid la suma de cada columna 
                imprimirDataGrid(dtgvSumaColumnas, Operaciones.Suma(Matriz, band), 1, columna); 
            }
            else MessageBox.Show("Seleccione la capacidad para la matriz");
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            if (Nud_Filas.Value > 0 & Nud_Columnas.Value > 0)
            {   
                //variable booleana como parametro para que el metodo busque mayor 
                bool band = true;
                //metodo de finmayMen perteneciente a biblioteca de referencia 
                lblMayor.Text = Operaciones.findMayMen(Matriz, band).ToString(); 
            }
            else MessageBox.Show("Seleccione la capacidad para la matriz");

        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            if (Nud_Filas.Value > 0 & Nud_Columnas.Value > 0)
            {
                //metodo de finmayMen perteneciente a biblioteca de referencia 
                bool band = false;
            lblMenor.Text = Operaciones.findMayMen(Matriz, band).ToString();
            }
            else MessageBox.Show("Seleccione la capacidad para la matriz");
        }

        public void poblarMatriz(int[,] array)
        {
            //metodo para poblar matriz automaticamente
            Random random = new Random();

            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    array[j, k] = random.Next(1, 30);//se limita el random con valores hasta nuestra eleccion
                }
            }

        }

        public void imprimirDataGrid(DataGridView dataGridView, int[,] array, int fila, int columna)
        {   
            // se dimensiona datagrid atravez de las variables por parametro
            dataGridView.ColumnCount = columna;
            dataGridView.RowCount = fila;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = array[i, j].ToString();
                }
            }

        }       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }











    }
}
