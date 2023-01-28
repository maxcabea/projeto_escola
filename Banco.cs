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

        public static void Dml(String sql, string msgOK = null, string msgErro = null)
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
            catch (Exception ex)
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
            if (dt.Rows.Count > 0)
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
        public static void NovoCurso(Curso curs)
        {
            if (CursoExiste(curs) == true)
            {
                MessageBox.Show("Curso já existe no sistema");
                return;
            }
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_curso (nm_curso, area_curso, status_curso) VALUES (@nome_curso, @area_curso, @status_curso)";

                cmd.Parameters.AddWithValue("@nome_curso", curs.nm_curso);
                cmd.Parameters.AddWithValue("@area_curso", curs.area_curso);
                cmd.Parameters.AddWithValue("@status_curso", curs.status_curso);

                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo curso adicionado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo .: " + ex.Message);
            }
        }
        public static bool CursoExiste(Curso curs)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT nm_curso FROM tb_curso WHERE nm_curso='" + curs.nm_curso + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
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
        public static void NovoProfessor(Professor prof)
        {
            if (ProfessorExiste(prof) == true)
            {
                MessageBox.Show("Nome já existe no sistema");
                return;
            }
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_professor (nm_professor) VALUES (@nome_professor)";
                cmd.Parameters.AddWithValue("@nome_professor", prof.nm_professor);


                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo professor adicionado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo .: " + ex.Message);
            }
        }
        public static bool ProfessorExiste(Professor prof)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT nm_professor FROM tb_professor WHERE nm_professor='" + prof.nm_professor + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
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
        public static void NovoAluno(Aluno alun)
        {
            if (AlunoExiste(alun) == true)
            {
                MessageBox.Show("CPF já existe no sistema");
                return;
            }
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_aluno (nm_aluno, sb_aluno, cpf_aluno) VALUES (@nome_aluno, @sobrenome_aluno, @cpf_aluno)";
                cmd.Parameters.AddWithValue("@nome_aluno", alun.nm_aluno);
                cmd.Parameters.AddWithValue("@sobrenome_aluno", alun.sb_aluno);
                cmd.Parameters.AddWithValue("@cpf_aluno", alun.cpf_aluno);


                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo aluno adicionado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo .: " + ex.Message);
            }
        }
        public static bool AlunoExiste(Aluno alun)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT cpf_aluno FROM tb_aluno WHERE cpf_aluno='" + alun.cpf_aluno + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
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
        public static DataTable ObterUserID()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_usuario AS ID,nm_usuario AS Nome FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
