namespace SistemaPIMV
{
    partial class FRM_MudarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MudarSenha));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.txtNSenha = new System.Windows.Forms.TextBox();
            this.lblNSenha = new System.Windows.Forms.Label();
            this.lblRSenha = new System.Windows.Forms.Label();
            this.txtRSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(7, 7);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(10, 23);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(146, 21);
            this.cmbUsuario.TabIndex = 1;
            // 
            // txtNSenha
            // 
            this.txtNSenha.Location = new System.Drawing.Point(12, 64);
            this.txtNSenha.Name = "txtNSenha";
            this.txtNSenha.Size = new System.Drawing.Size(144, 20);
            this.txtNSenha.TabIndex = 2;
            // 
            // lblNSenha
            // 
            this.lblNSenha.AutoSize = true;
            this.lblNSenha.Location = new System.Drawing.Point(9, 48);
            this.lblNSenha.Name = "lblNSenha";
            this.lblNSenha.Size = new System.Drawing.Size(67, 13);
            this.lblNSenha.TabIndex = 3;
            this.lblNSenha.Text = "Nova Senha";
            // 
            // lblRSenha
            // 
            this.lblRSenha.AutoSize = true;
            this.lblRSenha.Location = new System.Drawing.Point(9, 90);
            this.lblRSenha.Name = "lblRSenha";
            this.lblRSenha.Size = new System.Drawing.Size(75, 13);
            this.lblRSenha.TabIndex = 5;
            this.lblRSenha.Text = "Repetir Senha";
            // 
            // txtRSenha
            // 
            this.txtRSenha.Location = new System.Drawing.Point(12, 106);
            this.txtRSenha.Name = "txtRSenha";
            this.txtRSenha.Size = new System.Drawing.Size(144, 20);
            this.txtRSenha.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(10, 133);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(146, 47);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FRM_MudarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 192);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblRSenha);
            this.Controls.Add(this.txtRSenha);
            this.Controls.Add(this.lblNSenha);
            this.Controls.Add(this.txtNSenha);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_MudarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mudar Senha";
            this.Load += new System.EventHandler(this.FRM_MudarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.TextBox txtNSenha;
        private System.Windows.Forms.Label lblNSenha;
        private System.Windows.Forms.Label lblRSenha;
        private System.Windows.Forms.TextBox txtRSenha;
        private System.Windows.Forms.Button btnSalvar;
    }
}