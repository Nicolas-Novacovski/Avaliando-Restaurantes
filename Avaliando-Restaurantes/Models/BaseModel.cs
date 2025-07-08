using System.ComponentModel.DataAnnotations;

namespace Avaliando_Restaurantes.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = null;
        public int Status { get; set; } = 0;
    }
}
