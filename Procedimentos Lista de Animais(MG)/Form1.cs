using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedimentos_Lista_de_Animais_MG_
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
        #region limpar
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
            textBox9.Clear();
            textBox10.Clear();
            textBox1.Focus();
            labellista.Text = "";
        }
        #endregion
        #region keydown
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                textBox6.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                textBox7.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                textBox8.Focus();
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                textBox9.Focus();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                textBox10.Focus();
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                button1.Focus();
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            #region trycatch
            try
            {
                string valor1 = textBox1.Text;
                lista.Add(valor1);

                string valor2 = textBox2.Text;
                lista.Add(valor2);

                string valor3 = textBox3.Text;
                lista.Add(valor3);

                string valor4 = textBox4.Text;
                lista.Add(valor4);

                string valor5 = textBox5.Text;
                lista.Add(valor5);

                string valor6 = textBox6.Text;
                lista.Add(valor6);

                string valor7 = textBox7.Text;
                lista.Add(valor7);

                string valor8 = textBox8.Text;
                lista.Add(valor8);

                string valor9 = textBox9.Text;
                lista.Add(valor9);

                string valor10 = textBox10.Text;
                lista.Add(valor10);
                lista.Sort();
                foreach(var x in lista)
                {
                    
                    labellista.Text = (string.Join("\n", lista));
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + "\n Sequência de entrada não está em um formato correto...\n Tente novamente", "**ERRO**",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
