using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreTutorialDotNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicController : ControllerBase
    {
        private readonly DataContext _context;

        public ComicController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Comic>>> Get()
        {
            var comics = await _context.Comics
                //.Include(c => c.Teams)
                //.ThenInclude(t => t.SuperHeroes)
                .ToListAsync();

            return Ok(comics); 
        }
    }
}
