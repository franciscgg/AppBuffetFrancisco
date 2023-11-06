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
    public partial class PDVTela : Form
    {
        int totalfinal = 0;

        public PDVTela()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_pastel_Click(object sender, EventArgs e)
        {
            string registroPastel = "12";
            txb_codigo.Text = registroPastel;
        }

        private void btn_coxinha_Click(object sender, EventArgs e)
        {
            string registroCoxinha = "10";
            txb_codigo.Text = registroCoxinha;
        }

        private void btn_esfiha_Click(object sender, EventArgs e)
        {
            string registroEsfiha = "11";
            txb_codigo.Text = registroEsfiha;
        }

        private void btn_bolinhodequeijo_Click(object sender, EventArgs e)
        {
            string registroBolinho = "13";
            txb_codigo.Text = registroBolinho;
        }

        private void btn_suco_Click(object sender, EventArgs e)
        {
            string registroSuco = "14";
            txb_codigo.Text = registroSuco;
        }

        private void btn_refrigerante_Click(object sender, EventArgs e)
        {
            string registroRefri = "15";
            txb_codigo.Text = registroRefri;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string registroCafe = "16";
            txb_codigo.Text = registroCafe;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txb_codigo.Text = " ";
        }

        private void PDVTela_Load(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            int codigo = Convert.ToInt32(txb_codigo.Text);
            int qtd = (int)txb_qtde.Value;

            string[] itens = { "Coxinha", "Esfiha", "Pastel", "Bolinho de Queijo", "Suco", "Refrigerante", "Cafe" };
            int[] valor = { 8, 8, 8, 8, 12, 10, 10 };

            int total = qtd * valor[codigo - 10];

            totalfinal += total;

            dataGridView1.Rows.Add(itens[codigo - 10], qtd, valor[codigo - 10], total);

            lbl_ValorTotal.Text = "R$" + totalfinal.ToString() + ",00";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            lbl_ValorTotal.Text = string.Empty;
            txb_codigo.Text = string.Empty;
            txb_qtde.Value = 0;
            dataGridView1.Rows.Clear();
        }

        private void btn_rf_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFecharVenda fiscal = new TelaFecharVenda();
            fiscal.FormClosed += (s, args) => this.Close();
            fiscal.Show();
        }
    }
}

