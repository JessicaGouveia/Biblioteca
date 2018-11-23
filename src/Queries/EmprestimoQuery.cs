using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTeca.Queries
{
    public class EmprestimoQuery
    {
        public int IdEmprestimo { get; set; }
        public int IdMidia { get; set; }
        public string NomeMidia { get; set; }
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public int QtdEmprestada { get; set; }
        public int QtdDevolvida { get; set; }
        public string Observacao { get; set; }
        public int IdOperadorEmprestimo { get; set; }
        public string NomeOperadorEmprestimo { get; set; }
        public int IdOperadorDevolucao { get; set; }
        public string NomeOperadorDevolucao { get; set; }
    }
}
