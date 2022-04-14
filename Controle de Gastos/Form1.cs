using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelaLogin telaLogin = new frmTelaLogin();
            telaLogin.Show();


        }

        private void aberturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbertura telaAbertura = new frmAbertura();
            telaAbertura.Show();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelaCreditos telaCreditos = new frmTelaCreditos();
            telaCreditos.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelaHelp telaHelp = new frmTelaHelp();
            telaHelp.Show();
        }

        private void FormasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelaPagamento telaPagamento = new frmTelaPagamento();
            telaPagamento.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias telaCategorias = new frmCategorias();
            telaCategorias.Show();
        }

        private void lancamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLancamentos telaLancamentos = new frmLancamentos();
            telaLancamentos.Show();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
