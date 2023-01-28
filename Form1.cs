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
            Flogin f_login = new Flogin(this);
            f_login.ShowDialog();
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flogin f_Login = new Flogin(this);
            f_Login.ShowDialog();
        }

        private void pb_login_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_novo_user tela_novo_user = new F_novo_user();
            tela_novo_user.ShowDialog();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            F_aluno tela_novo_aluno = new F_aluno();
            tela_novo_aluno.ShowDialog();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_novo_curso tela_novo_curso = new F_novo_curso();
            tela_novo_curso.ShowDialog();
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            F_novo_professor tela_novo_professor = new F_novo_professor();
            tela_novo_professor.ShowDialog();
        }

        private void gerenciamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_geren_user tela_geren_user = new F_geren_user();
            tela_geren_user.ShowDialog();
        }
    }
}
