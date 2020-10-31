using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.CLASS
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nombre_Apellido { get; set; }
        [Required]
        public int Peluquero_Pref { get; set; }
        [ForeignKey("Peluquero_Pref")]
        public Peluquero Peluquero { get; set; }
    }
}