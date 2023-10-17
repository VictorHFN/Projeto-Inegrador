using System.ComponentModel.DataAnnotations;

namespace TechVagasAPI.Models.Entities
{
    public class CordenadorEstagioModel : PessoaModel
    {
        [Key]
        public int CordenadorEstagioId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string? Status { get; set; }
    }
}
