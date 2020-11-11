using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.CLASS
{
    [Table("Tareas")]
    public class Tarea
    {
        #region ATRIBUTOS/PROPIEDADES
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Tiempo { get; set; }
        [Required]
        public int Valor { get; set; }
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; }
        #endregion

        #region CONSTRUCTORES
        public Tarea()
        {

        }

        public Tarea(int ID, string Descr, string Tiemp, int Val, int PeluqID)
        {
            Id = ID;
            Descripcion = Descr;
            Tiempo = Tiemp;
            Valor = Val;
            ProductoId = PeluqID;
        }
        #endregion
    }
}