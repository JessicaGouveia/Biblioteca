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
    public partial class FmrPreCadastroMidia : Form
    {
        private MidiaController midiaController;
        private IEnumerable<MidiaModel> Midias;

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
                dataGridView1.Rows.Add(item.IdMidia.ToString(), item.NomeMidia, ((item.AtivoMidia) ? "Sim" : "Não"), "Alterar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void FmrCadastro_Closed(object sender, EventArgs e)
        {
            Midias = midiaController.ConsultaTodos();
            AtualizaDataGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastros.FmrCadastroMidia FmrCadastroMidia = new Cadastros.FmrCadastroMidia();
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
            if (e.ColumnIndex == 3)
            {
                int idMidia = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                MessageBox.Show("Precisa abrir a tela para alterar a origem " + idMidia.ToString());
            }
        }
    }
}
