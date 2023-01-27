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
    public partial class F_novo_professor : Form
    {
        public F_novo_professor()
        {
            InitializeComponent();
        }

        private void b_fechar_professor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_novo_professor_Click(object sender, EventArgs e)
        {
            tb_nome_professor.Text = string.Empty;
        }

        private void b_salvar_professor_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.nm_professor = tb_nome_professor.Text;
            Banco.NovoProfessor(professor);

        }
    }
}
