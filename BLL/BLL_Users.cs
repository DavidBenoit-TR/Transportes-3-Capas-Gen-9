using Common.VO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Users
    {
        //Login
        public static List<string> Login(string nick, string pass)
        {
            //Recupero el Usuario que corresponda
            User_VO usuario = DAL_Users.Login(nick, pass);
            //preparar las variables que necesito
            string nombre = "", rol = "", error = "";
            List<string> respuesta = new List<string>();
            //valido si realmente existe el usuario
            if (usuario.ID_user != 0)
            {
                //Si exite y se recuperó
                nombre = usuario.Nickname;
                rol = usuario.Rol;
            }
            else
            {
                //no hay nada
                error = "Error: No se ha encontrado el usuario en la Base de datos";
            }
            //añadimos las variables de respuesta a la lsita
            respuesta.Add(nombre);
            respuesta.Add(rol);
            respuesta.Add(error);
            //devolvemos la lista
            return respuesta;
        }
    }
}
