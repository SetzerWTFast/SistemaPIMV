﻿using System;
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
    public partial class CONS_Produtos : Form
    {
        public CONS_Produtos()
        {
            InitializeComponent();
        }

        private void CONS_Produtos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pIMVDataSet3.tbl_Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutosTableAdapter.Fill(this.pIMVDataSet3.tbl_Produtos);
            // TODO: esta linha de código carrega dados na tabela 'pIMVDataSet3.tbl_Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutosTableAdapter.Fill(this.pIMVDataSet3.tbl_Produtos);
            // TODO: esta linha de código carrega dados na tabela 'pIMVDataSet3.tbl_Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutosTableAdapter.Fill(this.pIMVDataSet3.tbl_Produtos);

        }
    }
}
