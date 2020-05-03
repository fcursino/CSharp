using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Maior_e_Menor_MG_
{  
    public partial class Form1 : Form
    {
        List<int> lista = new List<int>();
        List<int> i = new List<int>();
        string msg1, msg2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void Limpar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            labelmaior.Text = "";
            labelmenor.Text = "";
            labelordem.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Saida final = new Saida();
            final.fim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                #region declaraçao de valores
                int v1 = int.Parse(textBox1.Text);
                lista.Add(v1);
                int v2 = int.Parse(textBox2.Text);
                lista.Add(v2);
                int v3 = int.Parse(textBox3.Text);
                lista.Add(v3);
                int v4 = int.Parse(textBox4.Text);
                lista.Add(v4);
                int v5 = int.Parse(textBox5.Text);
                lista.Add(v5);
                int v6 = int.Parse(textBox6.Text);
                lista.Add(v6);
                int v7 = int.Parse(textBox7.Text);
                lista.Add(v7);
                int v8 = int.Parse(textBox8.Text);
                lista.Add(v8);
                #endregion
                lista.Sort();
                lista.Reverse();
                foreach (var x in lista)
                {
                    
                    labelordem.Text = string.Join(", ", lista);
                    msg1 = Convert.ToString(lista.FirstOrDefault());
                    msg2 = Convert.ToString(lista.LastOrDefault());
                    labelmaior.Text = msg1;
                    labelmenor.Text = msg2;
                }
                
            }
            catch (FormatException erro)
            {
                MessageBox.Show(erro.Message + "\n Sequência de entrada não está em um formato correto...\n Tente novamente", "**ERRO**",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
