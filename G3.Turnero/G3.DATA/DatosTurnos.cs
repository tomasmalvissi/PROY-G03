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
    public class DatosTurnos : DatosConexion
    {
        public int ABMTurnos(string accion, Turno turnos)
        {
            int resultado = 0;
            string orden = string.Empty;

            switch (accion)
            {
                case "Modificar":
                    orden = "update Turnos set "
                                        + "DateTime= '" + turnos.DateTime + "',"
                                        + "TareaId= '" + turnos.TareaId + "',"
                                        + "ClienteId= '" + turnos.ClienteId + "',"
                                        + "PeluqueroId= '" + turnos.PeluqueroId + "'"
                                        + "where Id= " + turnos.Id;
                    break;

                case "Eliminar":
                    orden = "Delete from Turnos where Id = " + turnos.Id;
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

                throw new Exception("Error al tratar de modificar los registros de Turnos", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return resultado;
        }

        public int AltaTurnos(Turno turnos, int horario)
        {
            int resultado = 0;
            string orden = string.Empty;

            orden = "insert into Turnos " + "values ("
                     + "'" + turnos.DateTime + "',"
                     + "'" + turnos.TareaId + "',"
                     + "'" + turnos.ClienteId + "',"
                     + "'" + turnos.PeluqueroId + "');"
                     + " delete from Horarios where Id =" + horario
                     + ";";


            SqlCommand sqlcmd = new SqlCommand(orden, conexion);
            try
            {
                AbrirConex();
                resultado = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de modificar los registros de Turnos", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return resultado;
        }

        public DataSet MostrarTurnosporPeluquero(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select Id, DateTime, TareaId, ClienteId " +
                    " from Turnos where PeluqueroId = " + int.Parse(cual) +
                    " and DateTime BETWEEN getdate() AND dateadd(month," + +2 + ", getdate()); ";
            else
                orden = "select select Id, DateTime, TareaId, ClienteId from Turnos;";

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

        public DataSet TurnosClientes()
        {
            string orden = string.Empty;
            orden = "select c.Nombre_Apellido, count(t.Id) as 'Turnos por cliente' " +
                     "from Clientes c, Turnos t " +
                      "where t.ClienteId = c.Id " +
                      "group by c.Nombre_Apellido " +
                      "order by 'Turnos por cliente' desc";

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
                throw new Exception("error al listar Cliente", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return ds;
        }

        public DataSet TurnosPeluqueros()
        {
            string orden = string.Empty;
            orden = "select p.Nombre, count(t.Id) as 'Cantidad de turnos por peluquero' " +
                     "from Peluqueros p, Turnos t " +
                     "where t.PeluqueroId = p.Id " +
                      "group by p.Nombre " +
                      "order by 'Cantidad de turnos por peluquero' desc";

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
                throw new Exception("error al listar Peluquero", e);
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
