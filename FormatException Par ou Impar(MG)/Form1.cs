using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatException_Par_ou_Impar_MG_
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
                int n;
                n = int.Parse(textBox1.Text);
                if(n % 2 == 0)
                {
                    labelres.Text = "O número " + n + " é par.";
                }
                else
                {
                    labelres.Text = "O número " + n + " é ímpar.";
                }

            }
            catch (FormatException erro)
            {
                string mensagem = erro.Message + "\nSequência de entrada não está no formato correto.";
                MessageBox.Show(mensagem + "\nPor favor, tente novamente.", "***Erro***", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                throw;
            }
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            labelres.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa?","***Finalizando***",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)== DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                textBox1.Clear();
                labelres.Text = "";
                textBox1.Focus();
            }
        }
    }
}
