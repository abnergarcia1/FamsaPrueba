using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaFamsa
{
    public partial class Pendientes : System.Web.UI.Page
    {
        public static string connstr = ConfigurationManager.ConnectionStrings["tempDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod(EnableSession = false), ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]
        public static string CargarPendientesUsuario(int _IdUsuario)
        {

          
            List<Famsa.Modelos.Pendiente> tableResults = new List<Famsa.Modelos.Pendiente>();
            try
            {



                tableResults = Famsa.Logica.Pendientes.ObtenerPendientes(Pendientes.connstr, _IdUsuario);





            }
            catch (Exception ex)
            {



            }

            return Newtonsoft.Json.JsonConvert.SerializeObject(tableResults);

        }
        [WebMethod(EnableSession = false), ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]
        public static string CargarPendientes()
        {


            List<Famsa.Modelos.Pendiente> tableResults = new List<Famsa.Modelos.Pendiente>();
            try
            {



                tableResults = Famsa.Logica.Pendientes.ObtenerPendientes(Pendientes.connstr);





            }
            catch (Exception ex)
            {



            }

            return Newtonsoft.Json.JsonConvert.SerializeObject(tableResults);

        }

        [WebMethod(EnableSession = false), ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]
        public static bool CrearPendiente(string _Descripcion,int _IdUsuario)
        {


            Famsa.Modelos.Pendiente _pendiente = new Famsa.Modelos.Pendiente();
            _pendiente.Descripcion = _Descripcion;
            _pendiente.IdUsuario = _IdUsuario;

            bool result = false;
            try
            {



                result = Famsa.Logica.Pendientes.CrearPendiente(Pendientes.connstr, _pendiente);





            }
            catch (Exception ex)
            {



            }

            return result;

        }
        [WebMethod(EnableSession = false), ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]
        public static bool EliminarPendiente(int _IdPendiente)
        {

            bool result = false;
            try
            {

                result = Famsa.Logica.Pendientes.BorrarPendiente(Pendientes.connstr, _IdPendiente);

            }
            catch (Exception ex)
            {



            }

            return result;

        }

    }
}