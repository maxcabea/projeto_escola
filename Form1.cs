﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Escola
{
    public partial class Fescola : Form
    {
        public Fescola()
        {
            InitializeComponent();
            Flogin f_login = new Flogin(this);
            f_login.ShowDialog();
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flogin f_Login = new Flogin(this);
            f_Login.ShowDialog();
        }

        private void pb_login_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_novo_user tela_novo_user = new F_novo_user();
            tela_novo_user.ShowDialog();
        }
    }
}
