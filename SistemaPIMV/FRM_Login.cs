using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            txtUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CKNEAKE;Initial Catalog=PIMV;User ID=sa;Password=30136416");
                string query = "SELECT * FROM tbl_Login WHERE login = '" + txtUsuario.Text.Trim() + "'AND senha = '" + txtSenha.Text.Trim() + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                da.Fill(table);

                if (table.Rows.Count == 1)
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
            } catch(Exception)
            {
                MessageBox.Show("Erro ao conectar com o Banco de Dados, entre em contato com o suporte do sistema ou reinicie seu computador!");
                Application.Exit();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
