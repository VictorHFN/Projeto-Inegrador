using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
	}
}
