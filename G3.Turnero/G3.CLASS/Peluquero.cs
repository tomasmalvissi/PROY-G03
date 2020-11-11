using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.CLASS
{
    [Table("Peluqueros")]
    public class Peluquero
    {
        #region ATRIBUTOS/PROPIEDADES
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Espejo { get; set; }
        #endregion

        #region CONSTRUCTORES
        public Peluquero()
        {

        }
        public Peluquero(int ID, string Nom, int Espej)
        {
            Id = ID;
            Nombre = Nom;
            Espejo = Espej;
        }
        #endregion
    }
}