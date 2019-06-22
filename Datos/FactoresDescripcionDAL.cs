using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class FactoresDescripcionDAL
    {
        private Acceso AccesoDatos;
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;


        public FactoresDescripcionDAL()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerFactoresDescripciones()
        {
            string query = "select * from factores_descripcion";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public bool InsertarFactorDescripcion(FactoresDescripcion fd)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "INSERTAR_FACTOR_DESCRIPCION";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@descripcion", fd.descripcion);
                    ComandoSQL.Parameters.AddWithValue("@factor", fd.factor);

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

        public bool EditarFactorPosicion(FactoresDescripcion fd)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "EDITAR_FACTOR_DESCRIPCION";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@id", fd.id_factor_detalle);
                    ComandoSQL.Parameters.AddWithValue("@descripcion", fd.descripcion);
                    ComandoSQL.Parameters.AddWithValue("@factor", fd.factor);

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
