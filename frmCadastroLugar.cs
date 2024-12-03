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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Livraria
{
    public partial class frmCadastroLugar : Form
    {
        string updateMethod;
        private Int32 catchRowIndex;
        public frmCadastroLugar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }=

        private void frmCadastroDeLugar_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Carregar()
        {
            BindingSource dados = new BindingSource();
            dados.DataSource = new CadastroLugar().Listar();
            dgvDados.DataSource = dados;

            this.txtEndereco.ReadOnly = true;
            this.txtCidade.ReadOnly = true;
            this.txtEstado.ReadOnly = true;
            this.dgvDados.Enabled = true;

            this.updateMethod = "Consulta";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Limpar()
        {
            txtCodigo.Clear();
            txtCidade.Clear();
            txtEndereco.Clear();
            txtEstado.Clear();
        }
        private void tsbIncluir_Click(object sender, EventArgs e)
        {
            grbOpcoes.Visible = true;
            Limpar();

            txtCidade.ReadOnly = false;
            txtEstado.ReadOnly = false;
            txtEndereco.ReadOnly = false;

            this.updateMethod = "Inclusão";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CadastroLugar oCad = new CadastroLugar();
            oCad.UsuarioEndereco = this.txtEndereco.Text;
            oCad.UsuarioCidade = this.txtCidade.Text;
            oCad.UsuarioEstado = this.txtEstado.Text;

            if (this.updateMethod == "Inclusão")
            {
                oCad.Gravar(0);
            } else
            {
                oCad.Gravar(Convert.ToInt32(this.txtCodigo.Text));
            }

            grbOpcoes.Visible = false;
            Carregar();
        }

        private void dgvDados_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCodigo.Text = dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[0].Value.ToString();
            this.txtEndereco.Text = dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[1].Value.ToString();
            this.txtCidade.Text = dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[2].Value.ToString();
            this.txtEstado.Text = dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            catchRowIndex = dgvDados.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dgvDados.SelectedRows)
            {
                txtCodigo.Text = row.Cells[0].Value.ToString();
                txtEndereco.Text = row.Cells[1].Value.ToString();
                txtCidade.Text = row.Cells[2].Value.ToString();
                txtEstado.Text = row.Cells[3].Value.ToString();



            }
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CadastroLugar o = new CadastroLugar();
            o.ResetarBaseDados();

            this.Hide();
            frmPaginaInicial frm = new frmPaginaInicial();
            frm.ShowDialog();
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            this.updateMethod = "Exclusão";

            CadastroLugar o = new CadastroLugar();
            o.Excluir(Convert.ToInt32(this.txtCodigo.Text));
            Carregar();
        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grbOpcoes.Visible = false;
            Carregar();
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            grbOpcoes.Visible = true;
            txtEstado.ReadOnly = false;
            txtCidade.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            this.dgvDados.Enabled = false;

            this.updateMethod = "Alteração";
        }

        private void dgvDados_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
        {
        
        }

        private void dgvDados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
