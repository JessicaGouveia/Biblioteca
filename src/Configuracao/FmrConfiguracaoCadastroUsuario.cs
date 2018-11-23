using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;

namespace SystemTeca.Configuracao
{
    public partial class FmrConfiguracaoCadastroUsuario : Form
    {

        private UsuarioController usuarioController;

        private UsuarioModel User;

        public FmrConfiguracaoCadastroUsuario()
        {
            InitializeComponent();

            usuarioController = new UsuarioController();
            User = new UsuarioModel();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FmrConfiguracaoCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(NomeTxT.Text != "" && LoginTxT.Text != "" && SenhaTxT.Text != "")
            {
                User.UsuarioAtivo = true;
                User.LoginUsuario = LoginTxT.Text;
                User.SenhaUsuario = SenhaTxT.Text;

            }
        }
    }
}
