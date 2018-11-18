namespace SystemTeca.Models
{
    public class CategoriaModel
    {
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public bool? AtivoCategoria { get; set; }
        public bool DeletadoCategoria { get; set; }

        public override string ToString()
        {
            return NomeCategoria;
        }
    }
}
