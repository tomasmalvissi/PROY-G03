using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.CLASS
{
    public class Peluquero
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int EspejoId { get; set; }
        [ForeignKey("EspejoId")]
        public Espejo Espejo { get; set; }
        public Turno Turno { get; internal set; }
    }
}