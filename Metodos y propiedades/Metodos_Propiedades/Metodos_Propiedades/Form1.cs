using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Propiedades
{
    /// <summary>
    /// Solucion al taller metodos y propiedades cuenta con dos proyectos "mostrar linea" y "tienda de ropa"
    /// realizado por: Juan Fernando Quiceno
    /// Asignatura: HP II 
    /// Profesor: Julian Galeano
    /// </summary>
    public partial class FrmLineas : Form
    {

        Graphics grafico;
        //se crea instancia de pen que da el color y el grueso de la linea
        Pen pen = new Pen(Color.Red, 3);

        public FrmLineas()
        {
            InitializeComponent();
            grafico = CreateGraphics();

            //Inicializamos los combobox  
            for (int i = 5; i <= 383; i++)
            {
                cxbXinicial.Items.Add(i.ToString());

                cxbXFinal.Items.Add(i.ToString());

            }
            for (int i = 195; i <= 535; i++)
            {
                cxbYInicial.Items.Add(i.ToString());

                cxbYFinal.Items.Add(i.ToString());

            }

        }

        private void btnDibujarLinea_Click(object sender, EventArgs e)
        {
            try
            {
                // se ingresan los valores de x, y que son los puntos donde se
                // mostrará el rectángulo
                double x = double.Parse(cxbXinicial.Text);
                double y = double.Parse(cxbYInicial.Text);

                //Se crea una instancia o un objeto de la clase Lines

                Lines lines = new Lines(x, y);




                grafico.DrawLine(pen, lines.GetX(), lines.GetY(), int.Parse(cxbXFinal.Text), int.Parse(cxbYFinal.Text));
                // grafico.DrawLine recibe los parametros para mostrar la linea en al posicion y con color y tamaño
                //de trazo


                // contar es un metodo de la clase linea donde se obtiene ese valor el cual es estatico 
                // y para instanciarlo se hace con la clase
                txtCantidad.Text = Convert.ToString(Lines.Contar());
            }
            catch
            {
                MessageBox.Show("Elija valores para cada item");

            }
        }


    }
}
