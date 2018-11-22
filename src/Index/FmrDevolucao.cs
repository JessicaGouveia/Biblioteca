using System;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;
using SystemTeca.Queries;

namespace SystemTeca
{
    public partial class FmrDevolucao : Form
    {
        private EmprestimoController emprestimoController;
        private EmprestimoQuery emprestimo;
        private EmprestimoModel emprestimoModel;

        public FmrDevolucao(int idEmprestimo)
        {
            InitializeComponent();

            emprestimoController = new EmprestimoController();
            emprestimo = emprestimoController.ConsultaPorId(idEmprestimo);

            IdTxt.Text = emprestimo.IdEmprestimo.ToString();
            PessoaTxt.Text = emprestimo.NomePessoa;
            MidiaTxt.Text = emprestimo.NomeMidia;
            QuantidadeTxt.Text = emprestimo.QtdEmprestada.ToString();
            DataSaidaTxt.Text = emprestimo.DataSaida.ToString();
            OperadorTxt.Text = emprestimo.NomeOperadorEmprestimo;
            ObsEmprestimo.Text = emprestimo.Observacao;

            QuantidadeDevolvidaNumeric.Value = emprestimo.QtdEmprestada;
            QuantidadeDevolvidaNumeric.Maximum = emprestimo.QtdEmprestada;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                QuantidadeDevolvidaNumeric.Value > 0
            ||  (
                    QuantidadeDevolvidaNumeric.Value == 0
                &&  ObservacaoTextArea.Text.Length >= 10
                )
            )
            {
                string observacao = ((emprestimo.Observacao.Length > 0)? "Observação do Emprestimo:\n"+emprestimo.Observacao:null);

                if (QuantidadeDevolvidaNumeric.Value == 0)
                {
                    observacao += ((observacao.Length > 0) ? "\n\nJustificativa:\n" + ObservacaoTextArea.Text : "Justificativa:\n" + ObservacaoTextArea.Text);
                }else if (ObservacaoTextArea.Text.Length > 0)
                {
                    observacao += ((observacao.Length > 0) ? "\n\nObservação da Devolução:\n" + ObservacaoTextArea.Text : "Observação da Devolução:\n" + ObservacaoTextArea.Text);
                }

                emprestimoModel = new EmprestimoModel()
                {
                    IdEmprestimo = emprestimo.IdEmprestimo,
                    QtdDevolvida = Int32.Parse(QuantidadeDevolvidaNumeric.Text),
                    Observacao = observacao
                };

                var dbResult = emprestimoController.InserirDevolucao(emprestimoModel);

                MessageBox.Show(dbResult.Mensagem);

                if (dbResult.NumRetorno > 0)
                {
                    this.Close();
                }
            }
            else if (QuantidadeDevolvidaNumeric.Value == 0 && ObservacaoTextArea.Text.Length < 10)
            {
                MessageBox.Show("Informe a justificativa.");
            }
            else
            {
                MessageBox.Show("Informe a quantidade devolvida.");
            }
        }

        private void QuantidadeDevolvidaNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (QuantidadeDevolvidaNumeric.Value == 0)
            {
                labelObsJust.Text = "*Justificativa:";
            }
            else
            {
                labelObsJust.Text = "Observação:";
            }
        }
    }
}
