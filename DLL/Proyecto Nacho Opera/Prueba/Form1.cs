using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Multiplicacion;
using Resta;
using Suma;
using Division;


/// <summary>
/// 
/// Nombres: David Alejandro Ciro Ortiz
/// Jocelyn Mishel Perez Castro
/// Felipe Monsalve
/// Juan Fernando Quiceno Velasquez
/// 
/// Fecha: 9 de marzo de 2021
/// 
/// Nacho Opera: Este programa realiza operaciones con librerias (Suma, Resta, Multiplicación y División)
/// </summary>

namespace Prueba
{
    public partial class frmNacho : Form
    {
        public frmNacho()
        {
            InitializeComponent();

            tmrA.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            tmrA.Enabled = true;
            long numA;
            long numB;

            numA = long.Parse(txtNumeroA.Text);
            numB = long.Parse(txtNumeroB.Text);
            if (cmbSignos.Text == "+")
            { 
                long rta_sumas;
                rta_sumas = Suma.cls_suma.Suma(numA, numB);

                txtResultado.Text = Convert.ToString(rta_sumas);
            }
            else if (cmbSignos.Text == "-")
            {
                
                long rta_resta;
                rta_resta = Resta.Class1.Resta(numA, numB);
                txtResultado.Text = Convert.ToString(rta_resta);
            }
            else if (cmbSignos.Text == "*")
            {
                
                long rta_mult;
                rta_mult = Multiplicacion.Op_Multiplicacion.Multiplicar(numA, numB);
                txtResultado.Text = Convert.ToString(rta_mult);
            }
            else if (cmbSignos.Text == "/")
            {
                if(numB > 0)
                {

                    long rta_div;
                    rta_div = Division.Class1.div(numA, numB);
                    txtResultado.Text = Convert.ToString(rta_div);

                   
                }
                else
                {
                    MessageBox.Show("Opción no valida, ingrese un numero mayor a cero :) ");
                    txtNumeroB.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Opción no valida ");
            }
        }

        private void tmrA_Tick(object sender, EventArgs e)
        {
            txtNumeroA.Text = "";
            txtNumeroB.Text = "";
            txtResultado.Text = "";
        }
    }
}
