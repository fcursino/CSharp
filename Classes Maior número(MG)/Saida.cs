using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Maior_número_MG_
{
    class Saida
    {
        public void fim()
        {
            string texto = "Deseja sair do programa de verificação de números?", titulo = "***Finalizando***";
            if(MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
