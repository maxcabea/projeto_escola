namespace Projeto_Escola
{
    partial class F_geren_aluno
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
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_nome_aluno = new System.Windows.Forms.Label();
            this.tb_cpf_aluno = new System.Windows.Forms.TextBox();
            this.tb_sobrenome_aluno = new System.Windows.Forms.TextBox();
            this.tb_nome_aluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id_aluno = new System.Windows.Forms.TextBox();
            this.dgv_aluno = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_fechar = new System.Windows.Forms.Button();
            this.b_novo = new System.Windows.Forms.Button();
            this.b_excluir = new System.Windows.Forms.Button();
            this.b_limpar = new System.Windows.Forms.Button();
            this.b_atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(59, 173);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(44, 20);
            this.lb_senha.TabIndex = 26;
            this.lb_senha.Text = "CPF:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(59, 107);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(96, 20);
            this.lb_username.TabIndex = 25;
            this.lb_username.Text = "Sobrenome:";
            // 
            // lb_nome_aluno
            // 
            this.lb_nome_aluno.AutoSize = true;
            this.lb_nome_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_aluno.Location = new System.Drawing.Point(59, 39);
            this.lb_nome_aluno.Name = "lb_nome_aluno";
            this.lb_nome_aluno.Size = new System.Drawing.Size(98, 20);
            this.lb_nome_aluno.TabIndex = 24;
            this.lb_nome_aluno.Text = "Nome aluno:";
            // 
            // tb_cpf_aluno
            // 
            this.tb_cpf_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cpf_aluno.Location = new System.Drawing.Point(56, 196);
            this.tb_cpf_aluno.Name = "tb_cpf_aluno";
            this.tb_cpf_aluno.Size = new System.Drawing.Size(289, 29);
            this.tb_cpf_aluno.TabIndex = 23;
            // 
            // tb_sobrenome_aluno
            // 
            this.tb_sobrenome_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sobrenome_aluno.Location = new System.Drawing.Point(56, 130);
            this.tb_sobrenome_aluno.Name = "tb_sobrenome_aluno";
            this.tb_sobrenome_aluno.Size = new System.Drawing.Size(289, 29);
            this.tb_sobrenome_aluno.TabIndex = 22;
            // 
            // tb_nome_aluno
            // 
            this.tb_nome_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome_aluno.Location = new System.Drawing.Point(56, 62);
            this.tb_nome_aluno.Name = "tb_nome_aluno";
            this.tb_nome_aluno.Size = new System.Drawing.Size(289, 29);
            this.tb_nome_aluno.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "ID:";
            // 
            // tb_id_aluno
            // 
            this.tb_id_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id_aluno.Location = new System.Drawing.Point(56, 271);
            this.tb_id_aluno.Name = "tb_id_aluno";
            this.tb_id_aluno.Size = new System.Drawing.Size(142, 26);
            this.tb_id_aluno.TabIndex = 35;
            // 
            // dgv_aluno
            // 
            this.dgv_aluno.AllowUserToAddRows = false;
            this.dgv_aluno.AllowUserToDeleteRows = false;
            this.dgv_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aluno.ColumnHeadersVisible = false;
            this.dgv_aluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_aluno.EnableHeadersVisualStyles = false;
            this.dgv_aluno.Location = new System.Drawing.Point(381, 39);
            this.dgv_aluno.MultiSelect = false;
            this.dgv_aluno.Name = "dgv_aluno";
            this.dgv_aluno.ReadOnly = true;
            this.dgv_aluno.RowHeadersVisible = false;
            this.dgv_aluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_aluno.Size = new System.Drawing.Size(273, 280);
            this.dgv_aluno.TabIndex = 37;
            this.dgv_aluno.SelectionChanged += new System.EventHandler(this.dgv_aluno_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.b_fechar);
            this.panel1.Controls.Add(this.b_novo);
            this.panel1.Controls.Add(this.b_excluir);
            this.panel1.Controls.Add(this.b_limpar);
            this.panel1.Controls.Add(this.b_atualizar);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(2, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 41);
            this.panel1.TabIndex = 38;
            // 
            // b_fechar
            // 
            this.b_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_fechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_fechar.Location = new System.Drawing.Point(575, 5);
            this.b_fechar.Name = "b_fechar";
            this.b_fechar.Size = new System.Drawing.Size(110, 32);
            this.b_fechar.TabIndex = 29;
            this.b_fechar.Text = "Fechar";
            this.b_fechar.UseVisualStyleBackColor = true;
            this.b_fechar.Click += new System.EventHandler(this.b_fechar_Click);
            // 
            // b_novo
            // 
            this.b_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_novo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_novo.Location = new System.Drawing.Point(3, 5);
            this.b_novo.Name = "b_novo";
            this.b_novo.Size = new System.Drawing.Size(110, 32);
            this.b_novo.TabIndex = 25;
            this.b_novo.Text = "Novo";
            this.b_novo.UseVisualStyleBackColor = true;
            this.b_novo.Click += new System.EventHandler(this.b_novo_Click);
            // 
            // b_excluir
            // 
            this.b_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_excluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_excluir.Location = new System.Drawing.Point(432, 5);
            this.b_excluir.Name = "b_excluir";
            this.b_excluir.Size = new System.Drawing.Size(110, 32);
            this.b_excluir.TabIndex = 30;
            this.b_excluir.Text = "Excluir";
            this.b_excluir.UseVisualStyleBackColor = true;
            this.b_excluir.Click += new System.EventHandler(this.b_excluir_Click);
            // 
            // b_limpar
            // 
            this.b_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_limpar.Location = new System.Drawing.Point(289, 5);
            this.b_limpar.Name = "b_limpar";
            this.b_limpar.Size = new System.Drawing.Size(110, 32);
            this.b_limpar.TabIndex = 26;
            this.b_limpar.Text = "Limpar";
            this.b_limpar.UseVisualStyleBackColor = true;
            this.b_limpar.Click += new System.EventHandler(this.b_limpar_Click);
            // 
            // b_atualizar
            // 
            this.b_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_atualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_atualizar.Location = new System.Drawing.Point(146, 5);
            this.b_atualizar.Name = "b_atualizar";
            this.b_atualizar.Size = new System.Drawing.Size(110, 32);
            this.b_atualizar.TabIndex = 27;
            this.b_atualizar.Text = "Atualizar";
            this.b_atualizar.UseVisualStyleBackColor = true;
            this.b_atualizar.Click += new System.EventHandler(this.b_atualizar_Click);
            // 
            // F_geren_aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_aluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_id_aluno);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_nome_aluno);
            this.Controls.Add(this.tb_cpf_aluno);
            this.Controls.Add(this.tb_sobrenome_aluno);
            this.Controls.Add(this.tb_nome_aluno);
            this.Name = "F_geren_aluno";
            this.Text = "Gerenciamento de Alunos";
            this.Load += new System.EventHandler(this.F_geren_aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_nome_aluno;
        public System.Windows.Forms.TextBox tb_cpf_aluno;
        public System.Windows.Forms.TextBox tb_sobrenome_aluno;
        public System.Windows.Forms.TextBox tb_nome_aluno;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_id_aluno;
        public System.Windows.Forms.DataGridView dgv_aluno;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button b_fechar;
        public System.Windows.Forms.Button b_novo;
        public System.Windows.Forms.Button b_excluir;
        public System.Windows.Forms.Button b_limpar;
        public System.Windows.Forms.Button b_atualizar;
    }
}