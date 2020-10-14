using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula060
{
    public partial class Principal : Form // name do forms herda de Form
    {
        public Principal() // construtor
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void bt_texto_Click(object sender, EventArgs e)
        {
            /*String txt;
            txt = tb_texto.Text;
            lb_texto.Text = txt;*/
            lb_texto.Text = tb_texto.Text;
        }
    }
}
