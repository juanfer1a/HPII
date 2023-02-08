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
    public partial class frmMulti : Form
    {
        private Label[] etiquetas;
        public int cont = 0;
        public int NumRecibido = 0;
        int VlrOperacion = 0;

        public frmMulti(int valor)
        {
            InitializeComponent();
            //MessageBox.Show(valor.ToString());
            NumRecibido = valor;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmMulti_Load(object sender, EventArgs e)
        {
            int posY = 50;
            etiquetas = new Label[12];
            for (int i = 0; i < 12; i++)
            {
                Label NEtiqueta = new Label();
                posY += 30;
                NEtiqueta.Location = new Point(100, posY);

                cont++;
                //Obtener el valor de la multiplicación
                VlrOperacion = NumRecibido * cont;
                NEtiqueta.Text = NumRecibido.ToString() + " X " + cont.ToString() + " = " + VlrOperacion.ToString();
                //Agregar al Form en tiempo de ejecución
                this.Controls.Add(NEtiqueta);
                etiquetas[i] = NEtiqueta;
            }
        }
    }
}
