using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.VO
{
    public class Camiones_VO
    {
        //VO =  View Object
        //Representación de una talba SQL a nivel de código C#
        private int _idcamion;
        private string _matricula;
        private string _tipoCamion;
        private string _marca;
        private string _modelo;
        private int _capacidad;
        private double _kilometraje;
        private string _urlFoto;
        private bool _disponibilidad;

        //Encapsulamiento
        public int Idcamion { get => _idcamion; set => _idcamion = value; }
        public string Matricula { get => _matricula; set => _matricula = value; }
        public string TipoCamion { get => _tipoCamion; set => _tipoCamion = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public int Capacidad { get => _capacidad; set => _capacidad = value; }
        public double Kilometraje { get => _kilometraje; set => _kilometraje = value; }
        public string UrlFoto { get => _urlFoto; set => _urlFoto = value; }
        public bool Disponibilidad { get => _disponibilidad; set => _disponibilidad = value; }

        //Constructores
        //Por Defecto
        public Camiones_VO()
        {
            _idcamion = 0;
            _matricula = "";
            _tipoCamion = string.Empty;
            _marca = "";
            _modelo = "";
            _capacidad = 0;
            _kilometraje = 0;
            _urlFoto = "";
            _disponibilidad = true;
        }
        //Contructor con parámetros (Datarow)
        //Datarow => Objeto de ADO
        public Camiones_VO(DataRow dr)
        {
            _idcamion = int.Parse(dr["ID_Camion"].ToString());
            _matricula = dr["Matricula"].ToString();
            _tipoCamion = dr["Tipo_Camion"].ToString();
            _marca = dr["Marca"].ToString();
            _modelo = dr["Modelo"].ToString();
            _capacidad = int.Parse(dr["Capacidad"].ToString());
            _kilometraje = double.Parse(dr["Kilometraje"].ToString());
            _urlFoto = dr["UrlFoto"].ToString();
            _disponibilidad = bool.Parse(dr["Disponibilidad"].ToString());
        }
    }
}
