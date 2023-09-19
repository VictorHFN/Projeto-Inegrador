using System.ComponentModel.DataAnnotations;

namespace TechVagasAPI.Models
{
    public class CargoModel
    {
        [Key]
        public int CargoId { get; set; }
        public string? Descricao { get; set; }
        public string? Tipo { get; set; }
    }
}
