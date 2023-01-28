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

        }
    }
}
