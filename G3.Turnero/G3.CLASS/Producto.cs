using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.CLASS
{
    [Table("Productos")]
    public class Producto
    {
        #region ATRIBUTOS/PROPIEDADES
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Stock { get; set; }
        #endregion

        #region CONSTRUCTORES
        public Producto()
        {

        }

        public Producto(int ID, string Descr, int Stk)
        {
            Id = ID;
            Descripcion = Descr;
            Stock = Stk;
        }
        #endregion
    }
}