using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LigaPro2025.Models;

namespace LigaPro2025.Data
{
    public class LigaPro2025Context : DbContext
    {
        public LigaPro2025Context (DbContextOptions<LigaPro2025Context> options)
            : base(options)
        {
        }

        public DbSet<LigaPro2025.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<LigaPro2025.Models.Jugador> Jugador { get; set; } = default!;
    }
}
