using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NachoOpera;

namespace ConsumoDLL
{
    public partial class frmOperaciones : Form
    {
        long resultado;

        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                resultado = NachoOpera.Aritmetica.Division(Convert.ToInt64(txtOpS1.Text),Convert.ToInt64(txtopS2.Text));
                lblRtadoSuma.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Suma no permitida!");
             //   throw;
            }
            

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            resultado = NachoOpera.Aritmetica.Resta(Convert.ToInt64(txtOpR1.Text), Convert.ToInt64(txtOpR2.Text));
            lblRtadoResta.Text = resultado.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            resultado = Aritmetica.Multiplicacion(Convert.ToInt64(txtOpM1.Text), Convert.ToInt64(txtOpM2.Text));
            lblRtadoMulti.Text = resultado.ToString();
        }

     
    }
}
