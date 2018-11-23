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
using SystemTeca.Data;
using SystemTeca.Models;

namespace SystemTeca.Configuracao
{
    public partial class FmrConfiguracaoCadastroFuncionario : Form
    {

        private PessoaController pessoaController;
        private PessoaModel pessoa;

        public FmrConfiguracaoCadastroFuncionario()
        {
            InitializeComponent();
            pessoaController = new PessoaController();
            pessoa = new PessoaModel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NomeTxT.Text != "" &&
                TelefoneTxT.Text != "" &&
                RGTxT.Text != "" &&
                CPFTxT.Text != "" &&
                EnderecoTxT.Text != "" &&
                NumeroTxT.Text != "" &&
                BairroTxT.Text != "" &&
                CidadeTxT.Text != "" &&
                UFTxT.Text != "")
            {

                // Passa os dado para a Model os Dados coletados pelo usuario
                pessoa.NomePessoa = NomeTxT.Text;
                pessoa.NumeroTelefone = TelefoneTxT.Text;
                pessoa.Rg = RGTxT.Text;
                pessoa.Cpf = CPFTxT.Text;
                pessoa.Cep = CEPTxT.Text;
                pessoa.Logradouro = EnderecoTxT.Text;
                pessoa.Numero = NumeroTxT.Text;
                pessoa.Bairro = BairroTxT.Text;
                pessoa.Cidade = CidadeTxT.Text;
                pessoa.Uf = UFTxT.Text;
                pessoa.AtivoPessoa = true;

                var dbResultado = pessoaController.Inserir(pessoa);

                MessageBox.Show(dbResultado.Mensagem);
                if (dbResultado.NumRetorno > 0)
                {
                    this.Close();
                }
            }
        }
    }
}
