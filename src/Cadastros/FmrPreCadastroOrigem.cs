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
    public partial class FmrPreCadastroOrigem : Form
    {
        public FmrPreCadastroOrigem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastros.FmrCadastroOrigem FmrCadastroOrigem = new Cadastros.FmrCadastroOrigem();
            FmrCadastroOrigem.Show();
        }
    }
}
