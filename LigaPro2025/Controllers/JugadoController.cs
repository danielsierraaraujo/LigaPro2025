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

        // Muestra los jugadores titulares del equipo
        public IActionResult Index(int equipoId)
        {
            var jugadores = _db.Jugadores
                .Where(j => j.EquipoId == equipoId && j.EsTitular)
                .ToList();

            var equipo = _db.Equipos.FirstOrDefault(e => e.Id == equipoId);
            ViewBag.EquipoNombre = equipo?.Nombre ?? "Equipo";
            ViewBag.EquipoId = equipoId;

            return View(jugadores);
        }

        // Muestra el formulario para crear un jugador
        public async Task<IActionResult> Create(int equipoId)
        {
            var equipo = await _db.Equipos.FindAsync(equipoId);
            if (equipo == null)
                return NotFound();

            ViewBag.Equipo = equipo;
            return View(new Jugador { EquipoId = equipoId });
        }

        // Guarda el jugador
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

        // Elimina un jugador
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var jugador = await _db.Jugadores.FindAsync(id);
            if (jugador == null)
                return NotFound();

            var equipoId = jugador.EquipoId;
            _db.Jugadores.Remove(jugador);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { equipoId });
        }

        // Muestra la lista de equipos para elegir
        public IActionResult SeleccionarEquipo()
        {
            var equipos = _db.Equipos.ToList();
            return View(equipos);
        }
    }
}
