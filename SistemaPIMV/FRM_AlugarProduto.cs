using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPIMV
{
    public partial class FRM_AlugarProduto : Form
    {
        public FRM_AlugarProduto()
        {
            InitializeComponent();
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            AlugarProduto Alugar = new AlugarProduto(txtCodigoCliente.Text, txtNomeCliente.Text, txtCodigoProduto.Text, txtNomeProduto.Text, dtRetira.Text, dtDevolucao.Text, txtLocal.Text, txtObservacao.Text, 1);
            MessageBox.Show(Alugar.mensagem, "Alugar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnAlugar.Enabled = false;
        }

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CKNEAKE;Initial Catalog=PIMV;User ID=sa;Password=30136416");
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Clientes WHERE idCliente = @idCliente", con);
                cmd.Parameters.AddWithValue("@idCliente", txtCodigoCliente.Text);
                con.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    txtNomeCliente.Text = dados["nome"].ToString();
                }
                con.Close();
                txtCodigoProduto.Focus();
            }
        }

        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CKNEAKE;Initial Catalog=PIMV;User ID=sa;Password=30136416");
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Produtos WHERE idProduto = @idProduto", con);
                cmd.Parameters.AddWithValue("@idProduto", txtCodigoProduto.Text);
                con.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    txtNomeProduto.Text = dados["descricao"].ToString();
                }
                con.Close();
                txtLocal.Focus();
            }
        }
    }
}