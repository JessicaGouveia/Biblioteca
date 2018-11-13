using System;
using System.Windows.Forms;


namespace SystemTeca
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (LoginTxT.Text != "" && SenhaTxT.Text != "")
            {
                if (Usuario.Autenticacao(LoginTxT.Text, SenhaTxT.Text)) {
                    this.Visible = false;

                    // Cria o Formulario
                    FmrIndex fmr = new FmrIndex();

                    // Abri o Formulario
                    fmr.Show();
                }
                else
                {
                    MessageBox.Show("Login ou Senha inválido." , "Erro de Login" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informe o usuário e a senha.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
