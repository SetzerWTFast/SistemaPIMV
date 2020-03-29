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
    }
}
