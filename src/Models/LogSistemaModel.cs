using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTeca.Models
{
    public class LogSistemaModel
    {
        public int IdLog { get; set; }
        public DateTime DataOperacao { get; set; }
        public string UsuarioOperacao { get; set; }
        public string Descricao { get; set; }
    }
}
