using Common.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Camiones
    {
        //Create
        public static string insertar_Camion(Camiones_VO camion)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_Datos.execute_NonQuery("sp_InsertarCamion",
                    "@Matricula", camion.Matricula,
                    "@Tipo_Camion", camion.TipoCamion,
                    "@Marca", camion.Marca,
                    "@Modelo", camion.Modelo,
                    "@Capacidad", camion.Capacidad,
                    "@Kilometraje", camion.Kilometraje,
                    "@UrlFoto", camion.UrlFoto,
                    "@Disponibilidad", camion.Disponibilidad
                    );

                if (respuesta != 0)
                {
                    salida = "Camión registrado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        //Read
        //Un método que devuelva una colección de datos que representen los camiones de la BD
        public static List<Camiones_VO> get_Camiones(params object[] parametros)
        {
            //Creo una lista de objetos que voy a llenar
            List<Camiones_VO> list_camiones = new List<Camiones_VO>();
            try
            {
                //Crear una Dataset el cual recibirá lo que devuelva la ejecución del método "execute_DataSet" proviniente de la clase "metodos_Datos"
                DataSet ds_camiones = metodos_Datos.execute_DataSet("sp_ListarCamiones", parametros);
                //Recorremos cada renglón existente de nuestro dataset creando objetos del tipo VO y añadiéndolos  a la lista
                foreach (DataRow camion in ds_camiones.Tables[0].Rows)
                {
                    list_camiones.Add(new Camiones_VO(camion));
                }
                //retorno la lista de cemiones con su información preparada
                return list_camiones;
            }
            catch (Exception ex)
            {
                //En caso de una excepción, la dejo pasar
                throw;
            }
        }

        //Update
        public static string actualizar_Camion(Camiones_VO camion)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_Datos.execute_NonQuery("sp_ActualizarCamion",
                    "@Matricula", camion.Matricula,
                    "@Tipo_Camion", camion.TipoCamion,
                    "@Marca", camion.Marca,
                    "@Modelo", camion.Modelo,
                    "@Capacidad", camion.Capacidad,
                    "@Kilometraje", camion.Kilometraje,
                    "@UrlFoto", camion.UrlFoto,
                    "@Disponibilidad", camion.Disponibilidad,
                    "@ID_Camion", camion.Idcamion
                    );

                if (respuesta != 0)
                {
                    salida = "Camión Actualziado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }
        //Delete
        public static string eliminar_Camion(int id)
        {
            string salida = "";
            int respuesta = 0;

            try
            {
                respuesta = metodos_Datos.execute_NonQuery("sp_EliminarCamion",
                    "@ID_Camion", id
                    );
                if (respuesta != 0)
                {
                    salida = "Camión eliminado con éxito";
                }
                else
                {
                    salida = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

        //GetbyID (Obtener x ID)
        public static Camiones_VO get_Camion_by_ID(int id)
        {
            //cre una lista de objetos que voy a llenar
            Camiones_VO camion = new Camiones_VO();
            try
            {
                DataSet ds_camiones = metodos_Datos.execute_DataSet("sp_ObtenerCamionPorID", "@ID_Camion", id);
                foreach (DataRow dr in ds_camiones.Tables[0].Rows)
                {
                    camion = new Camiones_VO(dr);
                }
                return camion;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
