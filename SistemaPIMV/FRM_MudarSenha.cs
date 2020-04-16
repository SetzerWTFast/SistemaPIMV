using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPIMV
{
    public partial class FRM_MudarSenha : Form
    {
        public FRM_MudarSenha()
        {
            InitializeComponent();
        }

        private void FRM_MudarSenha_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'usuarios.tbl_Login'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_LoginTableAdapter.Fill(this.usuarios.tbl_Login);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AlterarSenha alterar = new AlterarSenha(cmbUsuario.Text, txtNSenha.Text);
            MessageBox.Show(alterar.mensagem, "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
