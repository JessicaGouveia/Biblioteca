using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemTeca.Cadastros
{
    public partial class FmrCadastroOrigem : Form
    {
        public FmrCadastroOrigem()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Nome = NomeTxT.Text;

            // FUnção de criação no Banco
        }
    }
}
