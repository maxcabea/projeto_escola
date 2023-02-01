namespace Projeto_Escola
{
    partial class F_geren_user
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
            this.b_atualizar = new System.Windows.Forms.Button();
            this.b_limpar = new System.Windows.Forms.Button();
            this.b_novo = new System.Windows.Forms.Button();
            this.nup_nivel = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.b_excluir = new System.Windows.Forms.Button();
            this.b_fechar = new System.Windows.Forms.Button();
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_id_usuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup_nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "A: Ativo - B: Bloqueado";
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
            // nup_nivel
            // 
            this.nup_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nup_nivel.Location = new System.Drawing.Point(204, 265);
            this.nup_nivel.Name = "nup_nivel";
            this.nup_nivel.Size = new System.Drawing.Size(141, 26);
            this.nup_nivel.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 244);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nível:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Status:";
            // 
            // cb_status
            // 
            this.cb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cb_status.Location = new System.Drawing.Point(56, 263);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(142, 28);
            this.cb_status.TabIndex = 21;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(59, 173);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(60, 20);
            this.lb_senha.TabIndex = 20;
            this.lb_senha.Text = "Senha:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(59, 107);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(87, 20);
            this.lb_username.TabIndex = 19;
            this.lb_username.Text = "Username:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(59, 39);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(55, 20);
            this.lb_nome.TabIndex = 18;
            this.lb_nome.Text = "Nome:";
            // 
            // tb_senha
            // 
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(56, 196);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(289, 29);
            this.tb_senha.TabIndex = 17;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(56, 130);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(289, 29);
            this.tb_username.TabIndex = 16;
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(56, 62);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(289, 29);
            this.tb_nome.TabIndex = 15;
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
            // dgv_usuario
            // 
            this.dgv_usuario.AllowUserToAddRows = false;
            this.dgv_usuario.AllowUserToDeleteRows = false;
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.ColumnHeadersVisible = false;
            this.dgv_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_usuario.EnableHeadersVisualStyles = false;
            this.dgv_usuario.Location = new System.Drawing.Point(384, 39);
            this.dgv_usuario.MultiSelect = false;
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.ReadOnly = true;
            this.dgv_usuario.RowHeadersVisible = false;
            this.dgv_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuario.Size = new System.Drawing.Size(273, 280);
            this.dgv_usuario.TabIndex = 31;
            this.dgv_usuario.SelectionChanged += new System.EventHandler(this.dgv_usuario_SelectionChanged);
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
            this.panel1.Location = new System.Drawing.Point(3, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 41);
            this.panel1.TabIndex = 32;
            // 
            // tb_id_usuario
            // 
            this.tb_id_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id_usuario.Location = new System.Drawing.Point(56, 314);
            this.tb_id_usuario.Name = "tb_id_usuario";
            this.tb_id_usuario.Size = new System.Drawing.Size(142, 26);
            this.tb_id_usuario.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "ID:";
            // 
            // F_geren_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_id_usuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_usuario);
            this.Controls.Add(this.label3);
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
            this.Name = "F_geren_user";
            this.Text = "Gerenciamento de Usuários";
            this.Load += new System.EventHandler(this.F_geren_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button b_atualizar;
        public System.Windows.Forms.Button b_limpar;
        public System.Windows.Forms.Button b_novo;
        public System.Windows.Forms.NumericUpDown nup_nivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_nome;
        public System.Windows.Forms.TextBox tb_senha;
        public System.Windows.Forms.TextBox tb_username;
        public System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.Button b_excluir;
        public System.Windows.Forms.Button b_fechar;
        public System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tb_id_usuario;
        private System.Windows.Forms.Label label4;
    }
}