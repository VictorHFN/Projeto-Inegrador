using System.ComponentModel.DataAnnotations;

namespace TechVagasAPI.Models.Entities
{
    public class AdministradorModel : PessoaModel
    {
        [Key]
        public int AdministradorId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string? Status { get; set; }


    }
}
