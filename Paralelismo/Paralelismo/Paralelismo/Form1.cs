using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paralelismo
{
    public partial class Form1 : Form
    {
        int contador1 = 0, contador2 = 50;
        bool increm1 = true, increm2 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrH1.Enabled = true;
            tmrH2.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrH1.Stop();
            tmrH2.Stop();
        }

        private void tmrH2_Tick(object sender, EventArgs e)
        {
            contador2--;
            lblH2.Text = contador2.ToString();
        }

        private void tmrH1_Tick(object sender, EventArgs e)
        {
            if (contador1 ==0)
            {
                increm1 = true;
            }
            if (contador1 == 20)
            {
                increm1 = false;
                tmrH2.Enabled = false;
            }
            if (increm1)
            {
                contador1++;
            }
            else
            {
                contador1--;
            }
           
            lblH1.Text = contador1.ToString();   
        }
    }
}
