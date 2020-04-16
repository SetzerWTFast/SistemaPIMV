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
    public partial class CONS_Clientes : Form
    {
        public CONS_Clientes()
        {
            InitializeComponent();
        }

        private void CONS_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pIMVDataSet2.tbl_Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ClientesTableAdapter.Fill(this.pIMVDataSet2.tbl_Clientes);

        }
    }
}

