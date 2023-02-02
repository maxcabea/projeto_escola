namespace Projeto_Escola
{
    partial class F_geren_professor
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
            this.dgv_professor = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id_professor = new System.Windows.Forms.TextBox();
            this.lb_nome_professor = new System.Windows.Forms.Label();
            this.tb_nome_professor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_fechar = new System.Windows.Forms.Button();
            this.b_novo = new System.Windows.Forms.Button();
            this.b_excluir = new System.Windows.Forms.Button();
            this.b_limpar = new System.Windows.Forms.Button();
            this.b_atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_professor
            // 
            this.dgv_professor.AllowUserToAddRows = false;
            this.dgv_professor.AllowUserToDeleteRows = false;
            this.dgv_professor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professor.ColumnHeadersVisible = false;
            this.dgv_professor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_professor.EnableHeadersVisualStyles = false;
            this.dgv_professor.Location = new System.Drawing.Point(380, 40);
            this.dgv_professor.MultiSelect = false;
            this.dgv_professor.Name = "dgv_professor";
            this.dgv_professor.ReadOnly = true;
            this.dgv_professor.RowHeadersVisible = false;
            this.dgv_professor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_professor.Size = new System.Drawing.Size(273, 280);
            this.dgv_professor.TabIndex = 46;
            this.dgv_professor.SelectionChanged += new System.EventHandler(this.dgv_professor_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "ID:";
            // 
            // tb_id_professor
            // 
            this.tb_id_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id_professor.Location = new System.Drawing.Point(55, 272);
            this.tb_id_professor.Name = "tb_id_professor";
            this.tb_id_professor.Size = new System.Drawing.Size(142, 26);
            this.tb_id_professor.TabIndex = 44;
            // 
            // lb_nome_professor
            // 
            this.lb_nome_professor.AutoSize = true;
            this.lb_nome_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_professor.Location = new System.Drawing.Point(58, 40);
            this.lb_nome_professor.Name = "lb_nome_professor";
            this.lb_nome_professor.Size = new System.Drawing.Size(126, 20);
            this.lb_nome_professor.TabIndex = 41;
            this.lb_nome_professor.Text = "Nome professor:";
            // 
            // tb_nome_professor
            // 
            this.tb_nome_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome_professor.Location = new System.Drawing.Point(55, 63);
            this.tb_nome_professor.Name = "tb_nome_professor";
            this.tb_nome_professor.Size = new System.Drawing.Size(289, 29);
            this.tb_nome_professor.TabIndex = 38;
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
            this.panel1.Location = new System.Drawing.Point(3, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 41);
            this.panel1.TabIndex = 47;
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
            // F_geren_professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_professor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_id_professor);
            this.Controls.Add(this.lb_nome_professor);
            this.Controls.Add(this.tb_nome_professor);
            this.Name = "F_geren_professor";
            this.Text = "Gerenciamento de Professores";
            this.Load += new System.EventHandler(this.F_geren_professor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_professor;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_id_professor;
        private System.Windows.Forms.Label lb_nome_professor;
        public System.Windows.Forms.TextBox tb_nome_professor;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button b_fechar;
        public System.Windows.Forms.Button b_novo;
        public System.Windows.Forms.Button b_excluir;
        public System.Windows.Forms.Button b_limpar;
        public System.Windows.Forms.Button b_atualizar;
    }
}