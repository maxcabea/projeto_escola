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
    public partial class F_geren_user : Form
    {
        public F_geren_user()
        {
            InitializeComponent();
        }

        private void b_novo_Click(object sender, EventArgs e)
        {
            F_novo_user tela_novo_user = new F_novo_user();
            tela_novo_user.ShowDialog();
            dgv_usuario.DataSource = Banco.ObterUserID();
        }

        private void b_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = string.Empty;
            tb_username.Text = string.Empty;
            tb_senha.Text = string.Empty;
            cb_status.Text = string.Empty;
            nup_nivel.Value = 0;
        }

        private void b_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_geren_user_Load(object sender, EventArgs e)
        {
            dgv_usuario.DataSource = Banco.ObterUserID();
            dgv_usuario.Columns[0].Width = 90;
            dgv_usuario.Columns[1].Width = 180;
        }

        private void dgv_usuario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0 )
            {
                DataTable dt = new DataTable();

                string userId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosPorId(userId);

                tb_id_usuario.Text = dt.Rows[0].Field<Int64>("id_usuario").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nm_usuario").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("login_usuario").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("senha_usuario").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("status_usuario").ToString();
                nup_nivel.Text = dt.Rows[0].Field<Int64>("nivel_usuario").ToString();
            }

        }

        private void b_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuario.SelectedRows[0].Index;

            Usuario user = new Usuario();
            user.id_usuario = Convert.ToInt32(tb_id_usuario.Text);
            user.nm_usuario = tb_nome.Text;
            user.login_usuario = tb_username.Text;
            user.senha_usuario = tb_senha.Text;
            user.status_usuario = cb_status.Text;
            user.nivel_usuario = Convert.ToInt32(Math.Round(nup_nivel.Value, 0));

            Banco.AtualizarUsuario(user);

            dgv_usuario[1, linha].Value = tb_nome.Text;

        }

        private void b_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ? ", "Excluir Usuário", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Banco.RemoveUsuarioId(tb_id_usuario.Text);
                dgv_usuario.Rows.Remove(dgv_usuario.CurrentRow);
            }
        }
    }
}
