using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.CLASS
{
    public class Turno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public int TareaId { get; set; }
        [ForeignKey("TareaId")]
        public Tarea Tarea { get; set; }
        [Required]
        public int ClienteId { get; set; }
        
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        [Required]
        public int PeluqueroId { get; set; }
        [ForeignKey("PeluqueroId")]
        public Peluquero Peluquero { get; set; }
    }
}