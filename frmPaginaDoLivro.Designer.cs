namespace Livraria
{
    partial class frmPaginaDoLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaginaDoLivro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreNósToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.gpbSejaBemVindo = new System.Windows.Forms.GroupBox();
            this.btnAddCarrinho = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLancamento = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gpbSejaBemVindo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.contaToolStripMenuItem,
            this.generosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1056, 80);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "MenuSite";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreNósToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 76);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreNósToolStripMenuItem
            // 
            this.sobreNósToolStripMenuItem.Name = "sobreNósToolStripMenuItem";
            this.sobreNósToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.sobreNósToolStripMenuItem.Text = "Sobre Nós    ";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(62, 76);
            this.contaToolStripMenuItem.Text = "Conta";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // generosToolStripMenuItem
            // 
            this.generosToolStripMenuItem.Name = "generosToolStripMenuItem";
            this.generosToolStripMenuItem.Size = new System.Drawing.Size(77, 76);
            this.generosToolStripMenuItem.Text = "Generos";
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F);
            this.lblNomeLivro.Location = new System.Drawing.Point(264, 48);
            this.lblNomeLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(120, 24);
            this.lblNomeLivro.TabIndex = 1;
            this.lblNomeLivro.Text = "NomeDoLivro";
            // 
            // gpbSejaBemVindo
            // 
            this.gpbSejaBemVindo.Controls.Add(this.lblLancamento);
            this.gpbSejaBemVindo.Controls.Add(this.btnAddCarrinho);
            this.gpbSejaBemVindo.Controls.Add(this.btnComprar);
            this.gpbSejaBemVindo.Controls.Add(this.lblPreco);
            this.gpbSejaBemVindo.Controls.Add(this.label9);
            this.gpbSejaBemVindo.Controls.Add(this.label8);
            this.gpbSejaBemVindo.Controls.Add(this.label7);
            this.gpbSejaBemVindo.Controls.Add(this.lblEditora);
            this.gpbSejaBemVindo.Controls.Add(this.lblDescrição);
            this.gpbSejaBemVindo.Controls.Add(this.pictureBox1);
            this.gpbSejaBemVindo.Controls.Add(this.lblAutor);
            this.gpbSejaBemVindo.Controls.Add(this.label2);
            this.gpbSejaBemVindo.Controls.Add(this.lblNomeLivro);
            this.gpbSejaBemVindo.Location = new System.Drawing.Point(72, 111);
            this.gpbSejaBemVindo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbSejaBemVindo.Name = "gpbSejaBemVindo";
            this.gpbSejaBemVindo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbSejaBemVindo.Size = new System.Drawing.Size(881, 369);
            this.gpbSejaBemVindo.TabIndex = 16;
            this.gpbSejaBemVindo.TabStop = false;
            this.gpbSejaBemVindo.Text = "groupBox1";
            // 
            // btnAddCarrinho
            // 
            this.btnAddCarrinho.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.btnAddCarrinho.Location = new System.Drawing.Point(649, 318);
            this.btnAddCarrinho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCarrinho.Name = "btnAddCarrinho";
            this.btnAddCarrinho.Size = new System.Drawing.Size(196, 35);
            this.btnAddCarrinho.TabIndex = 12;
            this.btnAddCarrinho.Text = "Adicionar ao Carrinho";
            this.btnAddCarrinho.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.btnComprar.Location = new System.Drawing.Point(513, 318);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(112, 35);
            this.btnComprar.TabIndex = 11;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(264, 318);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(67, 28);
            this.lblPreco.TabIndex = 10;
            this.lblPreco.Text = "Preço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(576, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Lançamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(576, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Editora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Autor:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.lblEditora.Location = new System.Drawing.Point(577, 204);
            this.lblEditora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(49, 20);
            this.lblEditora.TabIndex = 6;
            this.lblEditora.Text = "label6";
            // 
            // lblDescrição
            // 
            this.lblDescrição.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.lblDescrição.Location = new System.Drawing.Point(264, 105);
            this.lblDescrição.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(282, 184);
            this.lblDescrição.TabIndex = 5;
            this.lblDescrição.Text = resources.GetString("lblDescrição.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(42, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 312);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.lblAutor.Location = new System.Drawing.Point(577, 149);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(24, 20);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "BookHouse";
            // 
            // lblLancamento
            // 
            this.lblLancamento.AutoSize = true;
            this.lblLancamento.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.lblLancamento.Location = new System.Drawing.Point(577, 264);
            this.lblLancamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLancamento.Name = "lblLancamento";
            this.lblLancamento.Size = new System.Drawing.Size(24, 20);
            this.lblLancamento.TabIndex = 13;
            this.lblLancamento.Text = "...";
            // 
            // frmPaginaDoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1056, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gpbSejaBemVindo);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPaginaDoLivro";
            this.Text = "frmPaginaDoLivro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbSejaBemVindo.ResumeLayout(false);
            this.gpbSejaBemVindo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreNósToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generosToolStripMenuItem;
        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.GroupBox gpbSejaBemVindo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblDescrição;
        private System.Windows.Forms.Button btnAddCarrinho;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblLancamento;
    }
}