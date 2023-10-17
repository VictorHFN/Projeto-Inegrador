using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechVagasAPI.Context;
using TechVagasAPI.Models.Entities;

namespace TechVagasAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ConcedenteController : ControllerBase
	{
		private readonly AppDbContext _context;

		public ConcedenteController(AppDbContext context) 
		{
			_context = context;
		}

		[HttpGet]
		public ActionResult<IEnumerable<ConcedenteModel>> Get()
		{
			var concedente = _context.Concedentes.ToList();
			if (concedente is null)
			{
				return NotFound("Concedentes não encontrados");
			}
			return concedente;
		}

		[HttpGet("{id:int}", Name = "ObterConcedente")]
		public ActionResult<ConcedenteModel> Get(int id)
		{
			var concedente = _context.Concedentes.FirstOrDefault(c => c.ConcedenteId == id);
			if (concedente is null)
			{
				return NotFound("Concedentes não encontrados");
			}
			return concedente;
		}

		[HttpPost]
		public ActionResult Post(ConcedenteModel concedente)
		{
			if (concedente is null)
				return BadRequest();

			_context.Concedentes.Add(concedente);
			_context.SaveChanges();

			return new CreatedAtRouteResult("ObterConcedente",
				new { id = concedente.ConcedenteId }, concedente);
		}

		[HttpPut("{id:int}")]
		public ActionResult Put(int id, ConcedenteModel concedente)
		{
			if (id != concedente.ConcedenteId)
			{
				return BadRequest();
			}
			_context.Entry(concedente).State = EntityState.Modified;
			_context.SaveChanges();

			return Ok(concedente);
		}

		[HttpDelete("{id:int}")]
		public ActionResult Delete(int id)
		{
			var concedente = _context.Concedentes.FirstOrDefault(c => c.ConcedenteId == id);

			if (concedente is null)
			{
				return NotFound("Concedentes não encontrados...");
			}
			_context.Concedentes.Remove(concedente);
			_context.SaveChanges();

			return Ok(concedente);
		}
	}
}
