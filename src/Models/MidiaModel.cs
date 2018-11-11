using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTeca.Models
{
    public class MidiaModel
    {
        public int IdMidia { get; set; }
        public int IdColecao { get; set; }
        public int IdCotegoria { get; set; }
        public int IdOrigem { get; set; }
        public string NomeMdia { get; set; }
        public int QuantidadeMidia  { get; set; }
        public string LetraAlfabeto { get; set; }
        public int Numero { get; set; }
        public bool AtivoMidia { get; set; }
        public bool DeletadoMdia { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
