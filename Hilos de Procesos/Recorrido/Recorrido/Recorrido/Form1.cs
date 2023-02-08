using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recorrido
{
    public partial class Form1 : Form
    {
        int conteoTm1,conteoTm2,conteoTm3;
        int ban1Tm1 = 0, ban2Tm1 = 0;
        int ban1Tm2 = 0, ban2Tm2 = 0;
        int ban1Tm3 = 0, ban2Tm3 = 0;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }

        public Form1()
        {
            InitializeComponent();
            conteoTm1 = 0;
            conteoTm2 = 0;
            conteoTm3 = 0;
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            
            if (timer1.Enabled==false)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;

                btnInicio.Text = "Detener";
                
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                btnInicio.Text = "Iniciar";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (ban2Tm1<=2)
            {
                conteoTm1++;
                lblUno.Text = conteoTm1.ToString();
                if (conteoTm1==101)
                {
                    ban2Tm1 = 20;
                    ban1Tm1 = 10;
                }
            }

            if (ban1Tm1==10)
            {
                conteoTm1--;
                lblUno.Text = conteoTm1.ToString();
                if (conteoTm1 ==0)
                {
                    ban1Tm1 = 11;
                    ban2Tm1 = 0;
                }
            }

            
        }


        private void timer2_Tick(object sender, EventArgs e)
        {

            if (ban2Tm2 <= 2)
            {
                conteoTm2++;
                lblDos.Text = conteoTm2.ToString();
                //if (conteoTm2 == 20)
                //{
                //    ban2Tm2 = 20;
                //    ban1Tm2 = 10;
                //}
                if (conteoTm1 % 20 == 0)
                {
                    ban1Tm2 = 10;
                    ban2Tm2 = 20;
                }
            }

            if (ban1Tm2 == 10)
            {
                conteoTm2--;
                lblDos.Text = conteoTm2.ToString();
                
                if (conteoTm2 == 0 )
                {
                    ban1Tm2 = 11;
                    ban2Tm2 = 0;
                }

               
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (ban2Tm3 <= 2)
            {
                conteoTm3++;
                lblTres.Text = conteoTm3.ToString();
                //if (conteoTm3 == 50)
                //{
                //    ban2Tm3 = 20;
                //    ban1Tm3 = 10;
                //}
                if (conteoTm1 % 50 == 0)
                {
                    ban1Tm3 = 10;
                    ban2Tm3 = 20;
                }

            }

            if (ban1Tm3 == 10)
            {
                conteoTm3--;
                lblTres.Text = conteoTm3.ToString();
                
                if ( conteoTm3 == 0 )
                {
                    ban1Tm3 = 11;
                    ban2Tm3 = 0;
                }

                

            }
        }
    }
}
