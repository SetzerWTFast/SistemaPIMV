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
    public partial class FRM_MudarSenha : Form
    {
        public FRM_MudarSenha()
        {
            InitializeComponent();
        }

        private void FRM_MudarSenha_Load(object sender, EventArgs e)
        {
            cmbUsuario.Text = "MASTER";
        }
    }
}
