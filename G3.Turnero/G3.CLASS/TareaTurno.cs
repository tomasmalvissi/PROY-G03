using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.CLASS
{
    public class TareaTurno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int TurnoId { get; set; }
        [Required]
        public int TareaId { get; set; }
        [ForeignKey("TurnoId")]
        public Turno Turno { get; set; }
        [ForeignKey("TareaId")]
        public Tarea Tarea { get; set; }
    }
}
