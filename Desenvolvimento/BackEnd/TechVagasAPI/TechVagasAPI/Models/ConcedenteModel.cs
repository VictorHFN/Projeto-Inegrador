﻿using System.ComponentModel.DataAnnotations;

namespace TechVagasAPI.Models
{
	public class ConcedenteModel : PessoaModel
	{
		[Key]
		public int ConcedenteId { get; set; }
		public string? ResponsavelEstagio { get; set; }

	}
}