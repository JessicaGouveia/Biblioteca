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

namespace SystemTeca.Cadastros
{
    public partial class FmrCadastroOrigem : Form
    {
        private OrigemController origemController;
        private OrigemModel origem;


        public FmrCadastroOrigem()
        {
            InitializeComponent();
            origemController = new OrigemController();
            origem = new OrigemModel();
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
                var dbResultado = origemController.Inserir(origem);
                MessageBox.Show(dbResultado.Mensagem);
                if (dbResultado.NumRetorno > 0)
                {
                    this.Close();
                }
            }
        }
    }
}
