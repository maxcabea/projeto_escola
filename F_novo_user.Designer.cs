namespace Projeto_Escola
{
    partial class F_novo_user
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nup_nivel = new System.Windows.Forms.NumericUpDown();
            this.b_novo = new System.Windows.Forms.Button();
            this.b_fechar = new System.Windows.Forms.Button();
            this.b_salvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup_nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(56, 62);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(289, 29);
            this.tb_nome.TabIndex = 0;
            this.tb_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(56, 130);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(289, 29);
            this.tb_username.TabIndex = 1;
            // 
            // tb_senha
            // 
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(56, 196);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(289, 29);
            this.tb_senha.TabIndex = 2;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(59, 39);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(55, 20);
            this.lb_nome.TabIndex = 3;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(59, 107);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(87, 20);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "Username:";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(59, 173);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(60, 20);
            this.lb_senha.TabIndex = 5;
            this.lb_senha.Text = "Senha:";
            // 
            // cb_status
            // 
            this.cb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cb_status.Location = new System.Drawing.Point(56, 281);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(142, 28);
            this.cb_status.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 262);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nível:";
            // 
            // nup_nivel
            // 
            this.nup_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nup_nivel.Location = new System.Drawing.Point(204, 283);
            this.nup_nivel.Name = "nup_nivel";
            this.nup_nivel.Size = new System.Drawing.Size(141, 26);
            this.nup_nivel.TabIndex = 10;
            // 
            // b_novo
            // 
            this.b_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_novo.Location = new System.Drawing.Point(3, 357);
            this.b_novo.Name = "b_novo";
            this.b_novo.Size = new System.Drawing.Size(110, 32);
            this.b_novo.TabIndex = 11;
            this.b_novo.Text = "Novo";
            this.b_novo.UseVisualStyleBackColor = true;
            this.b_novo.Click += new System.EventHandler(this.b_novo_Click);
            // 
            // b_fechar
            // 
            this.b_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_fechar.Location = new System.Drawing.Point(289, 357);
            this.b_fechar.Name = "b_fechar";
            this.b_fechar.Size = new System.Drawing.Size(110, 32);
            this.b_fechar.TabIndex = 12;
            this.b_fechar.Text = "Fechar";
            this.b_fechar.UseVisualStyleBackColor = true;
            this.b_fechar.Click += new System.EventHandler(this.b_fechar_Click);
            // 
            // b_salvar
            // 
            this.b_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_salvar.Location = new System.Drawing.Point(146, 357);
            this.b_salvar.Name = "b_salvar";
            this.b_salvar.Size = new System.Drawing.Size(110, 32);
            this.b_salvar.TabIndex = 13;
            this.b_salvar.Text = "Salvar";
            this.b_salvar.UseVisualStyleBackColor = true;
            this.b_salvar.Click += new System.EventHandler(this.b_salvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "A: Ativo - B: Bloqueado";
            // 
            // F_novo_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_salvar);
            this.Controls.Add(this.b_fechar);
            this.Controls.Add(this.b_novo);
            this.Controls.Add(this.nup_nivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_nome);
            this.Name = "F_novo_user";
            this.Text = "Cadastro de usuários";
            ((System.ComponentModel.ISupportInitialize)(this.nup_nivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_senha;
        public System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.TextBox tb_username;
        public System.Windows.Forms.TextBox tb_senha;
        public System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown nup_nivel;
        public System.Windows.Forms.Button b_novo;
        public System.Windows.Forms.Button b_fechar;
        public System.Windows.Forms.Button b_salvar;
        private System.Windows.Forms.Label label3;
    }
}