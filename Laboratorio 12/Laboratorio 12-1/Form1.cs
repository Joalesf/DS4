using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_velocidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_tiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_tiempo_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcularDistancia_Click(object sender, EventArgs e)
        {
            try
            {
                double velocidad = double.Parse(txtbox_velocidad.Text);
                double tiempo = double.Parse(txtbox_tiempo.Text);

                double distancia = velocidad * tiempo;

                txtbox_resultado.Text = "Distancia recorrida: " + distancia + " metros";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txtbox_velocidad.Clear();
            txtbox_tiempo.Clear();
            txtbox_resultado.Clear();
        }
    }
}
