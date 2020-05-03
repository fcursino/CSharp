using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reforço_Triângulo_Verídico_MG_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region sair
        private void button3_Click(object sender, EventArgs e)
        {
            Saida final = new Saida();
            final.fim();
        }
        #endregion
        #region cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        public void Cancelar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            try
            {
                string v1 = textBox1.Text;
                v1 = v1.Replace('.', ',');
                a = double.Parse(v1);

                string v2 = textBox2.Text;
                v2 = v2.Replace('.', ',');
                b = double.Parse(v2);

                string v3 = textBox3.Text;
                v3 = v3.Replace('.', ',');
                c = double.Parse(v3);

                if (b - c < a && a < b + c && a - c < b && b < a + c && a - b < c && c < a + b)
                {
                    if (a != b && b != c && c != a)
                    {
                        MessageBox.Show("Este é um triângulo ESCALENO");
                    }
                    else if (a == b && a != c || a == c && a != b || b == c && c != a)
                    {
                        MessageBox.Show("Este é um triângulo ISÓSCELES");
                    }
                    else if (a == b && b == c)
                    {
                        MessageBox.Show("Este é um triângulo EQUILÁTERO");
                    }
                }
                else
                {
                    MessageBox.Show("Os valores não correspondem a um triângulo!", "***ERRO***", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException erro)
            {
                string mens = erro.Message;
                MessageBox.Show(mens + "\n A entrada de dados não está em um formato correto \n Tente novamente...",
                    "**Erro**",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Cancelar();
            }
        
            
        }
    }
}
