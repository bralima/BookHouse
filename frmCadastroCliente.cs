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
    public partial class frmCadastroCliente : Form
    {
        string updateMethod;
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Carregar()
        {
            BindingSource dados = new BindingSource();
            dados.DataSource = new CadastroCliente().Listar();
            dgvDados.DataSource = dados;

            this.textBox1.ReadOnly = true;
            this.textBox2.ReadOnly = true;
            this.textBox3.ReadOnly = true;
            this.textBox4.ReadOnly = true;  
            this.textBox5.ReadOnly = true;
            this.checkedListBox1.Enabled = false;

            this.dgvDados.Enabled = true;

            this.updateMethod = "Consulta";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefone_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPaginaInicial frm = new frmPaginaInicial();
            frm.ShowDialog();
        }

        private void dgvDados_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCodigo.Text = dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[0].Value.ToString();
            this.textBox1.Text = dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[1].Value.ToString();
            this.textBox2.Text = dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[2].Value.ToString();
            this.textBox3.Text = dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[3].Value.ToString();
            this.textBox4.Text = dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[4].Value.ToString();
            this.textBox5.Text = dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateMethod = "Inclusão";

            CadastroCliente oCad = new CadastroCliente();
            oCad.ClienteNome = this.textBox1.Text;
            oCad.ClienteSobrenome = this.textBox2.Text;
            oCad.ClienteEmail = this.textBox3.Text;
            oCad.ClienteTelefone = this.textBox4.Text;
            oCad.ClienteSenha = this.textBox5.Text;

            foreach(var item in checkedListBox1.Items)
            {
                oCad.ClienteSexo = item.ToString();
            }

            if (this.updateMethod == "Inclusão")
            {
                oCad.Gravar(0);
            }
            else
            {
                oCad.Gravar(Convert.ToInt32(this.txtCodigo.Text));
            }

            grbOpcoes.Visible = false;
            Carregar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            checkedListBox1.ClearSelected();
        }
    }
}
