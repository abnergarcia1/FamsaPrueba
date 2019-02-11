using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Famsa.AccesoDatos
{
    public static class Pendientes
    {
        public static bool CrearPendiente(string _connstr, Modelos.Pendiente _pendiente)
        {
          bool respuesta = false;




           return respuesta;

        }
        public static bool BorrarPendiente(string _connstr, int _idPendiente)
        {
            bool respuesta = false;




            return respuesta;

        }
        public static List<Modelos.Pendiente> ObtenerPendientes(string _connstr, int _idUsuario)
        {
            List<Modelos.Pendiente> tempLista = new List<Modelos.Pendiente>();



            return tempLista;
        }
        public static List<Modelos.Pendiente> ObtenerPendientes(string _connstr)
        {
            List<Modelos.Pendiente> tempLista = new List<Modelos.Pendiente>();



            return tempLista;
        }
    }
}
