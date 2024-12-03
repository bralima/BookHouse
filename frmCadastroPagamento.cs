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
    public partial class frmCadastroPagamento : Form
    {
        public frmCadastroPagamento()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPaginaInicial frm = new frmPaginaInicial();  
            frm.ShowDialog();
        }
    }
}
