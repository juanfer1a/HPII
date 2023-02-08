using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos_de__Procesos
{/// <summary>
 ///1. La primera etiqueta despliega el recorrido del primer timer desde 1 hasta 100 y se devuelve cuando llega a los
 ///extremos.
 ///2. La segunda etiqueta inicia conteo de 1 hasta 20 y cuando llega a 20, se devuelve en cuenta regresiva, 
 ///dependiendo del valor del primer timer.
 ///3. El tercer timer, cuenta de 1 a 50 y oscila de acuerdo al timer 1 entre ese rango.
 /// </summary>
    public partial class FrmHilosDeProcesos : Form
    {
        int cont100 = 0;
        int cont20 = 0;
        int cont50 = 0;
        bool decremento100, decremento20, decremento50,band;
        public FrmHilosDeProcesos()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Se condiciona el inicio de los timers para mostrar texto en el boton segun la accion realizada por usuario
            if (tmr100.Enabled == false)
            {
                tmr100.Enabled = true;
                tmr20.Enabled = true;
                tmr50.Enabled = true;

                btnStart.Text = "&Pausar";

            }
            else
            {
                tmr100.Enabled = false;
                tmr20.Enabled = false;
                tmr50.Enabled = false;

                btnStart.Text = "&Iniciar";
            }
          
        }

        //evento tick de timer primer label 1 y 50
        private void tmr100_Tick_1(object sender, EventArgs e)
        {
            //con los siguientes condicionales comparamos el valor del primer timer para asi dar valor a 
            //la bandera y condicionar asi el aumento o decremento del contador entre los extremos pedidos
            if (cont100 % 100 == 0)
            {
                decremento100 = true;
            }

            if (cont100 == 0)
            {
                decremento100 = false;
            }

            if (decremento100)
            {
                cont100--;
            }
            else
            {
                cont100++;
            }

            lbl100.Text = cont100.ToString();


        }


        //evento tick de timer segundo label entre 1 y 20
        private void tmr20_Tick_1(object sender, EventArgs e)
        {

            //evalua los multiplos de contador 1 y en el contador 2 para dar valor a bandera y 
            // aumentar contador
            if (cont100 % 20 == 0)
            {
                decremento20 = false;
            }

            //evalua valor de contador para allar extremo deseado y cambiar bandera para decrementar contador
            if (cont20 == 20)
            {
                decremento20 = true;
            }
                        
            if (decremento20)
            {
                cont20--;
            }
            else
            {
                cont20++;
            }


            lbl20.Text = cont20.ToString();

        }

       
        //evento timer para label 3 entre 1 y 50
        private void tmr50_Tick_1(object sender, EventArgs e)
        {
            //evalua multiplos de entre primer contador y tercero (100 y 50)            
            if (cont100 % 50 == 0)
            {
                decremento50 = false;
            }

            if (cont100 == 50)
            {
                decremento50 = true;
            }

            if (decremento50)
            {
                cont50--;
            }
            else
            {
                cont50++;
            }
            lbl50.Text = cont50.ToString();

        }

           
        //evento cerrar del formulario para parar los timers
        private void FrmHilosDeProcesos_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmr100.Stop();
            tmr20.Stop();
            tmr50.Stop();
        }

        //evento click para cerrar y parar timers
        private void btnCerrar_Click(object sender, EventArgs e)
        {

            tmr100.Stop();
            tmr20.Stop();
            tmr50.Stop();
            Close();
        }
    }
}
