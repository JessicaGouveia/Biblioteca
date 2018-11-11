using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTeca.Models
{
    public class ColecaoModel
    {
        public int IdColecao { get; set; }
        public string NomeColecao { get; set; }
        public int QuantidadeColecao { get; set; }
        public string VolumeColecao { get; set; }
        public bool AtivoColecao { get; set; }
        public bool DeletadoColecao { get; set; }
        public DateTime DataCriacao { get; set; }

    }
}
