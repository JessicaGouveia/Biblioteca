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
            Cadastros.FmrCadastroOrigem FmrCadastroOrigem = new Cadastros.FmrCadastroOrigem();
            FmrCadastroOrigem.Closed += new EventHandler(FmrCadastro_Closed);
            FmrCadastroOrigem.Show();
        }

        void FmrCadastro_Closed(object sender, EventArgs e)
        {
            Origens = origemController.ConsultaTodos();
            AtualizaDataGrid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int idCategoria = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                MessageBox.Show("Precisa abrir a tela para alterar a origem " + idCategoria.ToString());
            }
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
