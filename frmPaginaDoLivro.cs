using PaginaDeLivro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class frmPaginaDoLivro : Form
    {
        public frmPaginaDoLivro()
        {
            InitializeComponent();
        }

        private void btnAddCarrinho_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCompra frm = new frmCompra();
            frm.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }
    }
}
