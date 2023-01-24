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
    public partial class Flogin : Form
    {
        Fescola f_login;
        DataTable dt = new DataTable();
        public Flogin(Fescola f)
        {
            InitializeComponent();
            f_login = f;
            
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blogon_Click(object sender, EventArgs e)
        {
            string username = tbusuario.Text;
            string senha = tbsenha.Text;
            if (username == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos");
                tbusuario.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_usuarios where login_usuario='"+username+"'AND senha_usuario='"+senha+"'";
            dt = Banco.ConsultaSQL(sql);
            if (dt.Rows.Count == 1) 
            {
                f_login.lb_nivel.Text = dt.Rows[0].ItemArray[5].ToString();
                f_login.lb_user.Text = dt.Rows[0].Field<string>("login_usuario");
                f_login.pb_login.Image = Properties.Resources.Circulo_verde;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("nivel_usuario").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos");
            }
        }
    }
}
