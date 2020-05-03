using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Maior_número_MG_
{
    public partial class Form1 : Form
    {
        #region declaração de variaveis
        int[] numeros = new int[6];
        int maior;
        string mensagem = "";
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        #region entrada de dados
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                numeros[0] = int.Parse(textBox1.Text);
                numeros[1] = int.Parse(textBox2.Text);
                numeros[2] = int.Parse(textBox3.Text);
                numeros[3] = int.Parse(textBox4.Text);
                numeros[4] = int.Parse(textBox5.Text);
                numeros[5] = int.Parse(textBox6.Text);
                Testar();
                labelres.Text = mensagem;
            }
            catch (Exception erro)
            {
               MessageBox.Show(erro.Message + "\n Sequência de entrada não está em um formato correto...\n Tente novamente", "**ERRO**",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                Cancelar();
            }
        }
        #endregion
        public void Testar()
        {
            Array.Sort(numeros);
            maior = numeros[5];
            mensagem = "O maior número é " + maior;
        }
        #region procedimento Cancelar
        public void Cancelar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            labelres.Text = "";
            textBox1.Focus();

        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Saida final = new Saida();
            final.fim();
        }
    }
}
