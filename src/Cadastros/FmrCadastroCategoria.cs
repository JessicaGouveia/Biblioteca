using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Data;
using SystemTeca.Models;

namespace SystemTeca.Cadastros
{
    public partial class FmrCadastroCategoria : Form
    {
        private CategoriaController categoriaController;
        private CategoriaModel categoria;

        public FmrCadastroCategoria()
        {
            InitializeComponent();
            categoriaController = new CategoriaController();
            categoria = new CategoriaModel();
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
                var dbResultado = categoriaController.Inserir(categoria);
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
