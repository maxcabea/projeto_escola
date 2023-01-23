using System;
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
    public partial class Flogin : Form
    {
        Fescola f_login;
        DataTable dt = new DataTable();
        public Flogin(Fescola f)
        {
            InitializeComponent();
            f_login = f;
            
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
