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
    public partial class F_aluno : Form
    {
        public F_aluno()
        {
            InitializeComponent();
        }

        private void b_fechar_usuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_novo_usuario_Click(object sender, EventArgs e)
        {
            tb_nome_aluno.Text = string.Empty;
            tb_sobrenome_aluno.Text = string.Empty;
            tb_cpf_aluno.Text = string.Empty;
        }

        private void b_salvar_usuario_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.nm_aluno = tb_nome_aluno.Text;
            aluno.sb_aluno = tb_sobrenome_aluno.Text;
            aluno.cpf_aluno = tb_cpf_aluno.Text;
            Banco.NovoAluno(aluno);
        }
    }
}
