using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Projeto_Escola
{
    //Conectar ao Banco (padrão)
    internal class Banco
    {
        private static SQLiteConnection conex;
        private static SQLiteConnection ConectarBanco()
        {
            conex = new SQLiteConnection("Data Source=" + Globais.caminhoBanco);
            conex.Open();
            return conex;
        }
        //Consulta específica aos usuários
        public static DataTable RelacaoUser()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
                var cmd = ConectarBanco().CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Consulta genérica
        public static DataTable ConsultaSQL(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public static void Dml(String sql, string msgOK = null, string msgErro=null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOK != null) { MessageBox.Show(msgOK); }
            }
            catch(Exception ex)
            {
                if (msgErro != null) { MessageBox.Show(msgErro + " " + ex.Message); }
                throw ex;
            }
        }
        public static void NovoUser(Usuario user)
        {
            if (UsernameExiste(user) == true)
            {
                MessageBox.Show("Usuário já existe no sistema");
                return;
            }
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (nm_usuario, login_usuario, senha_usuario, status_usuario, nivel_usuario) VALUES (@nome, @username, @senha, @status, @nivel)";

                cmd.Parameters.AddWithValue("@nome", user.nm_usuario);
                cmd.Parameters.AddWithValue("@username", user.login_usuario);
                cmd.Parameters.AddWithValue("@senha", user.senha_usuario);
                cmd.Parameters.AddWithValue("@status", user.status_usuario);
                cmd.Parameters.AddWithValue("@nivel", user.nivel_usuario);

                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo usuário adicionado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo .: " + ex.Message);
            }
        }
        public static bool UsernameExiste(Usuario user)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT login_usuario FROM tb_usuarios WHERE login_usuario='" + user.login_usuario + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0 )
            {
                resposta = true;
            }
            else
            {
                resposta = false;
            }
            vcon.Close();
            return resposta;
        }
    }

}
