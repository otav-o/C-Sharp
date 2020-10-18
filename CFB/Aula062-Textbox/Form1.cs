using Microsoft.VisualBasic;
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
        public int num;
        public f_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void bt_Inserir_Click(object sender, EventArgs e)
        {
            if (tb_inserir.Text == "")
            {
                MessageBox.Show("Digite um veículo!");
                tb_inserir.Focus(); // posiciona o cursor na caixa
                return;
            }
            tb_veiculos.Text += tb_inserir.Text + ", ";
            // tb_inserir.Text = "";
            tb_inserir.Clear(); // não é .Text.Clear()
            tb_inserir.Focus();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_veiculos.Clear();
            tb_inserir.Clear();
            tb_inserir.Focus();
        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            f_Secundario veiculos = new f_Secundario(tb_veiculos.Text, this); // this passa o objeto ou a classe?

            veiculos.ShowDialog(); // não deixa, nem se minimizar

        }

        private void bt_mostrarNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(num));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
