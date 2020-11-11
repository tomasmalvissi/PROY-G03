using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.CLASS
{
    #region ATRIBUTOS/PROPIEDADES
    [Table("Horarios")]
    public class Horario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime DiaHora { get; set; }
        [Required]
        public int PeluqueroId { get; set; }
        [ForeignKey("PeluqueroId")]
        public Peluquero Peluquero { get; set; }
        #endregion

        #region CONSTRUCTORES
        public Horario()
        {

        }

        public Horario(int ID, DateTime DIAHORA, int Peluq)
        {
            Id = ID;
            DiaHora = DIAHORA;
            PeluqueroId = Peluq;
        }
        #endregion
    }
}