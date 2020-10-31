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
                case "Alta":
                    orden = "insert into Turnos " + "values ("              //ver como se insertan las FK creo que lo estoy 
                                                                            // haciendo mal pero son las 2:07 am un viernes
                                            + "'" + turnos.DateTime + "',"
                                            + "'" + turnos.TareaId + "',"
                                            + "'" + turnos.ClienteId + "',"
                                            + "'" + turnos.PeluqueroId + "'"
                                            + ");";
                    break;

                case "Modificar":
                    orden = "update Turnos set "
                                        + "Nombre= '" + turnos.DateTime + "',"
                                        + "Direccion= '" + turnos.TareaId + "',"
                                        + "Telefono= '" + turnos.ClienteId + "',"
                                        + "Email= '" + turnos.PeluqueroId + "'"
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

        public DataSet MostrarClientes(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Turnos where Id = " + int.Parse(cual) + ";";
            else
                orden = "select * from Turnos;";

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
