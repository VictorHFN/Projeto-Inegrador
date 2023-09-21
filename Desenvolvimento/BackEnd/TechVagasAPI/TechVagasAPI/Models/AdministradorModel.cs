using System.ComponentModel.DataAnnotations;

namespace TechVagasAPI.Models
{
	public class AdministradorModel : PessoaModel
	{
		[Key]
		public int AdministradorId { get; set; }
		public DateTime DataCadastro { get; set; }
		public string? Status { get; set; }


	}
}
