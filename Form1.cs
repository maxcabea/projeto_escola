using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Escola
{
    public partial class Fescola : Form
    {
        public Fescola()
        {
            InitializeComponent();
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flogin tela_Login = new Flogin(this);
            tela_Login.ShowDialog();
        }
    }
}
