using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;

namespace Menu
{
    public partial class Form_DataSet : Form
    {   
        public Form_DataSet()
        {
           InitializeComponent();
        }
        private void Form_Compras_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;                                  
            try
            {
                //Conexion a una BBDD Access
                OleDbConnection conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "/bbdd/CUss.mdb; Jet OLEDB:Database Password = 1234");
                conexion.Open();
                string query = "select * from Tb_Formulario";
                OleDbCommand comando = new OleDbCommand(query, conexion);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(comando);
                //Creamos el dataset. Se llama igual que el objeto en Form, configurar las columnas.
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Tb_Formulario");
                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = "Tb_Formulario";
                conexion.Close();
            }
            catch (Exception ex)
            {
                //throw;
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
                
        }


    }
}
