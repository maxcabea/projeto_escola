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
    public partial class F_novo_horario : Form
    {
        public F_novo_horario()
        {
            InitializeComponent();
        }

        private void b_novo_professor_Click(object sender, EventArgs e)
        {
            tb_desc_horario.Text = string.Empty;
        }

        private void b_fechar_professor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_salvar_professor_Click(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            horario.descricao_horario = tb_desc_horario.Text;
            Banco.NovoHorario(horario);
        }
    }
}
