using G3.CLASS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.DATA
{
    public class DatosPeluquero : DatosConexion
    {
        public int AltaClientes(string accion, Peluquero peluquero)
        {
            int resultado = 0;
            string orden = string.Empty;

            switch (accion)
            {
                case "Alta":
                    orden = "insert into Peluqueros " + "values ("
                                            + "'" + peluquero.Id + "',"
                                            + "'" + peluquero.Nombre + "',"
                                            + "'" + peluquero.Espejo + "'"
                                            + ");";
                    break;
            }

            SqlCommand sqlcmd = new SqlCommand(orden, conexion);
            try
            {
                AbrirConex();
                resultado = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cargar los datos de Peluqueros", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return resultado;
        }
    }
}
