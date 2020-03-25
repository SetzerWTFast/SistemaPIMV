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
            MessageBox.Show("Este sistema está em fase de desenvolvimento, versão alpha", "Bem-Vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtUsuario.BackColor = this.BackColor;
            txtSenha.BackColor = this.BackColor;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Sistema.FRM_Menu Menu = new Sistema.FRM_Menu();
            Menu.Show();
            this.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
