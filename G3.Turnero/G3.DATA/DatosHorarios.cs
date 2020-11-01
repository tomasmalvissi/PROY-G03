using G3.CLASS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.DATA
{
    public class DatosHorarios : DatosConexion
    {
        public int ABMHorarios(string accion, Horario horarios)
        {
            int resultado = 0;
            string orden = string.Empty;

            switch (accion)
            {
                case "Alta":
                    orden = "insert into Horarios " + "values ("
                                            + "'" + horarios.DiaHora + "',"
                                            + "'" + horarios.PeluqueroId + "'"
                                            + ");";
                    break;

                case "Modificar":
                    orden = "update Horarios set "
                                        + "DiaHora = '" + horarios.DiaHora + "',"
                                        + "PeluqueroId= '" + horarios.PeluqueroId + "'"
                                        + "where Id= " + horarios.Id;
                    break;

                case "Eliminar":
                    orden = "Delete from Horarios where Id = " + horarios.Id;
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

                throw new Exception("Error al tratar de modificar los registros de Horas", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return resultado;
        }

        public DataSet MostrarHorarios(string cual)
        {
            string orden = string.Empty;
            orden = "select h.Id, h.DiaHora, p.Id, p.Nombre " +
                "from Horarios h, Peluqueros p " +
                "where p.Id = h.PeluqueroId and p.Nombre like " + "'%" + cual + "%'"
                +" and h.DiaHora BETWEEN getdate() AND dateadd(month," + +2 + ", getdate())" ;

            SqlCommand sqlcmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {   
                AbrirConex();
                sqlcmd.ExecuteNonQuery();
                da.SelectCommand = sqlcmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("error al listar Turnos", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return ds;
        }

        public DataSet MostrarHorarioPorDni(string cual)
        {
            string orden = string.Empty;
            orden = "select h.Id, h.DiaHora " +
                   " from Horarios h, Peluqueros p " +
                   " where p.Id = h.PeluqueroId and p.Id = " + int.Parse(cual) + 
                   " and h.DiaHora BETWEEN getdate() AND dateadd(month," + +2 + ", getdate()); ";

            SqlCommand sqlcmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConex();
                sqlcmd.ExecuteNonQuery();
                da.SelectCommand = sqlcmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("error al listar Turnos", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return ds;
        }
    }
}