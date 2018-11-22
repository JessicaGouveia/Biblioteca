using System;
using System.Windows.Forms;
using SystemTeca.Controllers;
using SystemTeca.Models;
using SystemTeca.Queries;

namespace SystemTeca
{
    public partial class FmrDevolucao : Form
    {
        private EmprestimoController emprestimoController;
        private EmprestimoQuery emprestimo;
        private EmprestimoModel emprestimoModel;

        public FmrDevolucao(int idEmprestimo)
        {
            InitializeComponent();

            emprestimoController = new EmprestimoController();
            emprestimo = emprestimoController.ConsultaPorId(idEmprestimo);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
