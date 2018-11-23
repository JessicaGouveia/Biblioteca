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
    public partial class FmrPreCadastroOrigem : Form
    {
        private OrigemController origemController;
        private IEnumerable<OrigemModel> Origens;

        public FmrPreCadastroOrigem()
        {
            InitializeComponent();
            origemController = new OrigemController();
            Origens = origemController.ConsultaTodos();
            AtualizaDataGrid();

        }

        private void AtualizaDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in Origens)
            {
                dataGridView1.Rows.Add(item.IdOrigem.ToString(), item.NomeOrigem, "Alterar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrCadastroOrigem FmrCadastroOrigem = new FmrCadastroOrigem();
            FmrCadastroOrigem.Closed += new EventHandler(Fmr_Closed);
            FmrCadastroOrigem.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int idOrigem = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                FmrAlterarOrigem FmrAlterar = new FmrAlterarOrigem(idOrigem);
                FmrAlterar.Closed += new EventHandler(Fmr_Closed);
                FmrAlterar.Show();
            }
        }

        void Fmr_Closed(object sender, EventArgs e)
        {
            Origens = origemController.ConsultaTodos();
            AtualizaDataGrid();
        }

        private void Filtrar_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Origens = origemController.ConsultaPorNome(textBox1.Text);
            }
            else
            {
                Origens = origemController.ConsultaTodos();
            }
            AtualizaDataGrid();
        }
    }
}
