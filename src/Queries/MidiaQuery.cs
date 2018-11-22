using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTeca.Queries
{
    public class MidiaQuery
    {
        public int IdMidia { get; set; }
        public int? IdColecao { get; set; }
        public string NomeColecao { get; set; }
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public int IdOrigem { get; set; }
        public string NomeOrigem { get; set; }
        public string NomeMidia { get; set; }
        public int QuantidadeMidia { get; set; }
        public string LetradoAlfabeto { get; set; }
        public int Numero { get; set; }
        public bool AtivoMidia { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool DeletadoMidia { get; set; }
        public bool DisponivelEmprestimo { get; set; }
        public int QtdDisponivelEmprestimo { get; set; }

        public override string ToString()
        {
            return NomeMidia+" - "+LetradoAlfabeto+" "+Numero.ToString();
        }
    }
}
