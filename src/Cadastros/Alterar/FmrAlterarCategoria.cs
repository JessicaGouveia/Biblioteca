using System;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;

namespace SystemTeca.Cadastros.Alterar
{
    public partial class FmrAlterarCategoria : Form
    {
        private CategoriaController categoriaController;
        private CategoriaModel categoria;

        public FmrAlterarCategoria(int idCategoria)
        {
            InitializeComponent();
            categoriaController = new CategoriaController();
            categoria = categoriaController.ConsultaPorId(idCategoria);

            Nome_txt.Text = categoria.NomeCategoria;
            comboBox1.SelectedIndex = comboBox1.FindStringExact(((categoria.AtivoCategoria.Value)? "Sim":"Não"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nome_txt.Text != "" && categoria.AtivoCategoria != null)
            {
                categoria.NomeCategoria = Nome_txt.Text;
                var dbResultado = categoriaController.Atualizar(categoria);
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
                    categoria.AtivoCategoria = true;
                    break;
                default:
                    categoria.AtivoCategoria = false;
                    break;
            }
        }
    }
}
