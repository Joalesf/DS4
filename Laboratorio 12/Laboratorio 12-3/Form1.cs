using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_3
{
    public partial class Triangulos : Form
    {
        public Triangulos()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Triangulos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c, s, area;
            a = Convert.ToDouble(txtbox_A.Text);
            b = Convert.ToDouble(txtbox_B.Text);
            c = Convert.ToDouble(txtbox_c.Text);
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            txtbox_AreaT.Text = Convert.ToString(area);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbox_A.Clear();
            txtbox_B.Clear();
            txtbox_c.Clear();
            txtbox_CalcularSemiP.Clear();
            txtbox_AreaT.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, s, area;
            a = Convert.ToDouble(txtbox_A.Text);
            b = Convert.ToDouble(txtbox_B.Text);
            c = Convert.ToDouble(txtbox_c.Text);
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            txtbox_CalcularSemiP.Text = Convert.ToString(s);
            txtbox_AreaT.Text = Convert.ToString(area);
        }
    }
}
