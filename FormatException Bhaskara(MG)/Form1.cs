using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatException_Bhaskara_MG_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c, x1, x2;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox1.Text);
                c = Convert.ToDouble(textBox1.Text);
                if ((b * b - 4 * a * c) >= 0)
                {
                    x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                    x2 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                    labelres1.Text = x1.ToString();
                    labelres2.Text = x2.ToString();
                }
                else
                {
                    labelres1.Text=("Não possui raizes reais");
                    labelres2.Text=("Não possui raizes reais");
                }
            }
            catch (FormatException erro)
            {
                string mensagem = erro.Message + "\nO valor que foi colocado é invalido.";
                MessageBox.Show(mensagem + "\nEntre com um valor valido", "**erro**", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            labelres1.Text = "";
            labelres2.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
