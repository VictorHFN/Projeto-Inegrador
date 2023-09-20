using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechVagasAPI.Context;
using TechVagasAPI.Models;

namespace TechVagasAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CargoController : ControllerBase
	{
		private readonly AppDbContext _context;

		public CargoController(AppDbContext context) 
		{
			_context = context;
		}

		[HttpGet]
		public ActionResult<IEnumerable<CargoModel>> Get() 
		{
			var cargos = _context.Cargos.ToList();
			if(cargos is null) 
			{
				return NotFound("Cargos não encontrados");
			}
			return cargos;
		}

	}
}
