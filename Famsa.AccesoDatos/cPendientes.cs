using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Famsa.AccesoDatos
{
    public static class Pendientes
    {
        public static bool CrearPendiente(string _connstr, Modelos.Pendiente _pendiente)
        {
            bool response = false;
            string query = "spCrearPendiente";
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = _connstr;


            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;


                comm.CommandText = query;
                comm.Parameters.AddWithValue("@Descripcion", _pendiente.Descripcion);
               
                comm.Parameters.AddWithValue("@IdUsuario", _pendiente.IdUsuario);
               

                comm.ExecuteNonQuery();


                response = true;

            }
            catch (Exception ex)
            {
                //TODO: exception catch!

            }

            conn.Close();
            return response;

        }
        public static bool BorrarPendiente(string _connstr, int _idPendiente)
        {
            bool response = false;
            string query = "spEliminarPendiente";
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = _connstr;


            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@IdPendiente", _idPendiente);


                comm.CommandText = query;
               

               

                comm.ExecuteNonQuery();


                response = true;

            }
            catch (Exception ex)
            {
                //TODO: exception catch!

            }

            conn.Close();
            return response;

        }
        public static List<Modelos.Pendiente> ObtenerPendientes(string _connstr, int _idUsuario)
        {
            List<Modelos.Pendiente> tempLista = new List<Modelos.Pendiente>();

            string query = "spObtenerPendientesUsuario";



            Modelos.Pendiente tempPendiente;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = _connstr;


            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@IdUsuario", _idUsuario);

                comm.CommandText = query;
                SqlDataReader reader;

                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    tempPendiente = new Modelos.Pendiente()
                    {
                        IdPendiente = int.Parse(reader["IdPendiente"].ToString()),
                        Descripcion = reader["Descripcion"].ToString(),
                        Estatus = reader["Estatus"].ToString(),
                        FechaCreacion = DateTime.Parse(reader["FechaCreacion"].ToString()),
                        FechaActualizacion = DateTime.Parse(reader["FechaActualizacion"].ToString()),
                        IdUsuario = int.Parse(reader["IdUsuario"].ToString())
                    };

                    tempLista.Add(tempPendiente);
                }
            }
            catch (Exception ex)
            {
                //TODO: exception catch!

            }

            conn.Close();

            return tempLista;
        }
        public static List<Modelos.Pendiente> ObtenerPendientes(string _connstr)
        {
            List<Modelos.Pendiente> tempLista = new List<Modelos.Pendiente>();

            string query = "spObtenerPendientes";



            Modelos.Pendiente tempPendiente;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = _connstr;


            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
             

                comm.CommandText = query;
                SqlDataReader reader;

                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    tempPendiente = new Modelos.Pendiente()
                    {
                        IdPendiente = int.Parse(reader["IdPendiente"].ToString()),
                        Descripcion = reader["Descripcion"].ToString(),
                        Estatus = reader["Estatus"].ToString(),
                        FechaCreacion = DateTime.Parse(reader["FechaCreacion"].ToString()),
                        FechaActualizacion = DateTime.Parse(reader["FechaActualizacion"].ToString()),
                        IdUsuario = int.Parse(reader["IdUsuario"].ToString())
                    };

                    tempLista.Add(tempPendiente);
                }
            }
            catch (Exception ex)
            {
                //TODO: exception catch!

            }

            conn.Close();

            return tempLista;
        }
    }
}
