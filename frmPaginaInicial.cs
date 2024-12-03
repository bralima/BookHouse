using Livraria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginaDeLivro
{
    public partial class frmPaginaInicial : Form
    {
        public frmPaginaInicial()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPaginaDoLivro frm = new frmPaginaDoLivro();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastroCliente frm = new frmCadastroCliente();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastroLugar frm = new frmCadastroLugar();
            frm.ShowDialog();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastroPagamento frm = new frmCadastroPagamento();
            frm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
