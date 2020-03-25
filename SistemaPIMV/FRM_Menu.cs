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
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAD_Clientes Clientes = new CAD_Clientes();
            if (Application.OpenForms.OfType<CAD_Clientes>().Count() > 0){
            }else
            {
                Clientes.Show();
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAD_Produtos Produtos = new CAD_Produtos();
            if (Application.OpenForms.OfType<CAD_Produtos>().Count() > 0)
            {
            }
            else
            {
                Produtos.Show();
            }
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.FRM_Suporte Suporte = new Cadastro.FRM_Suporte();
            if (Application.OpenForms.OfType<Cadastro.FRM_Suporte>().Count() > 0)
            {
            }
            else
            {
                Suporte.Show();
            }
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAD_Grupo Grupo = new CAD_Grupo();
            if (Application.OpenForms.OfType<CAD_Grupo>().Count() > 0)
            {
            }
            else
            {
                Grupo.Show();
            }
        }

        private void subGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAD_Subgrupo SubGrupo = new CAD_Subgrupo();
            if (Application.OpenForms.OfType<CAD_Subgrupo>().Count() > 0)
            {
            }
            else
            {
                SubGrupo.Show();
            }
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            tstData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tstHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timeAtualizar_Tick(object sender, EventArgs e)
        {
            tstHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FRM_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
