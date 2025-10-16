using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_13_1
{
    public partial class Ventana : Form
    {
        string connectionString =
        @"Server=JOALEXS;Database=Northwind;TrustServerCertificate=True;Integrated Security=True;";
        public Ventana()
        {
            InitializeComponent();
        }
        private void btn_conexion_Click(object sender, EventArgs e)
        {
            
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
                conexion.Close();
                MessageBox.Show("Se cerró la conexión.");
        }
        private void Ventana_Load(object sender, EventArgs e)
        {
            string query = "SELECT ProductName FROM [dbo].[Products]";

            using (SqlConnection conexion = new SqlConnection(connectionString))

            {
                SqlCommand comando = new SqlCommand(query, conexion);
                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();

                listBox_Nortwhid.Items.Clear();

                while (lector.Read())
                {
                    listBox_Nortwhid.Items.Add(lector["ProductName"].ToString());
                }

                lector.Close();
            }
        }
        private void listBox_Nortwhid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
