namespace SistemaPIMV.Sistema
{
    partial class FRM_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Menu));
            this.mstpMenu = new System.Windows.Forms.MenuStrip();
            this.mstpCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstpConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstpAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.alocarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstpFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstOperador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeAtualizar = new System.Windows.Forms.Timer(this.components);
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mstpMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstpMenu
            // 
            this.mstpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstpCadastro,
            this.mstpConsulta,
            this.mstpAgenda,
            this.mstpFerramentas});
            this.mstpMenu.Location = new System.Drawing.Point(0, 0);
            this.mstpMenu.Name = "mstpMenu";
            this.mstpMenu.Size = new System.Drawing.Size(909, 24);
            this.mstpMenu.TabIndex = 0;
            this.mstpMenu.Text = "Menu";
            // 
            // mstpCadastro
            // 
            this.mstpCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.grupoToolStripMenuItem,
            this.subGrupoToolStripMenuItem});
            this.mstpCadastro.Name = "mstpCadastro";
            this.mstpCadastro.Size = new System.Drawing.Size(66, 20);
            this.mstpCadastro.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // grupoToolStripMenuItem
            // 
            this.grupoToolStripMenuItem.Name = "grupoToolStripMenuItem";
            this.grupoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.grupoToolStripMenuItem.Text = "Grupo";
            this.grupoToolStripMenuItem.Click += new System.EventHandler(this.grupoToolStripMenuItem_Click);
            // 
            // subGrupoToolStripMenuItem
            // 
            this.subGrupoToolStripMenuItem.Name = "subGrupoToolStripMenuItem";
            this.subGrupoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.subGrupoToolStripMenuItem.Text = "SubGrupo";
            this.subGrupoToolStripMenuItem.Click += new System.EventHandler(this.subGrupoToolStripMenuItem_Click);
            // 
            // mstpConsulta
            // 
            this.mstpConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.clientesToolStripMenuItem1});
            this.mstpConsulta.Name = "mstpConsulta";
            this.mstpConsulta.Size = new System.Drawing.Size(66, 20);
            this.mstpConsulta.Text = "Consulta";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // mstpAgenda
            // 
            this.mstpAgenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alocarProdutosToolStripMenuItem});
            this.mstpAgenda.Name = "mstpAgenda";
            this.mstpAgenda.Size = new System.Drawing.Size(60, 20);
            this.mstpAgenda.Text = "Agenda";
            // 
            // alocarProdutosToolStripMenuItem
            // 
            this.alocarProdutosToolStripMenuItem.Name = "alocarProdutosToolStripMenuItem";
            this.alocarProdutosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.alocarProdutosToolStripMenuItem.Text = "Alocar Produtos";
            this.alocarProdutosToolStripMenuItem.Click += new System.EventHandler(this.alocarProdutosToolStripMenuItem_Click);
            // 
            // mstpFerramentas
            // 
            this.mstpFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mudarSenhaToolStripMenuItem,
            this.criarUsuárioToolStripMenuItem,
            this.suporteToolStripMenuItem});
            this.mstpFerramentas.Name = "mstpFerramentas";
            this.mstpFerramentas.Size = new System.Drawing.Size(84, 20);
            this.mstpFerramentas.Text = "Ferramentas";
            // 
            // mudarSenhaToolStripMenuItem
            // 
            this.mudarSenhaToolStripMenuItem.Name = "mudarSenhaToolStripMenuItem";
            this.mudarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mudarSenhaToolStripMenuItem.Text = "Mudar Senha";
            this.mudarSenhaToolStripMenuItem.Click += new System.EventHandler(this.mudarSenhaToolStripMenuItem_Click);
            // 
            // criarUsuárioToolStripMenuItem
            // 
            this.criarUsuárioToolStripMenuItem.Name = "criarUsuárioToolStripMenuItem";
            this.criarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarUsuárioToolStripMenuItem.Text = "Criar Usuário";
            this.criarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.criarUsuárioToolStripMenuItem_Click);
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suporteToolStripMenuItem.Text = "Suporte";
            this.suporteToolStripMenuItem.Click += new System.EventHandler(this.suporteToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstOperador,
            this.tstData,
            this.tstHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstOperador
            // 
            this.tstOperador.Name = "tstOperador";
            this.tstOperador.Size = new System.Drawing.Size(99, 17);
            this.tstOperador.Text = "Operador: Master";
            // 
            // tstData
            // 
            this.tstData.Name = "tstData";
            this.tstData.Size = new System.Drawing.Size(31, 17);
            this.tstData.Text = "Data";
            // 
            // tstHora
            // 
            this.tstHora.Name = "tstHora";
            this.tstHora.Size = new System.Drawing.Size(33, 17);
            this.tstHora.Text = "Hora";
            // 
            // timeAtualizar
            // 
            this.timeAtualizar.Enabled = true;
            this.timeAtualizar.Interval = 1;
            this.timeAtualizar.Tick += new System.EventHandler(this.timeAtualizar_Tick);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(909, 553);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mstpMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstpMenu;
            this.Name = "FRM_Menu";
            this.Text = "Cyberduc Inc. - Sistema de locação de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Menu_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Menu_Load);
            this.mstpMenu.ResumeLayout(false);
            this.mstpMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstpMenu;
        private System.Windows.Forms.ToolStripMenuItem mstpCadastro;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstpConsulta;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstpAgenda;
        private System.Windows.Forms.ToolStripMenuItem alocarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstpFerramentas;
        private System.Windows.Forms.ToolStripMenuItem mudarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subGrupoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstOperador;
        private System.Windows.Forms.ToolStripStatusLabel tstData;
        private System.Windows.Forms.ToolStripStatusLabel tstHora;
        private System.Windows.Forms.Timer timeAtualizar;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
    }
}