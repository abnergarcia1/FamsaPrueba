using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Famsa.Logica
{
    public static class Pendientes
    {
        public static bool CrearPendiente(string _connstr, Modelos.Pendiente _pendiente)
        {
            return AccesoDatos.Pendientes.CrearPendiente(_connstr,_pendiente);
        }

        public static bool BorrarPendiente(string _connstr, int _idPendiente)
        {
            return AccesoDatos.Pendientes.BorrarPendiente(_connstr, _idPendiente);
        }

        public static List<Modelos.Pendiente> ObtenerPendientes(string  _connstr, int _idUsuario)
        {
            return AccesoDatos.Pendientes.ObtenerPendientes(_connstr,_idUsuario);
        }
        public static List<Modelos.Pendiente> ObtenerPendientes(string _connstr)
        {
            return AccesoDatos.Pendientes.ObtenerPendientes(_connstr);
        }

    }
}
