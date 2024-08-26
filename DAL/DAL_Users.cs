using Common.VO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Users
    {
        public static User_VO Login(string nick, string pass)
        {
            User_VO user = new User_VO();

            try
            {
                DataSet ds_user = metodos_Datos.execute_DataSet("sp_Login",
                    "@nickname", nick,
                    "@pass", pass);
                foreach (DataRow dr in ds_user.Tables[0].Rows)
                {
                    user = new User_VO(dr);
                }
                User_VO x = new User_VO(ds_user.Tables[0].Rows[0]);

                return user;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
