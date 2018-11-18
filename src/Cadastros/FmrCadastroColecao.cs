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
    public partial class FmrCadastroColecao : Form
    {
        private ColecaoController colecaoController;
        private ColecaoModel Colecao;

        public FmrCadastroColecao()
        {
            InitializeComponent();
            colecaoController = new ColecaoController();
            Colecao = new ColecaoModel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {

            if (NomeTxT.Text != "" && Colecao.AtivoColecao != null && VolumeTxT.Text != "" && InputQuantidade.Value > 0)
            {
                Colecao.NomeColecao = NomeTxT.Text;
                Colecao.VolumeColecaoMidia = VolumeTxT.Text;
                Colecao.QuantidadeColecao = Int32.Parse(InputQuantidade.Text);
                var dbResultado = colecaoController.Inserir(Colecao);
                MessageBox.Show(dbResultado.Mensagem);
                if (dbResultado.NumRetorno > 0)
                {
                    this.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Sim":
                    Colecao.AtivoColecao = true;
                    break;
                default:
                    Colecao.AtivoColecao = false;
                    break;
            }
        }
    }
}
