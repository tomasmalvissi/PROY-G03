using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.CLASS
{
    [Table("Horarios")]
    public class Horario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Dia { get; set; }
        [Required]
        public string Hora { get; set; }
        [Required]
        public int PeluqueroId { get; set; }
        [ForeignKey("PeluqueroId")]
        public Peluquero Peluquero { get; set; }
    }
}