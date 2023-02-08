using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaApp
{
    public partial class frmListar : Form
    {  
        GestorDB gestor = new GestorDB();
        public frmListar()
        {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e)
        {
            var listaContactos = gestor.ListarContactos();
            dataGridView1.DataSource = listaContactos;
        }
    }
}
