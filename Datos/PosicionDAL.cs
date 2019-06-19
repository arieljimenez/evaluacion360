using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class PosicionDAL
    {
        private Acceso AccesoDatos;
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;

        
        public PosicionDAL()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerPosiciones()
        {
            string query = "select * from posiciones";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public bool InsertarPosicion(Posicion Pos)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "INSERTAR_POSICION";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@nombre", Pos.nombre_posicion);
                    ComandoSQL.Parameters.AddWithValue("@estado", Pos.estado);

                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return false;
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }
                return true;
            }

        }

        public bool EditarPosicion(Posicion Pos)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "EDITAR_POSICION";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@id", Pos.id_posicion);
                    ComandoSQL.Parameters.AddWithValue("@nombre", Pos.nombre_posicion);

                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                    throw ex;

                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }
                return true;
            }

        }
    }
}
