using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aula062_Textbox
{
    public partial class f_Secundario : Form
    {
        f_Principal fp; // criado para poder usar f fora do construtor

        public f_Secundario(String v, f_Principal f)
        {
            InitializeComponent();

            tb_veiculos.Text = v;

            fp = f;

            f.num = 10; // importante: variável public. fp é o objeto da classe f_Principal?

        }

        private void f_Secundario_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_veiculos.Text = this.tb_veiculos.Text;  // tem que ir em design -> modificador -> public (por padrão é private)
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
