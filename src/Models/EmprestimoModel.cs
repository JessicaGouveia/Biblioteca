using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTeca.Models
{
    public class EmprestimoModel
    {
        public int IdEmprestimo { get; set; }
        public int IdMidia { get; set; }
        public int IdPessoa { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int QtdEmprestada { get; set; }
        public int QtdDevolvida { get; set; }
        public string Observacao { get; set; }
        public int IdOperadorEmprestimo { get; set; }
        public int IdOperadorDevolucao { get; set; }
    }
}
