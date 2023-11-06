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
            //Para fechar aplicação
            Application.Exit();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            //Tem variavel do tipo texto que recebe da ferramenta textBox
            string usuario = txb_user.Text;
            string senha = tbx_senha.Text;

            //O algoritimo para verificar as credenciais e permitir o acesso
            if (usuario == "pepinha" && senha == "123")
            {
                //Vai fechar a tela de login e abrir a tela do menu
                this.Hide(); //this -> este hide ->esconde/oculta
                //Instanciar a tela do menu
                MenuTela Menu = new MenuTela();
                //A tela menu ira fechar, junto com toda a aplicação
                //Porém irá abrir a tela menu novamente
                Menu.FormClosed += (s, args) => this.Close();
                Menu.Show();

            }
            else
            {
                MessageBox.Show("Senha Ou Usuário incorreto");
                txb_user.Text = "";
                tbx_senha.Text = "";
            }


        }
    }
}
