using Microsoft.EntityFrameworkCore;
using LigaPro2025.Models;
using System.Collections.Generic;

namespace LigaPro2025.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1) Seed de los 16 equipos
            modelBuilder.Entity<Equipo>().HasData(
                new Equipo { Id = 1, Nombre = "Aucas", Logo = "aucas.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 2, Nombre = "Barcelona SC", Logo = "bsc.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 3, Nombre = "Catolica", Logo = "cato.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 4, Nombre = "Delfín", Logo = "delfin.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 5, Nombre = "Deportivo Cuenca", Logo = "cuenca.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 6, Nombre = "El Nacional", Logo = "nacional.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 7, Nombre = "Emelec", Logo = "emelec.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 8, Nombre = "Manta", Logo = "manta.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 9, Nombre = "Independiente del Valle", Logo = "idv.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 10, Nombre = "LDU Quito", Logo = "liga.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 11, Nombre = "Macará", Logo = "macara.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 12, Nombre = "Mushuc Runa", Logo = "runa.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 13, Nombre = "Orense SC", Logo = "orense.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 14, Nombre = "Vinotinto", Logo = "venecos.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 15, Nombre = "Técnico Universitario", Logo = "tecnico.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 },
                new Equipo { Id = 16, Nombre = "Libertad", Logo = "liberdad.png", PartidosJugados = 0, PartidosGanados = 0, PartidosEmpatados = 0, PartidosPerdidos = 0, Puntos = 0 }
            );
    
            var jugadores = new List<Jugador>();
            for (int equipoId = 1; equipoId <= 16; equipoId++)
            {
                for (int num = 1; num <= 11; num++)
                {
                    jugadores.Add(new Jugador
                    {
                        Id = equipoId * 100 + num,
                        EquipoId = equipoId,
                        Nombre = $"Jugador {num} - Equipo {equipoId}",
                        NumeroCamiseta = num,
                        Goles = 0,
                        Asistencias = 0,
                        Sueldo = 1000m,
                        Titular = true
                    });
                }
            }
            modelBuilder.Entity<Jugador>().HasData(jugadores);
        }
    }
}
