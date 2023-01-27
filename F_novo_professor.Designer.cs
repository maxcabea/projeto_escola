namespace Projeto_Escola
{
    partial class F_novo_professor
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
            this.b_salvar_professor = new System.Windows.Forms.Button();
            this.b_fechar_professor = new System.Windows.Forms.Button();
            this.b_novo_professor = new System.Windows.Forms.Button();
            this.lb_nome_professor = new System.Windows.Forms.Label();
            this.tb_nome_professor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_salvar_professor
            // 
            this.b_salvar_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_salvar_professor.Location = new System.Drawing.Point(146, 357);
            this.b_salvar_professor.Name = "b_salvar_professor";
            this.b_salvar_professor.Size = new System.Drawing.Size(110, 32);
            this.b_salvar_professor.TabIndex = 37;
            this.b_salvar_professor.Text = "Salvar";
            this.b_salvar_professor.UseVisualStyleBackColor = true;
            this.b_salvar_professor.Click += new System.EventHandler(this.b_salvar_professor_Click);
            // 
            // b_fechar_professor
            // 
            this.b_fechar_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_fechar_professor.Location = new System.Drawing.Point(289, 357);
            this.b_fechar_professor.Name = "b_fechar_professor";
            this.b_fechar_professor.Size = new System.Drawing.Size(110, 32);
            this.b_fechar_professor.TabIndex = 36;
            this.b_fechar_professor.Text = "Fechar";
            this.b_fechar_professor.UseVisualStyleBackColor = true;
            this.b_fechar_professor.Click += new System.EventHandler(this.b_fechar_professor_Click);
            // 
            // b_novo_professor
            // 
            this.b_novo_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_novo_professor.Location = new System.Drawing.Point(3, 357);
            this.b_novo_professor.Name = "b_novo_professor";
            this.b_novo_professor.Size = new System.Drawing.Size(110, 32);
            this.b_novo_professor.TabIndex = 35;
            this.b_novo_professor.Text = "Novo";
            this.b_novo_professor.UseVisualStyleBackColor = true;
            this.b_novo_professor.Click += new System.EventHandler(this.b_novo_professor_Click);
            // 
            // lb_nome_professor
            // 
            this.lb_nome_professor.AutoSize = true;
            this.lb_nome_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_professor.Location = new System.Drawing.Point(59, 39);
            this.lb_nome_professor.Name = "lb_nome_professor";
            this.lb_nome_professor.Size = new System.Drawing.Size(127, 20);
            this.lb_nome_professor.TabIndex = 31;
            this.lb_nome_professor.Text = "Nome Professor:";
            // 
            // tb_nome_professor
            // 
            this.tb_nome_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome_professor.Location = new System.Drawing.Point(56, 62);
            this.tb_nome_professor.Name = "tb_nome_professor";
            this.tb_nome_professor.Size = new System.Drawing.Size(289, 29);
            this.tb_nome_professor.TabIndex = 29;
            // 
            // F_novo_professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 392);
            this.Controls.Add(this.b_salvar_professor);
            this.Controls.Add(this.b_fechar_professor);
            this.Controls.Add(this.b_novo_professor);
            this.Controls.Add(this.lb_nome_professor);
            this.Controls.Add(this.tb_nome_professor);
            this.Name = "F_novo_professor";
            this.Text = "Cadastro de Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button b_salvar_professor;
        public System.Windows.Forms.Button b_fechar_professor;
        public System.Windows.Forms.Button b_novo_professor;
        private System.Windows.Forms.Label lb_nome_professor;
        public System.Windows.Forms.TextBox tb_nome_professor;
    }
}