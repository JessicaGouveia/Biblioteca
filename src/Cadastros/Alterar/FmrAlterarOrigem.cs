using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;

namespace SystemTeca.Cadastros.Alterar
{
    public partial class FmrAlterarOrigem : Form
    {
        private OrigemController origemController;
        private OrigemModel origem;

        public FmrAlterarOrigem(int idOrigem)
        {
            InitializeComponent();
            origemController = new OrigemController();
            origem = origemController.ConsultaPorId(idOrigem);

            NomeTxT.Text = origem.NomeOrigem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NomeTxT.Text != "")
            {
                origem.NomeOrigem = NomeTxT.Text;
                var dbResultado = origemController.Atualizar(origem);
                MessageBox.Show(dbResultado.Mensagem);
                if (dbResultado.NumRetorno > 0)
                {
                    this.Close();
                }

            }
        }
    }
}
