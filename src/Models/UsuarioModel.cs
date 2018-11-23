using System;

namespace SystemTeca.Models
{
    public class UsuarioModel
    {
        public int IdPEssoa { get; set; }
        public string LoginUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public bool? UsuarioAtivo { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
