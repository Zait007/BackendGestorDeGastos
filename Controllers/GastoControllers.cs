using Microsoft.AspNetCore.Mvc;
using BackendGestorDeGastos.Models;
using BackendGestorDeGastos.Data; // Si estás usando AppDbContext para acceso a datos

namespace BackendGestorDeGastos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastoController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // GET api/gasto
        [HttpGet]
        public IActionResult Get()
        {
            var gasto = _context.Gasto.ToList(); // Por ejemplo, obtener todos los gastos
            return Ok(gasto);
        }

        // POST api/gasto
        [HttpPost]
        public IActionResult Post([FromBody] Gasto gasto)
        {
            if (gasto == null)
            {
                return BadRequest();
            }

            _context.Gasto.Add(gasto);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = gasto.IdGasto }, gasto);
        }
    }
}
