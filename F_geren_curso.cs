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
    public partial class F_geren_curso : Form
    {
        public F_geren_curso()
        {
            InitializeComponent();
        }

        private void b_limpar_Click(object sender, EventArgs e)
        {
            tb_nome_curso.Text = string.Empty;
            tb_area_curso.Text = string.Empty;
            cb_status_curso.Text = string.Empty;
        }

        private void b_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_novo_Click(object sender, EventArgs e)
        {
            F_novo_curso tela_novo_curso = new F_novo_curso();
            tela_novo_curso.ShowDialog();
            dgv_curso.DataSource = Banco.ObterCursoID();
        }

        private void F_geren_curso_Load(object sender, EventArgs e)
        {
            dgv_curso.DataSource = Banco.ObterCursoID();
            dgv_curso.Columns[0].Width = 90;
            dgv_curso.Columns[1].Width = 180;
        }

        private void dgv_curso_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();

                string cursoId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosCursoId(cursoId);

                tb_id_curso.Text = dt.Rows[0].Field<Int64>("id_curso").ToString();
                tb_nome_curso.Text = dt.Rows[0].Field<string>("nm_curso").ToString();
                tb_area_curso.Text = dt.Rows[0].Field<string>("area_curso").ToString();
                cb_status_curso.Text = dt.Rows[0].Field<string>("status_curso").ToString();
            }
        }

        private void b_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_curso.SelectedRows[0].Index;

            Curso curs = new Curso();
            curs.id_curso = Convert.ToInt32(tb_id_curso.Text);
            curs.nm_curso = tb_nome_curso.Text;
            curs.area_curso = tb_area_curso.Text;
           
            Banco.AtualizarCurso(curs);

            dgv_curso[1, linha].Value = tb_nome_curso.Text;
        }

        private void b_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ? ", "Excluir Nome", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Banco.RemoveCursoId(tb_id_curso.Text);
                dgv_curso.Rows.Remove(dgv_curso.CurrentRow);
            }
        }
    }
}
