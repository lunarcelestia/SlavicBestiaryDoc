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
    public class PhenomenaController : Controller
    {
        // Пример данных, замените на вашу базу данных
        private static List<Phenomenon> phenomena = new List<Phenomenon>
    {
        new Phenomenon { Id = 1, Name = "Перун", Description = "Бог грома и молний", Type = "Бог" },
        new Phenomenon { Id = 2, Name = "Вий", Description = "Демон, охраняющий мертвых", Type = "Демон" }
    };

        public IActionResult Index(string type)
        {
            var filteredPhenomena = phenomena.FindAll(p => p.Type == type);
            return View(filteredPhenomena);
        }

        public IActionResult Details(int id)
        {
            var phenomenon = phenomena.Find(p => p.Id == id);
            return View(phenomenon);
        }
    }
}