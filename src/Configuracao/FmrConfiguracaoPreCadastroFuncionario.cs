using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;

namespace SystemTeca.Configuracao
{
    public partial class FmrConfiguracaoPreCadastroFuncionario : Form
    {

        private PessoaController pessoaController;

        private IEnumerable<PessoaModel> Pessoa;

        public FmrConfiguracaoPreCadastroFuncionario()
        {
            InitializeComponent();
            pessoaController = new PessoaController();
            Pessoa = pessoaController.ConsultaTodos();

            DataGrid.ReadOnly = true;
            AtualizaDataGrid();
        }

        private void DataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int idPessoa = Int32.Parse(DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                Alterar.FmrAlterarFuncionario FmrAlterar = new Alterar.FmrAlterarFuncionario(idPessoa);
                FmrAlterar.Closed += new EventHandler(Fmr_Closed);
                FmrAlterar.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrConfiguracaoCadastroFuncionario FormCadastroFuncionario = new FmrConfiguracaoCadastroFuncionario();
            FormCadastroFuncionario.Closed += new EventHandler(Fmr_Closed);
            FormCadastroFuncionario.Show();
        }

        private void AtualizaDataGrid()
        {
            DataGrid.Rows.Clear();
            foreach (var item in Pessoa)
            {
                DataGrid.Rows.Add(item.IdPessoa.ToString(), item.NomePessoa, (item.AtivoPessoa.Value) ? "Sim" : "Não", "Alterar");
            }
        }

        private void Filtrar_Button_Click(object sender, EventArgs e)
        {
            if (Pesquisa_txt.Text != "")
            {
                Pessoa = pessoaController.ConsultaPorNome(Pesquisa_txt.Text);
            }
            else
            {
                Pessoa = pessoaController.ConsultaTodos();
            }
            AtualizaDataGrid();
        }

        void Fmr_Closed(object sender, EventArgs e)
        {
            Pessoa = pessoaController.ConsultaTodosAtivos();
            AtualizaDataGrid();

        }
    }
}
