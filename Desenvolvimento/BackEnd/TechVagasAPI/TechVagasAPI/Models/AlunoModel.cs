using System.ComponentModel.DataAnnotations;

namespace TechVagasAPI.Models
{
	public class AlunoModel : PessoaModel
	{
		[Key]
		public int AlunoId { get; set; }
		public string? Status { get; set; }
		public string? NumeroMatricula { get; set; }
		public string? AreaInteresse { get; set;}
		public string? Habilidades { get; set;}
		public string? Experiencias { get; set; }
		public string? DisponibilidadeHorario { get; set; }
		public string? Curriculo { get; set; }
	}
}
