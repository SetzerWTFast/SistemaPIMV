using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPIMV.Cadastro
{
    public partial class FRM_Suporte : Form
    {
        public FRM_Suporte()
        {
            InitializeComponent();
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://api.whatsapp.com/send?phone=5515988151683");
            this.Close();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Projetos\SistemaPIMV\SistemaPIMV\bin\Debug\Conexao.exe");
            this.Close();
        }
    }
}
