namespace SistemaPIMV.Cadastro
{
    partial class FRM_Suporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Suporte));
            this.label1 = new System.Windows.Forms.Label();
            this.btnWhatsapp = new System.Windows.Forms.Button();
            this.btnConexao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Como deseja nos contactar?";
            // 
            // btnWhatsapp
            // 
            this.btnWhatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhatsapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhatsapp.Image = ((System.Drawing.Image)(resources.GetObject("btnWhatsapp.Image")));
            this.btnWhatsapp.Location = new System.Drawing.Point(140, 51);
            this.btnWhatsapp.Name = "btnWhatsapp";
            this.btnWhatsapp.Size = new System.Drawing.Size(217, 47);
            this.btnWhatsapp.TabIndex = 1;
            this.btnWhatsapp.Text = "Chamar WhatsApp";
            this.btnWhatsapp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWhatsapp.UseVisualStyleBackColor = true;
            this.btnWhatsapp.Click += new System.EventHandler(this.btnWhatsapp_Click);
            // 
            // btnConexao
            // 
            this.btnConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexao.Image = ((System.Drawing.Image)(resources.GetObject("btnConexao.Image")));
            this.btnConexao.Location = new System.Drawing.Point(140, 114);
            this.btnConexao.Name = "btnConexao";
            this.btnConexao.Size = new System.Drawing.Size(217, 47);
            this.btnConexao.TabIndex = 2;
            this.btnConexao.Text = "       Abrir Conexão";
            this.btnConexao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConexao.UseVisualStyleBackColor = true;
            this.btnConexao.Click += new System.EventHandler(this.btnConexao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Suporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 175);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConexao);
            this.Controls.Add(this.btnWhatsapp);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Suporte";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWhatsapp;
        private System.Windows.Forms.Button btnConexao;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}