using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula062_Textbox
{
    public partial class f_Principal : Form
    {
        public f_Principal()
        {
            InitializeComponent();
        }

        private void bt_Inserir_Click(object sender, EventArgs e)
        {
            if (tb_inserir.Text == "")
            {
                MessageBox.Show("Digite um veículo!");
                tb_inserir.Focus(); // posiciona o cursor na caixa
                return;
            }
            tb_2.Text += tb_inserir.Text + ", ";
            // tb_inserir.Text = "";
            tb_inserir.Clear(); // não é .Text.Clear()
            tb_inserir.Focus();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_2.Clear();
            tb_inserir.Clear();
            tb_inserir.Focus();
        }

       
    }
}
