using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlavicMyths.Data;
using SlavicMyths.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SlavicMyths.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SectionsController : ControllerBase
    {
        private readonly SlavicMythologyDbContext _context;

        public SectionsController(SlavicMythologyDbContext context)
        {
            _context = context;
        }

        // GET: api/Sections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Section>>> GetSections()
        {
            return await _context.Sections.ToListAsync();
        }

        // GET: api/Sections/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Section>> GetSection(int id)
        {
            var section = await _context.Sections.Include(s => s.Phenomena).FirstOrDefaultAsync(s => s.Id == id);

            if (section == null)
            {
                return NotFound();
            }

            return section;
        }
    }
}