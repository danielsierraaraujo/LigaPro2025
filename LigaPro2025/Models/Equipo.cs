using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LigaPro2025.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        [Display(Name = "Nombre Equipo")]
        public string Nombre { get; set; }

        [MaxLength(200)]
        public string Logo { get; set; }

        [Display(Name = "Partidos Jugados")]
        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosEmpatados { get; set; }
        public int PartidosPerdidos { get; set; }

        public int Puntos { get; set; }

        // Relación con Jugadores
        public ICollection<Jugador> Jugadores { get; set; }
    }
}
