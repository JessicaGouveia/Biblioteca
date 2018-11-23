using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;
using SystemTeca.Queries;

namespace SystemTeca
{
    public partial class FmrEmprestimo : Form
    {
        private EmprestimoController emprestimoController;
        private EmprestimoModel emprestimoModel;

        private PessoaController pessoaController;
        private CategoriaController categoriaController;
        private MidiaController midiaController;

        private IEnumerable<PessoaModel> pessoas;
        private IEnumerable<CategoriaModel> categorias;
        private IEnumerable<MidiaQuery> midias;

        public FmrEmprestimo()
        {
            InitializeComponent();

            emprestimoController = new EmprestimoController();

            pessoaController = new PessoaController();
            categoriaController = new CategoriaController();
            midiaController = new MidiaController();

            pessoas = pessoaController.ConsultaTodosAtivos();
            categorias = categoriaController.ConsultaTodosAtivos();
            midias = midiaController.ConsultaTodosAtivos();

            foreach (var pessoa in pessoas)
            {
                PessoaComboBox.Items.Add(pessoa);
            }

            foreach (var categoria in categorias)
            {
                CategoriaComboBox.Items.Add(categoria);
            }

            foreach (var midia in midias.Where(m => m.DisponivelEmprestimo))
            {
                MidiaComboBox.Items.Add(midia);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pessoa = PessoaComboBox.SelectedItem as PessoaModel;
            var midia = MidiaComboBox.SelectedItem as MidiaQuery;

            if (
                pessoa != null && pessoa.IdPessoa != null
            &&  midia != null && midia.IdMidia != null
            &&  QuantidadeNumericUpDown.Value > 0
            )
            {
                emprestimoModel = new EmprestimoModel()
                {
                    IdMidia = midia.IdMidia,
                    IdPessoa = pessoa.IdPessoa,
                    QtdEmprestada = Int32.Parse(QuantidadeNumericUpDown.Text),
                    Observacao = ObservacaoTextArea.Text
                };

                var dbResult = emprestimoController.InserirEmprestimo(emprestimoModel);

                MessageBox.Show(dbResult.Mensagem);

                if (dbResult.NumRetorno > 0)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os campos obrigatório com *, se o problema persistir selecione novamente as opções.");
            }
        }

        private void CategoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoria = CategoriaComboBox.SelectedItem as CategoriaModel;

            MidiaComboBox.Items.Clear();
            MidiaComboBox.Text = "";
            QuantidadeNumericUpDown.Value = 1;

            if (categoria != null && categoria.IdCategoria != null)
            {
                midias = midiaController.ConsultaPorCategoria(categoria.IdCategoria);
            }
            else
            {
                midias = midiaController.ConsultaTodosAtivos();
            }

            foreach (var midia in midias.Where(m => m.DisponivelEmprestimo))
            {
                MidiaComboBox.Items.Add(midia);
            }
        }

        private void MidiaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var midia = MidiaComboBox.SelectedItem as MidiaQuery;

            QuantidadeNumericUpDown.Value = 1;

            if (midia != null && midia.IdMidia != null)
            {
                QuantidadeNumericUpDown.Maximum = midia.QtdDisponivelEmprestimo;
            }
        }
    }
}
