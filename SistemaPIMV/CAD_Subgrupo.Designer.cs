namespace SistemaPIMV
{
    partial class CAD_Subgrupo
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
            this.dgvSubGrupo = new System.Windows.Forms.DataGridView();
            this.txtSubGrupo = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubGrupo
            // 
            this.dgvSubGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubGrupo.Location = new System.Drawing.Point(13, 56);
            this.dgvSubGrupo.Name = "dgvSubGrupo";
            this.dgvSubGrupo.Size = new System.Drawing.Size(491, 381);
            this.dgvSubGrupo.TabIndex = 0;
            // 
            // txtSubGrupo
            // 
            this.txtSubGrupo.Location = new System.Drawing.Point(13, 30);
            this.txtSubGrupo.Name = "txtSubGrupo";
            this.txtSubGrupo.Size = new System.Drawing.Size(411, 20);
            this.txtSubGrupo.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(430, 28);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sub Grupo";
            // 
            // CAD_Subgrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtSubGrupo);
            this.Controls.Add(this.dgvSubGrupo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(529, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(529, 489);
            this.Name = "CAD_Subgrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadatro de Sub Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubGrupo;
        private System.Windows.Forms.TextBox txtSubGrupo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
    }
}