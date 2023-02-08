using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paralelismo_2
{
    
    public partial class Form1 : Form
    {
        int contX = 880;
        int contY = 44;
        bool Bandera = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            if (Bandera == false)
            {
                tmr.Enabled = true;
                Bandera = true;
                btnCont.Text = "Detener";
            }
            else
            {
                tmr.Enabled = false;
                Bandera = false;
                btnCont.Text = "Iniciar";
            }           

        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            contX--;
            contY++;
            lblCont.Text = contX.ToString();
            pic.Location = new Point(contX, contY);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmr.Stop();
        }
    }
}
