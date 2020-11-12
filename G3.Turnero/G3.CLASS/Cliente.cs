using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.CLASS
{
    [Table("Clientes")]
    public class Cliente
    {
        #region ATRIBUTOS/PROPIEDADES
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public string Nombre_Apellido { get; set; }
        #endregion

        #region CONSTRUCTORES
        public Cliente()
        {
        }

        public Cliente(int ID, string Nom)
        {
            Id = ID;
            Nombre_Apellido = Nom;
        }
        #endregion
    }
}