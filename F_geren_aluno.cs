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
    public partial class F_geren_aluno : Form
    {
        public F_geren_aluno()
        {
            InitializeComponent();
        }

        private void b_novo_Click(object sender, EventArgs e)
        {
            F_aluno tela_novo_aluno = new F_aluno();
            tela_novo_aluno.ShowDialog();
            dgv_aluno.DataSource = Banco.ObterAlunoID();
        }

        private void b_limpar_Click(object sender, EventArgs e)
        {
            tb_nome_aluno.Text = string.Empty;
            tb_sobrenome_aluno.Text = string.Empty;
            tb_cpf_aluno.Text = string.Empty;
        }

        private void b_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_geren_aluno_Load(object sender, EventArgs e)
        {
            dgv_aluno.DataSource = Banco.ObterAlunoID();
            dgv_aluno.Columns[0].Width = 90;
            dgv_aluno.Columns[1].Width = 180;
        }

        private void dgv_aluno_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();

                string alunId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosAlunoId(alunId);

                tb_id_aluno.Text = dt.Rows[0].Field<Int64>("id_aluno").ToString();
                tb_nome_aluno.Text = dt.Rows[0].Field<string>("nm_aluno").ToString();
                tb_sobrenome_aluno.Text = dt.Rows[0].Field<string>("sb_aluno").ToString();
                tb_cpf_aluno.Text = dt.Rows[0].Field<string>("cpf_aluno").ToString();
            }
        }

        private void b_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_aluno.SelectedRows[0].Index;

            Aluno alun = new Aluno();
            alun.id_aluno = Convert.ToInt32(tb_id_aluno.Text);
            alun.nm_aluno = tb_nome_aluno.Text;
            alun.sb_aluno = tb_sobrenome_aluno.Text;
            alun.cpf_aluno = tb_cpf_aluno.Text;
            
            Banco.AtualizarAluno(alun);

            dgv_aluno[1, linha].Value = tb_nome_aluno.Text;
            

        }

        private void b_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ? ", "Excluir Nome", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Banco.RemoveAlunoId(tb_id_aluno.Text);
                dgv_aluno.Rows.Remove(dgv_aluno.CurrentRow);
            }
        }
    }
}
