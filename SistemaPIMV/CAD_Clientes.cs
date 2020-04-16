using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPIMV.Sistema
{
    public partial class CAD_Clientes : Form
    {
        public CAD_Clientes()
        {
            InitializeComponent();
        }

        private void CAD_Clientes_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmbTipo.Text = "OUTROS";
        }

      
        private void txtCep_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCep.Text);



                DataSet ds = new DataSet();
                ds.ReadXml(xml);

                txtLogradouro.Text = ds.Tables[0].Rows[0][5].ToString().ToUpper();
                txtEndereco.Text = ds.Tables[0].Rows[0]["Logradouro"].ToString().ToUpper();
                txtBairro.Text = ds.Tables[0].Rows[0]["Bairro"].ToString().ToUpper();
                txtCidade.Text = ds.Tables[0].Rows[0]["Cidade"].ToString().ToUpper();
                txtUf.Text = ds.Tables[0].Rows[0]["UF"].ToString().ToUpper();

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DateTime dataHoje = DateTime.Today;
       
            CadastroCliente cad = new CadastroCliente(txtNome.Text, txtCpf.Text, txtRg.Text, txtApelido.Text, txtZona.Text, txtObservacao.Text, cmbTipo.Text, txtCep.Text, txtLogradouro.Text, txtEndereco.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtUf.Text, txtPonto.Text, txtDdd.Text, txtTelefone.Text, txtContato.Text);
            MessageBox.Show(cad.mensagem, "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information );
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtApelido.Clear();
            txtZona.Clear();
            txtObservacao.Clear();
            cmbTipo.Text = "";
            txtCep.Clear();
            txtLogradouro.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUf.Clear();
            txtPonto.Clear();
            txtDdd.Clear();
            txtTelefone.Clear();
            txtContato.Clear();
        }
    }
}
