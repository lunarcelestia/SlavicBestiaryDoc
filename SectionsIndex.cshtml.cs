using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SlavicMyths.Data;
using SlavicMyths.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SlavicMyths.Pages.Sections
{
    public class IndexModel : PageModel
    {
        private readonly SlavicMythologyDbContext _context;
        public IndexModel(SlavicMythologyDbContext context) { _context = context; }
        public IList<Section> Sections { get; set; } = default!;
        public async Task OnGetAsync() { Sections = await _context.Sections.ToListAsync(); }
    }
}