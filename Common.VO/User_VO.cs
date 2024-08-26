using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Common.VO
{
    public class User_VO
    {
        private int _ID_user;
        private string _nickname;
        private string _pass;
        private bool _estatus;
        private string _rol;

        public int ID_user { get => _ID_user; set => _ID_user = value; }
        public string Nickname { get => _nickname; set => _nickname = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public bool Estatus { get => _estatus; set => _estatus = value; }
        public string Rol { get => _rol; set => _rol = value; }

        public User_VO()
        {
            _ID_user = 0;
            _nickname = "";
            _pass = "";
            _estatus = true;
            _rol = "";
        }

        public User_VO(DataRow dr)
        {
            _ID_user = int.Parse(dr["ID_user"].ToString());
            _nickname = dr["nickname"].ToString();
            _pass = dr["pass"].ToString();
            _estatus = bool.Parse(dr["estatus"].ToString());
            _rol = dr["rol"].ToString();
        }
    }
}
