using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }
        private Stream myStream;
        int counter = 0;
        string line;


        private void btnArchivo_Click(object sender, EventArgs e)
        {

            //Configurar datagridview - Número de columnas
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "ID";
            col1.Width = 50;
            col1.ReadOnly = true;
            dtGCSV.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Nombres";
            col2.Width = 200;
            col2.ReadOnly = true;
            dtGCSV.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Apellido";
            col3.Width = 50;
            col3.ReadOnly = true;
            dtGCSV.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "correo";
            col4.Width = 200;
            col4.ReadOnly = true;
            dtGCSV.Columns.Add(col4);

            OpenFileDialog FDialogArchivo = new OpenFileDialog();
            FDialogArchivo.InitialDirectory = Application.StartupPath;
            FDialogArchivo.Filter = "archivos CSV | *.csv";
            if (FDialogArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = FDialogArchivo.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader file = new System.IO.StreamReader(FDialogArchivo.FileName);
                            while ((line = file.ReadLine()) != null)
                            {
                                string[] columnas = line.Split(',');
                                dtGCSV.Rows.Add(columnas[0], columnas[1], columnas[2], columnas[3]);
                                counter++;
                            }
                            MessageBox.Show($"encontramos {counter} líneas en el archivo");

                            file.Close();

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la conexión con la DB");
                   // throw;
                }


            }


        }
    }
}
