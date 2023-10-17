using System.ComponentModel.DataAnnotations;

namespace TechVagasAPI.Dtos.Entities;

public class ConcedenteDto
{
	public int ConcedenteId { get; set; }

	[Required(ErrorMessage = "Informe o Responsável")]
	[MinLength(3)]
	[MaxLength(100)]
	public string? ResponsavelEmpresa { get; set; }
}
