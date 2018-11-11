using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemTeca
{
    public partial class FmrEmprestimo : Form
    {
        public FmrEmprestimo()
        {
            InitializeComponent();
            Nome_Usuario_txt.Text = Usuario.LoginUsuario.NomePessoa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
