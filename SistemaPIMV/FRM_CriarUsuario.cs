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
    public partial class FRM_CriarUsuario : Form
    {
        public FRM_CriarUsuario()
        {
            InitializeComponent();
        }

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cadastro = new CadastrarUsuario(txtUsuario.Text, txtSenha.Text);
            MessageBox.Show(cadastro.mensagem, "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
