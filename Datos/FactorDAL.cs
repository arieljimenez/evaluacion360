using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;


namespace Datos
{
    public class FactorDAL
    {
        private Acceso AccesoDatos;
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;


        public FactorDAL()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerFactores()
        {
            string query = "SELECT * FROM factores";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public bool InsertarFactor(Factor fact)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "INSERTAR_FACTOR";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@nombre", fact.nombre_factor);
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

        public bool EditarFactor(Factor fact)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "EDITAR_FACTOR";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@id", fact.id_factor);
                    ComandoSQL.Parameters.AddWithValue("@nombre", fact.nombre_factor);

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
