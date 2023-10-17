using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechVagasAPI.Context;
using TechVagasAPI.Dtos.Entities;
using TechVagasAPI.Models.Entities;

namespace TechVagasAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PessoaController : ControllerBase
	{
		private readonly AppDbContext _context;

		public PessoaController(AppDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public ActionResult<IEnumerable<PessoaModel>> Get()
		{
			var pessoa = _context.Pessoas.ToList();
			if (pessoa is null) 
			{
				return NotFound("Pessoas não encontradas");
			}
			return pessoa;
		}

		[HttpGet("{id:int}", Name = "ObterPessoa")]
		public ActionResult<PessoaModel> Get(int id)
		{
			var pessoa = _context.Pessoas.FirstOrDefault(p => p.PessoaId == id);
			if (pessoa is null)
			{
				return NotFound("Pessoas não encontrado");
			}
			return pessoa;
		}

		[HttpPost]
		public ActionResult Post(PessoaModel pessoa)
		{
			if (pessoa is null)
				return BadRequest();

			_context.Pessoas.Add(pessoa);
			_context.SaveChanges();

			return new CreatedAtRouteResult("ObterPessoa",
				new { id = pessoa.PessoaId }, pessoa);
		}

		[HttpPut("{id:int}")]
		public ActionResult Put(int id, PessoaModel pessoa)
		{
			if (id != pessoa.PessoaId)
			{
				return BadRequest();
			}
			_context.Entry(pessoa).State = EntityState.Modified;
			_context.SaveChanges();

			return Ok(pessoa);
		}
	}
}
