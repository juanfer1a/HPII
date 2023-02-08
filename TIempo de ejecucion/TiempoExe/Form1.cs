using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiempoExe
{
    public partial class Form1 : Form
    {
        public int numero;
        private RadioButton[] botoncito;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int eleccion = 12;
            int cont = 0;
            foreach (RadioButton item in botoncito)
            {
                if (item != null)
                {
                    if (item.Checked)
                    {
                        eleccion = cont;
                    }
                    cont++;
                }

            }
            if (eleccion <= 11)
            {
                frmMulti ventana2 = new frmMulti(eleccion);
                ventana2.Show();

            }
            else MessageBox.Show("Elija un valor!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            botoncito = new RadioButton[11];
            int posY = 50;
            for (int i = 0; i < 11; i++)
            {
                RadioButton NRadio = new RadioButton();
                posY += 30;
                NRadio.Location = new Point(120, posY);

                NRadio.Text = i.ToString();
                this.Controls.Add(NRadio);
                botoncito[i] = NRadio;
            }
        }
    }
}
