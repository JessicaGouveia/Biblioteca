using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTeca.Models
{
    public class PessoaModel
    {
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string NumeroTelefone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public bool AtivoPessoa { get; set; }
        public DateTime DataCriacao { get; set; }

        public override string ToString()
        {
            return NomePessoa;
        }
    }
}
