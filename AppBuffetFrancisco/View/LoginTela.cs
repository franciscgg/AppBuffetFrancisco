using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBuffetFrancisco.View
{
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void LoginTela_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            string usuario = txb_user.Text;
            string senha = tbx_senha.Text;

            if (usuario == "pepinha" && senha == "123")
            {
                this.Visible = false;
                MenuTela Menu = new MenuTela();
                Menu.Show(this);

            }
            else
            {
                MessageBox.Show("Senha Ou Usuário incorreto");
            }
           

        }
    }
}
