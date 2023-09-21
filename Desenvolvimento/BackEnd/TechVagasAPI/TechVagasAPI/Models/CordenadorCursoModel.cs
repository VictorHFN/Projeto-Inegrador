using System.ComponentModel.DataAnnotations;

namespace TechVagasAPI.Models
{
	public class CordenadorCursoModel: PessoaModel
	{

		[Key]
		public int CordenadorCursoId { get; set; }
		public DateTime DataCadastro { get; set; }
		public string? Status { get; set; }
	}
}
