using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;

namespace SystemTeca.Configuracao
{
    public partial class FmrConfiguracaoPreCadastroUsuario : Form
    {

        private UsuarioController usuarioController;

        private IEnumerable<UsuarioModel> Usuario;

        public FmrConfiguracaoPreCadastroUsuario()
        {
            InitializeComponent();

            usuarioController = new UsuarioController();
            Usuario = usuarioController.ConsultaTodos();

            DataGrid.ReadOnly = true;
            AtualizaDataGrid();
        }

        private void DataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int idPessoa = Int32.Parse(DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                Alterar.FmrAlterarUsuario FmrAlterar = new Alterar.FmrAlterarUsuario(idPessoa);
                FmrAlterar.Closed += new EventHandler(Fmr_Closed);
                FmrAlterar.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrConfiguracaoCadastroUsuario FormCadastroUsuario = new FmrConfiguracaoCadastroUsuario();
            FormCadastroUsuario.Show();
        }

        private void AtualizaDataGrid()
        {
            DataGrid.Rows.Clear();
            foreach (var item in Usuario)
            {
                DataGrid.Rows.Add(item.IdPEssoa.ToString(), item.LoginUsuario, ((item.UsuarioAtivo.Value) ? "Sim" : "Não") , "Alterar");
            }
        }

        private void Filtrar_Button_Click(object sender, EventArgs e)
        {
            if (Pesquisa_txt.Text != "")
            {
                Usuario = usuarioController.ConsultaPorNome(Pesquisa_txt.Text);
            }
            else
            {
                Usuario = usuarioController.ConsultaTodos();
            }
            AtualizaDataGrid();
        }

        void Fmr_Closed(object sender, EventArgs e)
        {
            Usuario = usuarioController.ConsultaTodosAtivos();
            AtualizaDataGrid();

        }

        private void DataGrid_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int idPessoa = Int32.Parse(DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                Alterar.FmrAlterarUsuario FmrAlterar = new Alterar.FmrAlterarUsuario(idPessoa);
                FmrAlterar.Show();
                FmrAlterar.Closed += new EventHandler(Fmr_Closed);
            }
        }
    }
}
