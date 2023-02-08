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
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_novo_user tela_novo_user = new F_novo_user();
                    tela_novo_user.ShowDialog();
                }
                else { MessageBox.Show("Nível de acesso não permitido"); }
            }
            else 
            { 
                MessageBox.Show("É necessário logar no sistema "); 
            }
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

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair? ", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes);
            {
                lb_nivel.Text = "--";
                lb_user.Text = "--";
                pb_login.Image = Properties.Resources.Circulo_vermelho;
                Globais.nivel = 0;
                Globais.logado = false;
            }
            
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_geren_aluno tela_geren_alun = new F_geren_aluno();
            tela_geren_alun.ShowDialog();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_geren_curso tela_geren_curs = new F_geren_curso();
            tela_geren_curs.ShowDialog();
        }

        private void gerenciarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            F_geren_professor tela_geren_prof = new F_geren_professor();
            tela_geren_prof.ShowDialog();
        }

        private void novoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            F_novo_horario tela_novo_horario = new F_novo_horario();
            tela_novo_horario.ShowDialog();
        }

        private void gerenciarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            F_geren_horario tela_geren_horario = new F_geren_horario();
            tela_geren_horario.ShowDialog();
        }
    }
}
