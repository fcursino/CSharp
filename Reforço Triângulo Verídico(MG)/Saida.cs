﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reforço_Triângulo_Verídico_MG_
{
    class Saida
    {
        public void fim()
        {
            string texto = "Deseja sair do programa?", titulo = "***Finalizando..***";
            if(MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
