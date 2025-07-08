using System.ComponentModel.DataAnnotations.Schema;

namespace Avaliando_Restaurantes.Models
{
    [Table ("Restaurantes")]
    public class Restaurantes : BaseModel
    {
        public Restaurantes()
        {
            CreatedAt = DateTime.Now;
            Status = 0;
        }

        public string NomeLocal { get; set; }
        public string Endereco { get; set; }
        public string TipoLocal { get; set; }
        public string TipoCulinaria { get; set; }
        public string? Descricao { get; set; }
        public float ValorGasto { get; set; }
        public string MediaValor { get; set; }
        public string Avaliacao { get; set; }
    }
}
