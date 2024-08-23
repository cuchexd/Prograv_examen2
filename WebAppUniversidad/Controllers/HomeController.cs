using Microsoft.AspNetCore.Mvc;
using WebAppUniversidad.Data;
using WebAppUniversidad.Models;
using System.Linq;

namespace WebAppUniversidad.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var estudiantes = _context.Estudiantes.ToList(); // Obtener la lista de estudiantes desde la base de datos
            return View(estudiantes); // Pasar la lista a la vista
        }
    }
}

