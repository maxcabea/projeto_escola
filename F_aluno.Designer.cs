namespace Projeto_Escola
{
    partial class F_aluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_salvar_usuario = new System.Windows.Forms.Button();
            this.b_fechar_usuario = new System.Windows.Forms.Button();
            this.b_novo_usuario = new System.Windows.Forms.Button();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_nome_aluno = new System.Windows.Forms.Label();
            this.tb_cpf_aluno = new System.Windows.Forms.TextBox();
            this.tb_sobrenome_aluno = new System.Windows.Forms.TextBox();
            this.tb_nome_aluno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_salvar_usuario
            // 
            this.b_salvar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_salvar_usuario.Location = new System.Drawing.Point(147, 356);
            this.b_salvar_usuario.Name = "b_salvar_usuario";
            this.b_salvar_usuario.Size = new System.Drawing.Size(110, 32);
            this.b_salvar_usuario.TabIndex = 27;
            this.b_salvar_usuario.Text = "Salvar";
            this.b_salvar_usuario.UseVisualStyleBackColor = true;
            this.b_salvar_usuario.Click += new System.EventHandler(this.b_salvar_usuario_Click);
            // 
            // b_fechar_usuario
            // 
            this.b_fechar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_fechar_usuario.Location = new System.Drawing.Point(290, 356);
            this.b_fechar_usuario.Name = "b_fechar_usuario";
            this.b_fechar_usuario.Size = new System.Drawing.Size(110, 32);
            this.b_fechar_usuario.TabIndex = 26;
            this.b_fechar_usuario.Text = "Fechar";
            this.b_fechar_usuario.UseVisualStyleBackColor = true;
            this.b_fechar_usuario.Click += new System.EventHandler(this.b_fechar_usuario_Click);
            // 
            // b_novo_usuario
            // 
            this.b_novo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_novo_usuario.Location = new System.Drawing.Point(4, 356);
            this.b_novo_usuario.Name = "b_novo_usuario";
            this.b_novo_usuario.Size = new System.Drawing.Size(110, 32);
            this.b_novo_usuario.TabIndex = 25;
            this.b_novo_usuario.Text = "Novo";
            this.b_novo_usuario.UseVisualStyleBackColor = true;
            this.b_novo_usuario.Click += new System.EventHandler(this.b_novo_usuario_Click);
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(60, 172);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(44, 20);
            this.lb_senha.TabIndex = 20;
            this.lb_senha.Text = "CPF:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(60, 106);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(96, 20);
            this.lb_username.TabIndex = 19;
            this.lb_username.Text = "Sobrenome:";
            // 
            // lb_nome_aluno
            // 
            this.lb_nome_aluno.AutoSize = true;
            this.lb_nome_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_aluno.Location = new System.Drawing.Point(60, 38);
            this.lb_nome_aluno.Name = "lb_nome_aluno";
            this.lb_nome_aluno.Size = new System.Drawing.Size(98, 20);
            this.lb_nome_aluno.TabIndex = 18;
            this.lb_nome_aluno.Text = "Nome aluno:";
            // 
            // tb_cpf_aluno
            // 
            this.tb_cpf_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cpf_aluno.Location = new System.Drawing.Point(57, 195);
            this.tb_cpf_aluno.Name = "tb_cpf_aluno";
            this.tb_cpf_aluno.Size = new System.Drawing.Size(289, 29);
            this.tb_cpf_aluno.TabIndex = 17;
            // 
            // tb_sobrenome_aluno
            // 
            this.tb_sobrenome_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sobrenome_aluno.Location = new System.Drawing.Point(57, 129);
            this.tb_sobrenome_aluno.Name = "tb_sobrenome_aluno";
            this.tb_sobrenome_aluno.Size = new System.Drawing.Size(289, 29);
            this.tb_sobrenome_aluno.TabIndex = 16;
            // 
            // tb_nome_aluno
            // 
            this.tb_nome_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome_aluno.Location = new System.Drawing.Point(57, 61);
            this.tb_nome_aluno.Name = "tb_nome_aluno";
            this.tb_nome_aluno.Size = new System.Drawing.Size(289, 29);
            this.tb_nome_aluno.TabIndex = 15;
            // 
            // F_aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 394);
            this.Controls.Add(this.b_salvar_usuario);
            this.Controls.Add(this.b_fechar_usuario);
            this.Controls.Add(this.b_novo_usuario);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_nome_aluno);
            this.Controls.Add(this.tb_cpf_aluno);
            this.Controls.Add(this.tb_sobrenome_aluno);
            this.Controls.Add(this.tb_nome_aluno);
            this.Name = "F_aluno";
            this.Text = "Cadastro de aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button b_salvar_usuario;
        public System.Windows.Forms.Button b_fechar_usuario;
        public System.Windows.Forms.Button b_novo_usuario;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_nome_aluno;
        public System.Windows.Forms.TextBox tb_cpf_aluno;
        public System.Windows.Forms.TextBox tb_sobrenome_aluno;
        public System.Windows.Forms.TextBox tb_nome_aluno;
    }
}