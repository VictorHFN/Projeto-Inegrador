namespace TechVagasAPI.Models.Entities
{
    public class PessoaModel
    {
        public int PessoaId { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Rg { get; set; }
        public string? Cpf { get; set; }
        public string? Cidade { get; set; }
        public string? Cep { get; set; }
        public string? Genero { get; set; }
        public string? Bairro { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? NivelEscolaridade { get; set; }
        public string? Endereco { get; set; }

    }
}
