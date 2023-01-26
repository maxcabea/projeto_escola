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
    public partial class F_novo_user : Form
    {
        public F_novo_user()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Text = string.Empty;
            tb_username.Text = string.Empty;
            tb_senha.Text = string.Empty;
            cb_status.Text = string.Empty;
            nup_nivel.Value = 0;
        }

        private void b_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario= new Usuario();
            usuario.nm_usuario = tb_nome.Text;
            usuario.login_usuario = tb_username.Text;
            usuario.senha_usuario = tb_senha.Text;
            usuario.status_usuario = cb_status.Text;
            usuario.nivel_usuario = Convert.ToInt32(Math.Round(nup_nivel.Value, 0));
            Banco.NovoUser(usuario);
        }
    }
}
