using System.ComponentModel.DataAnnotations;
using TechVagasAPI.Models.Entities;

namespace TechVagasAPI.Dtos.Entities
{
	public class PessoaDto
	{
		public int PessoaId { get; set; }

		[Required(ErrorMessage = "Informe seu Nome")]
		[MinLength(3)]
		[MaxLength(100)]
		public string? Nome { get; set; }

		[Required(ErrorMessage = "Informe sua Idade")]
		public int Idade { get; set; }

		[Required(ErrorMessage = "Informe o Rg")]
		public string? Rg { get; set; }

		[Required(ErrorMessage = "Informe o Cpf")]
		public string? Cpf { get; set; }

		[Required(ErrorMessage = "Informe a Cidade")]
		public string? Cidade { get; set; }

		[Required(ErrorMessage = "Informe o Cep")]
		public string? Cep { get; set; }
		public string? Genero { get; set; }

		[Required(ErrorMessage = "Informe seu Bairro")]
		public string? Bairro { get; set; }

		[Required(ErrorMessage = "Informe um Email")]
		public string? Email { get; set; }

		[Required(ErrorMessage = "Informe um Telefone")]
		public string? Telefone { get; set; }

		[Required(ErrorMessage = "Informe sua data de Nascimento")]
		public DateTime DataNascimento { get; set; }

		[Required(ErrorMessage = "Informe seu nivel de Escolaridade")]
		public string? NivelEscolaridade { get; set; }

		[Required(ErrorMessage = "Informe seu Endereço")]
		public string? Endereco { get; set; }
	}
}
