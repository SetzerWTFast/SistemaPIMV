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
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            txtUsuario.BackColor = this.BackColor;
            txtSenha.BackColor = this.BackColor;
            txtUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="admin" && txtSenha.Text=="admin")
            {
                Sistema.FRM_Menu Menu = new Sistema.FRM_Menu();
                Menu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos, tente novamente.", "Erro ao Entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
            }

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
