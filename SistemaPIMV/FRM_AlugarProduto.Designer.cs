namespace SistemaPIMV
{
    partial class FRM_AlugarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AlugarProduto));
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.gpCliente = new System.Windows.Forms.GroupBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.gpProduto = new System.Windows.Forms.GroupBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.gpDados = new System.Windows.Forms.GroupBox();
            this.dtDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dtRetira = new System.Windows.Forms.DateTimePicker();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.lblDataRetira = new System.Windows.Forms.Label();
            this.gpCliente.SuspendLayout();
            this.gpProduto.SuspendLayout();
            this.gpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(5, 40);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCliente.TabIndex = 0;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(109, 40);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(522, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.lblNomeCliente);
            this.gpCliente.Controls.Add(this.lblCodigoCliente);
            this.gpCliente.Controls.Add(this.txtNomeCliente);
            this.gpCliente.Controls.Add(this.txtCodigoCliente);
            this.gpCliente.Location = new System.Drawing.Point(12, 12);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.Size = new System.Drawing.Size(639, 66);
            this.gpCliente.TabIndex = 4;
            this.gpCliente.TabStop = false;
            this.gpCliente.Text = "Cliente";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(106, 24);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCliente.TabIndex = 3;
            this.lblNomeCliente.Text = "Nome";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Location = new System.Drawing.Point(6, 24);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoCliente.TabIndex = 2;
            this.lblCodigoCliente.Text = "Código";
            // 
            // gpProduto
            // 
            this.gpProduto.Controls.Add(this.lblNomeProduto);
            this.gpProduto.Controls.Add(this.lblCodigoProduto);
            this.gpProduto.Controls.Add(this.txtNomeProduto);
            this.gpProduto.Controls.Add(this.txtCodigoProduto);
            this.gpProduto.Location = new System.Drawing.Point(12, 84);
            this.gpProduto.Name = "gpProduto";
            this.gpProduto.Size = new System.Drawing.Size(639, 66);
            this.gpProduto.TabIndex = 5;
            this.gpProduto.TabStop = false;
            this.gpProduto.Text = "Produto";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(106, 24);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(44, 13);
            this.lblNomeProduto.TabIndex = 3;
            this.lblNomeProduto.Text = "Produto";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(6, 24);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoProduto.TabIndex = 2;
            this.lblCodigoProduto.Text = "Código";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(109, 40);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(522, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(5, 40);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProduto.TabIndex = 0;
            // 
            // btnAlugar
            // 
            this.btnAlugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlugar.Image")));
            this.btnAlugar.Location = new System.Drawing.Point(532, 371);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(119, 47);
            this.btnAlugar.TabIndex = 6;
            this.btnAlugar.Text = "   Alugar";
            this.btnAlugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlugar.UseVisualStyleBackColor = true;
            // 
            // btnLiberar
            // 
            this.btnLiberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberar.Image = ((System.Drawing.Image)(resources.GetObject("btnLiberar.Image")));
            this.btnLiberar.Location = new System.Drawing.Point(407, 371);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(119, 47);
            this.btnLiberar.TabIndex = 7;
            this.btnLiberar.Text = "   Liberar";
            this.btnLiberar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLiberar.UseVisualStyleBackColor = true;
            // 
            // gpDados
            // 
            this.gpDados.Controls.Add(this.dtDevolucao);
            this.gpDados.Controls.Add(this.dtRetira);
            this.gpDados.Controls.Add(this.lblObservacao);
            this.gpDados.Controls.Add(this.txtObservacao);
            this.gpDados.Controls.Add(this.txtLocal);
            this.gpDados.Controls.Add(this.lblLocal);
            this.gpDados.Controls.Add(this.lblDataDevolucao);
            this.gpDados.Controls.Add(this.lblDataRetira);
            this.gpDados.Location = new System.Drawing.Point(12, 156);
            this.gpDados.Name = "gpDados";
            this.gpDados.Size = new System.Drawing.Size(639, 206);
            this.gpDados.TabIndex = 8;
            this.gpDados.TabStop = false;
            this.gpDados.Text = "Dados";
            // 
            // dtDevolucao
            // 
            this.dtDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDevolucao.Location = new System.Drawing.Point(119, 39);
            this.dtDevolucao.Name = "dtDevolucao";
            this.dtDevolucao.Size = new System.Drawing.Size(97, 20);
            this.dtDevolucao.TabIndex = 11;
            // 
            // dtRetira
            // 
            this.dtRetira.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRetira.Location = new System.Drawing.Point(16, 39);
            this.dtRetira.Name = "dtRetira";
            this.dtRetira.Size = new System.Drawing.Size(97, 20);
            this.dtRetira.TabIndex = 10;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(13, 118);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 9;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(16, 134);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(611, 20);
            this.txtObservacao.TabIndex = 8;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(16, 89);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(610, 20);
            this.txtLocal.TabIndex = 7;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(13, 73);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(70, 13);
            this.lblLocal.TabIndex = 6;
            this.lblLocal.Text = "Local de Uso";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Location = new System.Drawing.Point(116, 23);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(100, 13);
            this.lblDataDevolucao.TabIndex = 4;
            this.lblDataDevolucao.Text = "Data de Devolução";
            // 
            // lblDataRetira
            // 
            this.lblDataRetira.AutoSize = true;
            this.lblDataRetira.Location = new System.Drawing.Point(12, 23);
            this.lblDataRetira.Name = "lblDataRetira";
            this.lblDataRetira.Size = new System.Drawing.Size(76, 13);
            this.lblDataRetira.TabIndex = 3;
            this.lblDataRetira.Text = "Data de Retira";
            // 
            // FRM_AlugarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 421);
            this.Controls.Add(this.gpDados);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.btnAlugar);
            this.Controls.Add(this.gpProduto);
            this.Controls.Add(this.gpCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(678, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(678, 460);
            this.Name = "FRM_AlugarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alocar Produto";
            this.gpCliente.ResumeLayout(false);
            this.gpCliente.PerformLayout();
            this.gpProduto.ResumeLayout(false);
            this.gpProduto.PerformLayout();
            this.gpDados.ResumeLayout(false);
            this.gpDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox gpCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.GroupBox gpProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.GroupBox gpDados;
        private System.Windows.Forms.DateTimePicker dtDevolucao;
        private System.Windows.Forms.DateTimePicker dtRetira;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.Label lblDataRetira;
    }
}