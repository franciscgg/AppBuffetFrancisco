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
    public partial class MenuTela : Form
    {
        public MenuTela()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando a tela PDVTela
            //tipo   objeto        classe
            PDVTela pDVTela = new PDVTela();
            //Mostra a tela PDVTelav
            //pDVTela é um objeto
            pDVTela.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
