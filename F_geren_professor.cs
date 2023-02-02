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
    public partial class F_geren_professor : Form
    {
        public F_geren_professor()
        {
            InitializeComponent();
        }

        private void b_novo_Click(object sender, EventArgs e)
        {
            F_novo_professor tela_novo_professor = new F_novo_professor();
            tela_novo_professor.ShowDialog();
            dgv_professor.DataSource = Banco.ObterProfessorID();
        }

        private void b_limpar_Click(object sender, EventArgs e)
        {
            tb_nome_professor.Text = string.Empty;
        }

        private void b_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_geren_professor_Load(object sender, EventArgs e)
        {
            dgv_professor.DataSource = Banco.ObterProfessorID();
            dgv_professor.Columns[0].Width = 90;
            dgv_professor.Columns[1].Width = 180;
        }

        private void dgv_professor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();

                string profId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosProfessorId(profId);

                tb_id_professor.Text = dt.Rows[0].Field<Int64>("id_professor").ToString();
                tb_nome_professor.Text = dt.Rows[0].Field<string>("nm_professor").ToString();
            }
        }

        private void b_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_professor.SelectedRows[0].Index;

            Professor prof = new Professor();
            prof.id_professor = Convert.ToInt32(tb_id_professor.Text);
            prof.nm_professor = tb_nome_professor.Text;

            Banco.AtualizarProfessor(prof);

            dgv_professor[1, linha].Value = tb_nome_professor.Text;
        }

        private void b_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ? ", "Excluir Nome", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Banco.RemoveProfessorId(tb_id_professor.Text);
                dgv_professor.Rows.Remove(dgv_professor.CurrentRow);
            }
        }
    }
}
