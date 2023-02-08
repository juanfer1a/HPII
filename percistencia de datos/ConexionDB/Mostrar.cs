using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionDB
{
    public partial class frmMostrar : Form
    {
        string comandoMostrar;

        public string ComandoMostrar { get => comandoMostrar; set => comandoMostrar = value; }

        public frmMostrar()
        {
            InitializeComponent();
        }

        

        private void Mostrar_Load(object sender, EventArgs e)
        {
            //se hace la carga de los datos para ser mostrados en un datagridview
            conexion myconexion = new conexion();
            myconexion.crudMySql(ComandoMostrar, "dboherramientas");
            dtgvMostrar.DataSource = myconexion.DataTable;
            myconexion.Connection.Close();
        }

        //metodo que recibe parametro con el comando que se pide mostrar.
        public void comman(string coman)
        {
            this.comandoMostrar = coman;
        }
               
    }
}
