using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Cálculo_de_Média_MG_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassCalculo valores = new ClassCalculo();
            double a, b, c, d, valor;
            try
            {
                string V1 = textBox1.Text;
                V1 = V1.Replace('.', ',');
                a = double.Parse(V1);
                string V2 = textBox2.Text;
                V2 = V2.Replace('.', ',');
                b = double.Parse(V2);
                string V3 = textBox3.Text;
                V3 = V3.Replace('.', ',');
                c = double.Parse(V3);
                string V4 = textBox4.Text;
                V4 = V4.Replace('.', ',');
                d = double.Parse(V4);
                if(a > 10 || a <0 || b > 10 || b < 0 || c > 10 || c < 0 || d > 10 || d < 0)
                {
                    MessageBox.Show("Valor(es) de nota(s) inválido(s).\nTente novamente.","***ATENÇÃO***", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    valor = valores.Processar(a,b,c,d);
                    labelmedia.Text = "Média das notas: " + valor.ToString();
                }
            }
            catch (FormatException erro)
            {
                string msg = erro.Message;
                MessageBox.Show(msg + "\nO formato das notas inseridas é inválido.\nTente novamente.", "***ERRO***", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            labelmedia.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Saida final = new Saida();
            final.fim();
        }
    }
}
