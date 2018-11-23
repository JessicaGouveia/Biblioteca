using System;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;

namespace SystemTeca.Configuracao.Alterar
{
    public partial class FmrAlterarFuncionario : Form
    {

        private PessoaController pessoaController;
        private PessoaModel pessoa;

        public FmrAlterarFuncionario( int idPessoa )
        {
            InitializeComponent();
            pessoaController = new PessoaController();
            pessoa = pessoaController.ConsultaPorId(idPessoa);

            NomeTxT.Text = pessoa.NomePessoa;
            TelefoneTxT.Text = pessoa.NumeroTelefone;
            RGTxT.Text= pessoa.Rg;
            CPFTxT.Text = pessoa.Cpf;
            CEPTxT.Text = pessoa.Cep;
            EnderecoTxT.Text = pessoa.Logradouro;
            NumeroTxT.Text = pessoa.Numero;
            BairroTxT.Text = pessoa.Bairro;
            CidadeTxT.Text = pessoa.Cidade;
            UFTxT.Text = pessoa.Uf;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                UFTxT.Text != "" )
            {

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

                var dbResultado = pessoaController.Atualizar(pessoa);

                MessageBox.Show(dbResultado.Mensagem);

                if (dbResultado.NumRetorno > 0)
                {
                    this.Close();
                }

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxAtivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxAtivo.SelectedItem.ToString())
            {
                case "Sim":
                    pessoa.AtivoPessoa = true;
                    break;
                default:
                    pessoa.AtivoPessoa = false;
                    break;
            }
        }

    }
}
