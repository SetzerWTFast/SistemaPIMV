using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPIMV.Sistema
{
    public partial class CAD_Produtos : Form
    {
        public CAD_Produtos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroProdutos cad = new CadastroProdutos(txtFabrica.Text, txtBarra.Text, txtDescricao.Text, cmbUnidade.Text, txtUtilizacao.Text);
            MessageBox.Show(cad.mensagem, "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtCodigo.Clear();
            txtData.Clear();
            txtFabrica.Clear();
            txtBarra.Clear();
            txtDescricao.Clear();
            cmbUnidade.Text = "";
            txtUtilizacao.Clear();
        }
    }
}
