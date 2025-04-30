using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LigaPro2025.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [ForeignKey("Equipo")]
        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }

        [Display(Name = "N° Camiseta")]
        [Range(1, 99)]
        public int NumeroCamiseta { get; set; }

        [Range(0, 1000)]
        public int Goles { get; set; }

        [Range(0, 1000)]
        public int Asistencias { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Sueldo { get; set; }

        public bool Titular { get; set; }
    }
}
