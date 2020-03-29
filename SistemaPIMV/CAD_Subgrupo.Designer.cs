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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAD_Subgrupo));
            this.dgvSubGrupo = new System.Windows.Forms.DataGridView();
            this.txtSubGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubGrupo
            // 
            this.dgvSubGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubGrupo.Location = new System.Drawing.Point(13, 69);
            this.dgvSubGrupo.Name = "dgvSubGrupo";
            this.dgvSubGrupo.Size = new System.Drawing.Size(523, 368);
            this.dgvSubGrupo.TabIndex = 0;
            // 
            // txtSubGrupo
            // 
            this.txtSubGrupo.Location = new System.Drawing.Point(13, 30);
            this.txtSubGrupo.Name = "txtSubGrupo";
            this.txtSubGrupo.Size = new System.Drawing.Size(411, 20);
            this.txtSubGrupo.TabIndex = 1;
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
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(430, 16);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(106, 47);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // CAD_Subgrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubGrupo);
            this.Controls.Add(this.dgvSubGrupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
    }
}