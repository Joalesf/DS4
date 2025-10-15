using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_notaFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_Nota1.Clear();
            txt_Nota2.Clear();
            txt_nota3.Clear();
            txt_notaFinal.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_promedio_Click(object sender, EventArgs e)
        {
            try
            {
                double nota1 = Convert.ToDouble(txt_Nota1.Text);
                double nota2 = Convert.ToDouble(txt_Nota2.Text);
                double nota3 = Convert.ToDouble(txt_nota3.Text);
                double promedio = (nota1 + nota2 + nota3) / 3;

                txt_notaFinal.Text = "Su promedio es:" + promedio;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos para las notas.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
