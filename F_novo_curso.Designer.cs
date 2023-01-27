namespace Projeto_Escola
{
    partial class F_novo_curso
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
            this.label3 = new System.Windows.Forms.Label();
            this.b_salvar = new System.Windows.Forms.Button();
            this.b_fechar = new System.Windows.Forms.Button();
            this.b_novo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_status_curso = new System.Windows.Forms.ComboBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_area_curso = new System.Windows.Forms.TextBox();
            this.tb_nome_curso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "A: Ativo - D: Desativado";
            // 
            // b_salvar
            // 
            this.b_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_salvar.Location = new System.Drawing.Point(146, 357);
            this.b_salvar.Name = "b_salvar";
            this.b_salvar.Size = new System.Drawing.Size(110, 32);
            this.b_salvar.TabIndex = 27;
            this.b_salvar.Text = "Salvar";
            this.b_salvar.UseVisualStyleBackColor = true;
            this.b_salvar.Click += new System.EventHandler(this.b_salvar_Click);
            // 
            // b_fechar
            // 
            this.b_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_fechar.Location = new System.Drawing.Point(289, 357);
            this.b_fechar.Name = "b_fechar";
            this.b_fechar.Size = new System.Drawing.Size(110, 32);
            this.b_fechar.TabIndex = 26;
            this.b_fechar.Text = "Fechar";
            this.b_fechar.UseVisualStyleBackColor = true;
            this.b_fechar.Click += new System.EventHandler(this.b_fechar_Click);
            // 
            // b_novo
            // 
            this.b_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_novo.Location = new System.Drawing.Point(3, 357);
            this.b_novo.Name = "b_novo";
            this.b_novo.Size = new System.Drawing.Size(110, 32);
            this.b_novo.TabIndex = 25;
            this.b_novo.Text = "Novo";
            this.b_novo.UseVisualStyleBackColor = true;
            this.b_novo.Click += new System.EventHandler(this.b_novo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Status:";
            // 
            // cb_status_curso
            // 
            this.cb_status_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_status_curso.FormattingEnabled = true;
            this.cb_status_curso.Items.AddRange(new object[] {
            "A",
            "D"});
            this.cb_status_curso.Location = new System.Drawing.Point(56, 281);
            this.cb_status_curso.Name = "cb_status_curso";
            this.cb_status_curso.Size = new System.Drawing.Size(142, 28);
            this.cb_status_curso.TabIndex = 21;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(59, 107);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(115, 20);
            this.lb_username.TabIndex = 19;
            this.lb_username.Text = "Area do Curso:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(59, 39);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(101, 20);
            this.lb_nome.TabIndex = 18;
            this.lb_nome.Text = "Nome Curso:";
            this.lb_nome.Click += new System.EventHandler(this.lb_nome_Click);
            // 
            // tb_area_curso
            // 
            this.tb_area_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_area_curso.Location = new System.Drawing.Point(56, 130);
            this.tb_area_curso.Name = "tb_area_curso";
            this.tb_area_curso.Size = new System.Drawing.Size(289, 29);
            this.tb_area_curso.TabIndex = 16;
            // 
            // tb_nome_curso
            // 
            this.tb_nome_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome_curso.Location = new System.Drawing.Point(56, 62);
            this.tb_nome_curso.Name = "tb_nome_curso";
            this.tb_nome_curso.Size = new System.Drawing.Size(289, 29);
            this.tb_nome_curso.TabIndex = 15;
            // 
            // F_novo_curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_salvar);
            this.Controls.Add(this.b_fechar);
            this.Controls.Add(this.b_novo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_status_curso);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.tb_area_curso);
            this.Controls.Add(this.tb_nome_curso);
            this.Name = "F_novo_curso";
            this.Text = "Cadastro de Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button b_salvar;
        public System.Windows.Forms.Button b_fechar;
        public System.Windows.Forms.Button b_novo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_status_curso;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_nome;
        public System.Windows.Forms.TextBox tb_area_curso;
        public System.Windows.Forms.TextBox tb_nome_curso;
    }
}