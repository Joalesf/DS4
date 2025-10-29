using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        string connectionString =
        @"Server=JOALEXS;Database=Cotizaciones;TrustServerCertificate=True;Integrated Security=True;";

        const double Euro_a_dolar = 1.17;
        const double Dolar_a_Peso = 4258.0;
        const double euro_a_peso = Euro_a_dolar * Dolar_a_Peso;

        public Form1()
        {
            InitializeComponent();
            btnConversion1.Click += BtnConversion1_Click;
            txtConversion2.Click += TxtConversion2_Click;
            txtConversion3.Click += TxtConversion3_Click;
            Mostar.Click += Mostar_Click;
        }
        private void GuardarConversion(string monedaOrigen, double cantidadOrigen, string monedaDestino, double cantidadDestino)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Conversiones (Fecha, MonedaOrigen, CantidadOrigen, MonedaDestino, CantidadDestino) " +
                                   "VALUES (GETDATE(), @MonedaOrigen, @CantidadOrigen, @MonedaDestino, @CantidadDestino)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MonedaOrigen", monedaOrigen);
                        cmd.Parameters.AddWithValue("@CantidadOrigen", cantidadOrigen);
                        cmd.Parameters.AddWithValue("@MonedaDestino", monedaDestino);
                        cmd.Parameters.AddWithValue("@CantidadDestino", cantidadDestino);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
            }
        }
        private void BtnConversion1_Click(object sender, EventArgs e)
        {
            try
            {
                double euro = double.Parse(txtEur.Text);
                double dolar = euro * Euro_a_dolar;
                double peso = euro * euro_a_peso;

                txtEuroxeuro.Text = euro.ToString("0.00");
                txtEuroxDolar.Text = dolar.ToString("0.00");
                txtEuroxPeso.Text = peso.ToString("0.00");

                GuardarConversion("Euro", euro, "Dólar", dolar);
                GuardarConversion("Euro", euro, "Peso", peso);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido en Euro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtConversion2_Click(object sender, EventArgs e)
        {
            try
            {
                double dolar = double.Parse(txtDolar.Text);
                double euro = dolar / Euro_a_dolar;
                double peso = dolar * Dolar_a_Peso;

                TxtDolarxEuro.Text = euro.ToString("0.00");
                txtDolarxDolar.Text = dolar.ToString("0.00");
                txtDolarxPeso.Text = peso.ToString("0.00");

                GuardarConversion("Dólar", dolar, "Euro", euro);
                GuardarConversion("Dólar", dolar, "Peso", peso);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido en Dólar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtConversion3_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = double.Parse(txtPeso.Text);
                double dolar = peso / Dolar_a_Peso;
                double euro = peso / euro_a_peso;

                txtPesoxEuro.Text = euro.ToString("0.0000");
                txtPesoxDolar.Text = dolar.ToString("0.0000");
                TxtPesoXPeso.Text = peso.ToString("0.00");

                GuardarConversion("Peso", peso, "Dólar", dolar);
                GuardarConversion("Peso", peso, "Euro", euro);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido en Peso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mostar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Fecha, MonedaOrigen, CantidadOrigen, MonedaDestino, CantidadDestino FROM Conversiones ORDER BY Fecha DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No hay conversiones registradas aún.");
                            return;
                        }

                        StringBuilder sb = new StringBuilder();
                        while (reader.Read())
                        {
                            sb.AppendLine($"{reader["Fecha"]}: {reader["CantidadOrigen"]} {reader["MonedaOrigen"]} = {reader["CantidadDestino"]} {reader["MonedaDestino"]}");
                        }

                        MessageBox.Show(sb.ToString(), "Historial de Conversiones");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el historial: " + ex.Message);
            }
        }
    }
}