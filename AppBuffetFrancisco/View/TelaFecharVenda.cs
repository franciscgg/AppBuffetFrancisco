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
    public partial class TelaFecharVenda : Form
    {
        private int totalfinal;
        public TelaFecharVenda(int totalfinal)
        {
            InitializeComponent();
            this.totalfinal = totalfinal;
        }


        private void TelaFecharVenda_Load(object sender, EventArgs e)
        {

            lbl_data.Text = DateTime.Now.ToString();
            lbl_totalfinal.Text = "R$" + totalfinal.ToString() + ",00";
        }
    }
}
