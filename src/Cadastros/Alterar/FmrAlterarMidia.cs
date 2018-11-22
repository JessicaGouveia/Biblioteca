using System;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;

namespace SystemTeca.Cadastros.Alterar
{
    public partial class FmrAlterarMidia : Form
    {
        private MidiaController midiaController;
        private MidiaModel midia;

        private ColecaoController colecaoController;
        private CategoriaController categoriaController;
        private OrigemController origemController;

        public FmrAlterarMidia(int idMidia)
        {
            InitializeComponent();

            midiaController = new MidiaController();
            
            var consultaMidia = midiaController.ConsultaPorId(idMidia);
            midia = new MidiaModel()
            {
                IdMidia = consultaMidia.IdMidia,
                IdColecao = consultaMidia.IdColecao,
                IdCategoria = consultaMidia.IdCategoria,
                IdOrigem = consultaMidia.IdOrigem,
                NomeMidia = consultaMidia.NomeMidia,
                QuantidadeMidia = consultaMidia.QuantidadeMidia,
                LetraAlfabeto = consultaMidia.LetradoAlfabeto,
                Numero =  consultaMidia.Numero,
                AtivoMidia = consultaMidia.AtivoMidia,
                DeletadoMdia = consultaMidia.DeletadoMidia,
                DataCriacao = consultaMidia.DataCriacao
            };

            

            colecaoController = new ColecaoController();
            categoriaController = new CategoriaController();
            origemController = new OrigemController();


            foreach (var item in colecaoController.ConsultaTodosAtivos())
            {
                Coleção_ComboBox.Items.Add(item);
            }

            foreach (var item in categoriaController.ConsultaTodosAtivos())
            {
                Categoria_ComboBox.Items.Add(item);
            }

            foreach (var item in origemController.ConsultaTodos())
            {
                Origem_ComboBox.Items.Add(item);
            }

            if (consultaMidia.IdColecao != null)
            {
                Check_Possui_Colecao.Checked = true;
                Coleção_ComboBox.Enabled = true;
                Coleção_ComboBox.SelectedIndex = Coleção_ComboBox.FindStringExact(consultaMidia.NomeColecao);
            }
            else
            {
                Check_Possui_Colecao.Checked = false;
                Coleção_ComboBox.Enabled = false;
            }
            Categoria_ComboBox.SelectedIndex = Categoria_ComboBox.FindStringExact(consultaMidia.NomeCategoria);
            Origem_ComboBox.SelectedIndex = Origem_ComboBox.FindStringExact(consultaMidia.NomeOrigem);
            NomeTxT.Text = midia.NomeMidia;
            QuantidadeNumeric.Value = midia.QuantidadeMidia;
            LetraComboBox.SelectedIndex = LetraComboBox.FindStringExact(midia.LetraAlfabeto);
            NumeroNumeric.Value = midia.Numero;
            comboBox2.SelectedIndex = comboBox2.FindStringExact(((midia.AtivoMidia)? "Sim":"Não"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NomeTxT.Text != ""
                && (
                    (Check_Possui_Colecao.Checked && midia.IdColecao != null)
                    || (!Check_Possui_Colecao.Checked && midia.IdColecao == null)
                )
                && midia.IdCategoria != null
                && midia.IdOrigem != null
                && midia.NomeMidia != ""
                && QuantidadeNumeric.Value > 0
                && midia.LetraAlfabeto != ""
                && NumeroNumeric.Value > 0
                && midia.AtivoMidia != null
            )
            {
                midia.NomeMidia = NomeTxT.Text;
                midia.QuantidadeMidia = Int32.Parse(QuantidadeNumeric.Text);
                midia.Numero = Int32.Parse(NumeroNumeric.Text);
                var dbResultado = midiaController.Atualizar(midia);
                MessageBox.Show(dbResultado.Mensagem);
                if (dbResultado.NumRetorno > 0)
                {
                    this.Close();
                }
            }
        }

        private void Check_Possui_Colecao_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_Possui_Colecao.Checked)
            {
                Coleção_ComboBox.Enabled = true;
            }
            else
            {
                Coleção_ComboBox.SelectedIndex = 0;
                Coleção_ComboBox.Enabled = false;
                midia.IdColecao = null;

            }
        }

        private void Coleção_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var colecao = Coleção_ComboBox.SelectedItem as ColecaoModel;
            midia.IdColecao = colecao.IdColecao;
        }

        private void Categoria_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoria = Categoria_ComboBox.SelectedItem as CategoriaModel;
            midia.IdCategoria = categoria.IdCategoria;
        }

        private void Origem_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var origem = Origem_ComboBox.SelectedItem as OrigemModel;
            midia.IdOrigem = origem.IdOrigem;
        }

        private void LetraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            midia.LetraAlfabeto = LetraComboBox.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Sim":
                    midia.AtivoMidia = true;
                break;
                default:
                    midia.AtivoMidia = false;
                break;
            }
        }
    }
}
