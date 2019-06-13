using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class EmpleadosDAL
    {

        #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        // Constructor
        public EmpleadosDAL()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerEmpleados()
        {
            string query = "Select * From Empleado";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public void InsertarEmpleados(Empleados Empleados)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "INSERTAREMPLEADOS";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@nombre_empleado", Empleados.nombre_empleado);
                    ComandoSQL.Parameters.AddWithValue("@apellido_empleado", Empleados.apellido_empleado);
                    ComandoSQL.Parameters.AddWithValue("@cedula_empleado", Empleados.cedula_empleado);
                    ComandoSQL.Parameters.AddWithValue("@fecha_empleado", Empleados.fecha_empleado);

                    ComandoSQL.Parameters.AddWithValue("@usuario", Empleados.usuario);
                    ComandoSQL.Parameters.AddWithValue("@passwor", Empleados.passwor);

                    ComandoSQL.Parameters.AddWithValue("@encargado_empleado ", Empleados.encargado_empleado);
                    ComandoSQL.Parameters.AddWithValue("@codigo_Departamento", Empleados.codigo_Departamento);

                    ComandoSQL.Parameters.AddWithValue("@ManejarDepartamento", Empleados.ManejarDepartamento);
                    ComandoSQL.Parameters.AddWithValue("@ManejarEmpleado", Empleados.ManejarEmpleado);
                    ComandoSQL.Parameters.AddWithValue("@ManejarPerfil", Empleados.ManejarPerfil);
                    ComandoSQL.Parameters.AddWithValue("@ManejarClasificacion", Empleados.ManejarPerfil);
                    ComandoSQL.Parameters.AddWithValue("@ManejarCompetencia ", Empleados.ManejarCompetencia);
                    ComandoSQL.Parameters.AddWithValue("@ManejarEvaluacion", Empleados.ManejarEvaluacion);
                    ComandoSQL.Parameters.AddWithValue("@ManejarFrecuencia", Empleados.ManejarFrecuencia);


                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }
            }

        }

        public void EliminarEmpleados(Empleados Empleados)
        {
            AccesoDatos.ObtenerConexion().Open();


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                // ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "DELETE FROM empleado WHERE codigo_empleado = @ID";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@ID", Empleados.codigo_empleado);


                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }

            }

        }

        public void ActualizarEmpleados(Empleados Empleados)
        {

            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "EMPLEADOSACTUALIZAR";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@nombre_empleado", Empleados.nombre_empleado);
                    ComandoSQL.Parameters.AddWithValue("@apellido_empleado", Empleados.apellido_empleado);
                    ComandoSQL.Parameters.AddWithValue("@cedula_empleado", Empleados.cedula_empleado);
                    ComandoSQL.Parameters.AddWithValue("@fecha_empleado", Empleados.fecha_empleado);
                    ComandoSQL.Parameters.AddWithValue("@usuario", Empleados.usuario);
                    ComandoSQL.Parameters.AddWithValue("@passwor", Empleados.passwor);
                    ComandoSQL.Parameters.AddWithValue("@encargado_empleado", Empleados.encargado_empleado);
                    ComandoSQL.Parameters.AddWithValue("@codigo_Departamento", Empleados.codigo_Departamento);
                    ComandoSQL.Parameters.AddWithValue("@ManejarDepartamento ",Empleados.ManejarDepartamento);
                    ComandoSQL.Parameters.AddWithValue("@ManejarEmpleado ", Empleados.ManejarEmpleado);
                    ComandoSQL.Parameters.AddWithValue("@ManejarPerfil ", Empleados.ManejarPerfil);
                    ComandoSQL.Parameters.AddWithValue("@ManejarClasificacion ", Empleados.ManejarClasificacion);
                    ComandoSQL.Parameters.AddWithValue("@ManejarCompetencia", Empleados.ManejarCompetencia);
                    ComandoSQL.Parameters.AddWithValue("@ManejarEvaluacion ", Empleados.ManejarEvaluacion);
                    ComandoSQL.Parameters.AddWithValue("@ManejarFrecuencia", Empleados.ManejarFrecuencia);
                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();


                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexion().Close();
                }

            }

        }

        public DataTable BusquedaEmpleados(string parametro, string opcion)
        {
            AccesoDatos.ObtenerConexion().Open();
            string query = string.Empty;

            if (opcion.Equals("Nombre"))
            {
                //        query = "SELECT * FROM CLIENTES WHERE NOMB_CLIENTE LIKE @param";
            }
            //    else if (opcion.Equals("Pais"))
            {
                //        query = "SELECT * FROM CLIENTES WHERE PAIS LIKE @param";
            }

            using (ComandoSQL = new SqlCommand())
            {
                //        ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                //        ComandoSQL.CommandText = query;
                //        ComandoSQL.CommandType = CommandType.Text;

                try
            {
                //            ComandoSQL.Parameters.AddWithValue("@param", "%" + parametro + "%");


                using (AdaptadorSQL = new SqlDataAdapter())
            {
                //                AdaptadorSQL.SelectCommand = ComandoSQL;
                //                Dt = new DataTable();
                //                AdaptadorSQL.Fill(Dt);
            }
    }
                    catch (Exception)
                    {

                        throw;
                    }

                    finally
            {
                AccesoDatos.ObtenerConexion().Close();
            }

            return Dt;
        }
    }
    }
}
