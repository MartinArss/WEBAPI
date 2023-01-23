using Microsoft.AspNetCore.Mvc;
using SegundaApiCRUD.Context;
using SegundaApiCRUD.Entities;
using System.Threading.Tasks;

namespace SegundaApiCRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticuloController : ControllerBase
    {
        // CREAR EL CONSTRUCTORY LLAMAR LA CADENA DE CONEXION O LA CONEXION A LA BASE DE DATOS
        // _CONTEXT
        private readonly ApplicationDbContext _context;
        public Articulo




        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Articulo art)
        {
            var articulo = new Articulo();
            // LLAMAR A ENTITY PARA AGREGAR
            await _context.SaveChangeAsync();
            return Ok();
        }
    }
}
