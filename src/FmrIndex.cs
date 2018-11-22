using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;
using SystemTeca.Queries;

namespace SystemTeca
{
    public partial class FmrIndex : Form
    {
        private EmprestimoController emprestimoController;
        private IEnumerable<EmprestimoQuery> emprestimos;

        // Formularios de Consulta
        Consulta.FmrConsultaCD FmrConsultaCD = new Consulta.FmrConsultaCD();
        Consulta.FmrConsultaColecao FmrConsultaColecao = new Consulta.FmrConsultaColecao();
        Consulta.FmrConsultaDVD FmrConsultaDVD = new Consulta.FmrConsultaDVD();
        Consulta.FmrConsultaFantoches FmrConsultaFantoches = new Consulta.FmrConsultaFantoches();
        Consulta.FmrConsultaLivros FmrConsultaLivros = new Consulta.FmrConsultaLivros();
        Consulta.FmrConsultaLivrosPU FmrConsultaLivrosPU = new Consulta.FmrConsultaLivrosPU();
        Consulta.FmrConsulta_Usuarios FmrConsulta_Usuarios = new Consulta.FmrConsulta_Usuarios();

        public FmrIndex()
        {
            InitializeComponent();
            NomeLogin.Text = Usuario.LoginUsuario.NomePessoa;

            emprestimoController = new EmprestimoController();

            AtualizaDataGrid();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    Application.Exit();
        }

        private void cadastroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cadastro de Usuario
            Configuracao.FmrConfiguracaoPreCadastroUsuario FormPreCadastroUsuario = new Configuracao.FmrConfiguracaoPreCadastroUsuario();
            FormPreCadastroUsuario.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cadastro de Funcionario
            Configuracao.FmrConfiguracaoPreCadastroFuncionario FormPreCadastroFuncionario = new Configuracao.FmrConfiguracaoPreCadastroFuncionario();
            FormPreCadastroFuncionario.Show();
        }

        private void mídiaDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cadastro de Midia
            Cadastros.FmrPreCadastroMidia FmrPreCadastroMidia = new Cadastros.FmrPreCadastroMidia();
            FmrPreCadastroMidia.Show();
        }

        private void cadastroDeOrigemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cadastro de Origem
            Cadastros.FmrPreCadastroOrigem FmrPreCadastroOrigem = new Cadastros.FmrPreCadastroOrigem();
            FmrPreCadastroOrigem.Show();
        }

        private void cadastroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cadastro de Categoria
            Cadastros.FmrPreCadastroCategoria FmrPreCadastroCategoria = new Cadastros.FmrPreCadastroCategoria();
            FmrPreCadastroCategoria.Show();
        }

        private void cDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrConsultaCD.Show();
        }

        private void coleçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrConsultaColecao.Show();
        }

        private void dVDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrConsultaDVD.Show();
        }

        private void fantochesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrConsultaFantoches.Show();
        }

        private void midiaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrConsultaLivros.Show();
        }

        private void mídiaDigitalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrConsultaLivrosPU.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrConsulta_Usuarios.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Emprestimo
            FmrEmprestimo fmrEmprestimo = new FmrEmprestimo();
            fmrEmprestimo.Closed += new EventHandler(FmrClose);
            fmrEmprestimo.Show();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            // Relatorios
            FmrRelatorios FmrRelatorios = new FmrRelatorios();
            FmrRelatorios.Show();
        }

        private void FmrIndex_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pesquisa.FmrPesquisa FmrPesquisa = new Pesquisa.FmrPesquisa(PesquisaBox.Text, PesquisaTxT.Text );

            FmrPesquisa.Show();

        }

        private void cadstroDeColeçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FmrPreCadastroColecao FmrPreCadastroColecao = new Cadastros.FmrPreCadastroColecao();
            FmrPreCadastroColecao.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda.FmrAjudaSobre FmrAjuda = new Ajuda.FmrAjudaSobre();

            FmrAjuda.Show();
        }

        private void NomeLogin_Click(object sender, EventArgs e)
        {

        }

        private void FmrClose(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            emprestimos = emprestimoController.ConsultaTodosNaoDevolvido();

            dataGridView1.Rows.Clear();

            foreach (var item in emprestimos)
            {
                dataGridView1.Rows.Add("Devolução", item.IdEmprestimo.ToString(), item.NomeMidia, item.NomePessoa, item.QtdEmprestada, item.DataSaida.ToString(), item.Observacao, item.NomeOperadorEmprestimo);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int idEmprestimo = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

                FmrDevolucao fmrDevolucao = new FmrDevolucao(idEmprestimo);
                fmrDevolucao.Closed += new EventHandler(FmrClose);
                fmrDevolucao.Show();
            }
        }
    }
}
