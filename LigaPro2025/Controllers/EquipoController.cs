using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LigaPro2025.Data;
using LigaPro2025.Models;
using System.Linq;
using System.Threading.Tasks;

namespace LigaProMVC.Controllers
{
    public class EquipoController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EquipoController(ApplicationDbContext db)
        {
            _db = db;
        }

        
        public async Task<IActionResult> ListaEquipos()
        {
            var equipos = await _db.Equipos
                                    .AsNoTracking()
                                    .OrderByDescending(e => e.Puntos)
                                    .ToListAsync();
            return View(equipos);
        }

        
        public async Task<IActionResult> Edit(int id)
        {
            var equipo = await _db.Equipos.FindAsync(id);
            if (equipo == null) return NotFound();
            return View(equipo);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Equipo equipo)
        {
            if (!ModelState.IsValid)
                return View(equipo);

            
            var suma = equipo.PartidosGanados
                         + equipo.PartidosEmpatados
                         + equipo.PartidosPerdidos;
            if (suma != equipo.PartidosJugados)
            {
                ModelState.AddModelError("", "La suma de ganados, empatados y perdidos debe coincidir con partidos jugados.");
                return View(equipo);
            }

            // Calcular puntos
            equipo.Puntos = equipo.PartidosGanados * 3
                          + equipo.PartidosEmpatados;

            _db.Equipos.Update(equipo);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(ListaEquipos));
        }

        
        public async Task<IActionResult> Detalle(int id)
        {
            var equipo = await _db.Equipos
                                  .Include(e => e.Jugadores)
                                  .FirstOrDefaultAsync(e => e.Id == id);
            if (equipo == null) return NotFound();

           
            ViewBag.PresupuestoTotal = equipo.Jugadores.Sum(j => j.Sueldo);

            
            ViewBag.Titulares = equipo.Jugadores
                                      .Where(j => j.Titular)
                                      .ToList();

            return View(equipo);
        }
    }
}
