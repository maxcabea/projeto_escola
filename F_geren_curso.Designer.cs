namespace Projeto_Escola
{
    partial class F_geren_curso
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_status_curso = new System.Windows.Forms.ComboBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_area_curso = new System.Windows.Forms.TextBox();
            this.tb_nome_curso = new System.Windows.Forms.TextBox();
            this.dgv_curso = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_fechar = new System.Windows.Forms.Button();
            this.b_novo = new System.Windows.Forms.Button();
            this.b_excluir = new System.Windows.Forms.Button();
            this.b_limpar = new System.Windows.Forms.Button();
            this.b_atualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id_curso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "A: Ativo - D: Desativado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Status:";
            // 
            // cb_status_curso
            // 
            this.cb_status_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_status_curso.FormattingEnabled = true;
            this.cb_status_curso.Items.AddRange(new object[] {
            "A",
            "D"});
            this.cb_status_curso.Location = new System.Drawing.Point(57, 197);
            this.cb_status_curso.Name = "cb_status_curso";
            this.cb_status_curso.Size = new System.Drawing.Size(142, 28);
            this.cb_status_curso.TabIndex = 33;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(60, 107);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(115, 20);
            this.lb_username.TabIndex = 32;
            this.lb_username.Text = "Area do Curso:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(60, 39);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(101, 20);
            this.lb_nome.TabIndex = 31;
            this.lb_nome.Text = "Nome Curso:";
            // 
            // tb_area_curso
            // 
            this.tb_area_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_area_curso.Location = new System.Drawing.Point(57, 130);
            this.tb_area_curso.Name = "tb_area_curso";
            this.tb_area_curso.Size = new System.Drawing.Size(289, 29);
            this.tb_area_curso.TabIndex = 30;
            // 
            // tb_nome_curso
            // 
            this.tb_nome_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome_curso.Location = new System.Drawing.Point(57, 62);
            this.tb_nome_curso.Name = "tb_nome_curso";
            this.tb_nome_curso.Size = new System.Drawing.Size(289, 29);
            this.tb_nome_curso.TabIndex = 29;
            // 
            // dgv_curso
            // 
            this.dgv_curso.AllowUserToAddRows = false;
            this.dgv_curso.AllowUserToDeleteRows = false;
            this.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_curso.ColumnHeadersVisible = false;
            this.dgv_curso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_curso.EnableHeadersVisualStyles = false;
            this.dgv_curso.Location = new System.Drawing.Point(383, 39);
            this.dgv_curso.MultiSelect = false;
            this.dgv_curso.Name = "dgv_curso";
            this.dgv_curso.ReadOnly = true;
            this.dgv_curso.RowHeadersVisible = false;
            this.dgv_curso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_curso.Size = new System.Drawing.Size(273, 280);
            this.dgv_curso.TabIndex = 38;
            this.dgv_curso.SelectionChanged += new System.EventHandler(this.dgv_curso_SelectionChanged);
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
            this.panel1.Location = new System.Drawing.Point(3, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 41);
            this.panel1.TabIndex = 39;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "ID:";
            // 
            // tb_id_curso
            // 
            this.tb_id_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id_curso.Location = new System.Drawing.Point(57, 278);
            this.tb_id_curso.Name = "tb_id_curso";
            this.tb_id_curso.Size = new System.Drawing.Size(142, 26);
            this.tb_id_curso.TabIndex = 40;
            // 
            // F_geren_curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_id_curso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_curso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_status_curso);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.tb_area_curso);
            this.Controls.Add(this.tb_nome_curso);
            this.Name = "F_geren_curso";
            this.Text = "Gerenciamento de Curso";
            this.Load += new System.EventHandler(this.F_geren_curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_status_curso;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_nome;
        public System.Windows.Forms.TextBox tb_area_curso;
        public System.Windows.Forms.TextBox tb_nome_curso;
        public System.Windows.Forms.DataGridView dgv_curso;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button b_fechar;
        public System.Windows.Forms.Button b_novo;
        public System.Windows.Forms.Button b_excluir;
        public System.Windows.Forms.Button b_limpar;
        public System.Windows.Forms.Button b_atualizar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_id_curso;
    }
}