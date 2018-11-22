using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SystemTeca.Cadastros.Alterar;
using SystemTeca.Controllers;
using SystemTeca.Queries;

namespace SystemTeca.Cadastros
{
    public partial class FmrPreCadastroMidia : Form
    {
        private MidiaController midiaController;
        private IEnumerable<MidiaQuery> Midias;

        public FmrPreCadastroMidia()
        {
            InitializeComponent();
            midiaController = new MidiaController();
            Midias = midiaController.ConsultaTodos();
            AtualizaDataGrid();
        }


        private void AtualizaDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in Midias)
            {
                dataGridView1.Rows.Add(item.IdMidia.ToString(), item.NomeMidia, item.NomeCategoria, item.QuantidadeMidia, item.NomeOrigem, item.LetradoAlfabeto, item.Numero, item.NomeColecao, ((item.AtivoMidia) ? "Sim" : "Não"), "Alterar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void Fmr_Closed(object sender, EventArgs e)
        {
            Midias = midiaController.ConsultaTodos();
            AtualizaDataGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrCadastroMidia FmrCadastroMidia = new FmrCadastroMidia();
            FmrCadastroMidia.Closed += new EventHandler(Fmr_Closed);
            FmrCadastroMidia.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Midias = midiaController.ConsultaPorNome(textBox1.Text);
            }
            else
            {
                Midias = midiaController.ConsultaTodos();
            }
            AtualizaDataGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                int idMidia = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                FmrAlterarMidia FmrAlterarMidia = new FmrAlterarMidia(idMidia);
                FmrAlterarMidia.Closed += new EventHandler(Fmr_Closed);
                FmrAlterarMidia.Show();
            }
        }
    }
}
