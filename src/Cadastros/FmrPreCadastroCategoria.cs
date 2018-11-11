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
    public partial class FmrPreCadastroCategoria : Form
    {
        private CategoriaController categoriaController;

        private IEnumerable<CategoriaModel> Categorias;

        public FmrPreCadastroCategoria()
        {
            InitializeComponent();
            categoriaController = new CategoriaController();
            Categorias = categoriaController.ConsultaTodos();

            dataGridView1.ReadOnly = true;
            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in Categorias)
            {
                dataGridView1.Rows.Add(item.IdCategoria.ToString(), item.NomeCategoria, ((item.AtivoCategoria.Value) ? "Sim" : "Não"), "Alterar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrCadastroCategoria FmrCadastro = new FmrCadastroCategoria();
            FmrCadastro.Closed += new EventHandler(FmrCadastro_Closed);
            FmrCadastro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int idCategoria = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                MessageBox.Show("Precisa abrir a tela para alterar a categoria "+ idCategoria.ToString());
            }
        }

        void FmrCadastro_Closed(object sender, EventArgs e)
        {
            Categorias = categoriaController.ConsultaTodos();
            AtualizaDataGrid();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Categorias = categoriaController.ConsultaPorNome(textBox1.Text);
            }
            else
            {
                Categorias = categoriaController.ConsultaTodos();
            }
            AtualizaDataGrid();
        }
    }
}
