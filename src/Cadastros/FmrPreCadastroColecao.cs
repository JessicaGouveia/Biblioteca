using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemTeca.Cadastros.Alterar;
using SystemTeca.Controllers;
using SystemTeca.Models;

namespace SystemTeca.Cadastros
{
    public partial class FmrPreCadastroColecao : Form
    {
        private ColecaoController colecaoController;
        private IEnumerable<ColecaoModel> Colecao;


        public FmrPreCadastroColecao()
        {
            InitializeComponent();
            colecaoController = new ColecaoController();
            Colecao = colecaoController.ConsultaTodos();

            dataGridView1.ReadOnly = true;
            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in Colecao)
            {
                dataGridView1.Rows.Add(item.IdColecao.ToString(), item.NomeColecao, item.QuantidadeColecao.ToString(), item.VolumeColecaoMidia, ((item.AtivoColecao.Value)? "Sim":"Não"), "Alterar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrCadastroColecao FmrCadastroColecao = new FmrCadastroColecao();
            FmrCadastroColecao.Show();
        }

        void Fmr_Closed(object sender, EventArgs e)
        {
            Colecao = colecaoController.ConsultaTodos();
            AtualizaDataGrid();

        }

        private void Filtrar_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Colecao = colecaoController.ConsultaPorNome(textBox1.Text);
            }
            else
            {
                Colecao = colecaoController.ConsultaTodos();
            }
            AtualizaDataGrid();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int idColecao = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                FmrAlterarColecao FmrAlterar = new FmrAlterarColecao(idColecao);
                FmrAlterar.Closed += new EventHandler(Fmr_Closed);
                FmrAlterar.Show();
            }
        }
    }
}
