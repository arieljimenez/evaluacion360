using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Datos
{
    class Acceso
    {
        // Clase de acceso a datos.

        #region "Variables (Clases) de Conexion"
        private SqlConnection Conexion;
        #endregion

        //Constructor
        public Acceso()
        {
            Conexion = new SqlConnection(CadenaConexion);
        }
        private string CadenaConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Sistema_Evaluacion_Desempeno.Properties.Settings.Conectar"].ToString();
                //@"Data Source = .\SQLEXPRESS;Initial Catalog = BD_IPD; Integrated Security = true";
            }

        }

        public SqlConnection ObtenerConexion()
        {
            return Conexion;
        }
    }
}
