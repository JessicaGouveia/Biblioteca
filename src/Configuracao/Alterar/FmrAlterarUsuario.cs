using System;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;

namespace SystemTeca.Configuracao.Alterar
{
    public partial class FmrAlterarUsuario : Form
    {

        private UsuarioController usuarioController;

        private UsuarioModel Usuario;

        public FmrAlterarUsuario( int ID )
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
            Usuario = usuarioController.ConsultaPorId(ID);

            LoginTxT.Text = Usuario.LoginUsuario;
            SenhaTxT.Text = Usuario.SenhaUsuario;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (LoginTxT.Text != "" && SenhaTxT.Text != "")
            {
                Usuario.LoginUsuario = LoginTxT.Text;
                Usuario.SenhaUsuario = SenhaTxT.Text;

                var dbResultado = usuarioController.Atualizar(Usuario);

                MessageBox.Show(dbResultado.Mensagem);

                if (dbResultado.NumRetorno > 0)
                {
                    this.Close();
                }

            }
        }
    }
}
