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
    public partial class F_novo_curso : Form
    {
        public F_novo_curso()
        {
            InitializeComponent();
        }

        private void lb_nome_Click(object sender, EventArgs e)
        {

        }

        private void b_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_novo_Click(object sender, EventArgs e)
        {
            tb_nome_curso.Text = string.Empty;
            tb_area_curso.Text = string.Empty;
            cb_status_curso.Text = string.Empty;
        }

        private void b_salvar_Click(object sender, EventArgs e)
        {
            Curso curs = new Curso();
            curs.nm_curso = tb_nome_curso.Text;
            curs.area_curso = tb_area_curso.Text;
            curs.status_curso = cb_status_curso.Text;
            Banco.NovoCurso(curs);
        }
    }
}
