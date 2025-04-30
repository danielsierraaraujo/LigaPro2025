using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using LigaPro2025.Data;
using LigaPro2025.Models;
//con ayuda de copilot
namespace LigaProMVC.Controllers
{
    public class JugadorController : Controller
    {
        private readonly ApplicationDbContext _db;
        public JugadorController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /Jugador/Index?equipoId=5
        public async Task<IActionResult> Index(int equipoId)
        {
            var equipo = await _db.Equipos.FindAsync(equipoId);
            if (equipo == null) return NotFound();

            ViewBag.Equipo = equipo;
            var lista = await _db.Jugadores
                                 .Where(j => j.EquipoId == equipoId)
                                 .ToListAsync();
            return View(lista);
        }

        // GET: /Jugador/Create?equipoId=5
        public async Task<IActionResult> Create(int equipoId)
        {
            var equipo = await _db.Equipos.FindAsync(equipoId);
            if (equipo == null) return NotFound();

            ViewBag.Equipo = equipo;
            return View(new Jugador { EquipoId = equipoId });
        }

        // POST: /Jugador/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Jugador jugador)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Equipo = await _db.Equipos.FindAsync(jugador.EquipoId);
                return View(jugador);
            }

            _db.Jugadores.Add(jugador);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { equipoId = jugador.EquipoId });
        }

        // POST: /Jugador/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var jugador = await _db.Jugadores.FindAsync(id);
            if (jugador != null)
            {
                var equipoId = jugador.EquipoId;
                _db.Jugadores.Remove(jugador);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { equipoId });
            }
            return NotFound();
        }
    }
}
