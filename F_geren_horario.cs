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
    public partial class F_geren_horario : Form
    {
        public F_geren_horario()
        {
            InitializeComponent();
        }

        private void b_novo_Click(object sender, EventArgs e)
        {
            F_novo_horario tela_novo_horario = new F_novo_horario();
            tela_novo_horario.ShowDialog();
            dgv_horario.DataSource = Banco.ObterHorarioID();
        }

        private void b_limpar_Click(object sender, EventArgs e)
        {
            tb_descr_horario.Text = string.Empty;
        }

        private void b_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_geren_horario_Load(object sender, EventArgs e)
        {
            dgv_horario.DataSource = Banco.ObterHorarioID();
            dgv_horario.Columns[0].Width = 90;
            dgv_horario.Columns[1].Width = 180;
        }

        private void dgv_horario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();

                string horId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosHorarioId(horId);

                tb_id_horario.Text = dt.Rows[0].Field<Int64>("id_horario").ToString();
                tb_descr_horario.Text = dt.Rows[0].Field<string>("descricao_horario").ToString();
            }
        }

        private void b_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_horario.SelectedRows[0].Index;

            Horario hor = new Horario();
            hor.id_horario = Convert.ToInt32(tb_id_horario.Text);
            hor.descricao_horario = tb_descr_horario.Text;
            
            Banco.AtualizarHorario(hor);

            dgv_horario[1, linha].Value = tb_descr_horario.Text;
        }

        private void b_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ? ", "Excluir Nome", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Banco.RemoveHorarioId(tb_id_horario.Text);
                dgv_horario.Rows.Remove(dgv_horario.CurrentRow);
            }
        }
    }
}
