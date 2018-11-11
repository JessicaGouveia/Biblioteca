using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemTeca.Pesquisa
{
    public partial class FmrPesquisa : Form
    {
        public FmrPesquisa()
        {
            InitializeComponent();
        }

        public FmrPesquisa(string Tipo , string Valor)
        {
            InitializeComponent();

            labelTipo.Text = Tipo;
            labelNome.Text = Valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
