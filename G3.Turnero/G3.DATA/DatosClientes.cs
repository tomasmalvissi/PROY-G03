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
    public class DatosClientes : DatosConexion  //no se si se podran cargar los datos, yo nunca use EF en WForm,
                                                //por eso a las clases (cliente en este caso) le ponia los atrib privado
                                                // y generaba un constructor public
    {
        public int ABMClientes(string accion, Cliente clientes) //no creo que necesitemos modificar un cliente por eso borre ese case
        {
            int resultado = 0;
            string orden = string.Empty;

            switch (accion)
            {
                case "Alta":
                    orden = "insert into Clientes " + "values ("
                                            + "'" + clientes.Nombre_Apellido + "'"
                                            + ");";
                    break;

                
                case "Eliminar":
                    orden = "Delete from Clientes where Id = " + clientes.Id;
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

                throw new Exception("Error al tratar de cargar los datos de Cliente", e);
            }
            finally
            {
                CerrarConex();
                sqlcmd.Dispose();
            }
            return resultado;
        }

        public DataSet MostrarClientes(string cual) //tampoco creo que debamos mostrar los clientes pero lo dejo 
                                                    //por las dudas, si te parece borralo, capaz tengamos q mostrarlo en
                                                    //otra instancia pero podemos hacer un join con otros datos
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Clientes where Id = " + int.Parse(cual) + ";";
            else
                orden = "select * from Clientes;";

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
                throw new Exception("error al listar clientes", e);
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
