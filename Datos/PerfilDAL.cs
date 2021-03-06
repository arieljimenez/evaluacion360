﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class PerfilDAL
    {
        #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        #endregion

        //Clase de Acceso a los datos
        private Acceso AccesoDatos;

        // Constructor
        public PerfilDAL()
        {
            AccesoDatos = new Acceso();
        }

        public DataTable ObtenerPerfil()
        {
            string query = "select codigo_perfil  AS CODIGO,codigo_posicion [ CODIGO POSICION] ,descripcion_competencia AS DESCRIPCION from Perfil";
            using (AdaptadorSQL = new SqlDataAdapter(query, AccesoDatos.ObtenerConexion()))
            {
                Dt = new DataTable();

                AdaptadorSQL.Fill(Dt);

            }
            return Dt;
        }

        public void InsertarPerfil(Perfil perfil)
        {
            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "Sp_perfil";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@codigo_perfil ", perfil.codigo_perfil);
                    ComandoSQL.Parameters.AddWithValue("@codigo_posicion", perfil.codigo_posicion);
                    ComandoSQL.Parameters.AddWithValue("@descripcion_competencia", perfil.descripcion_competencia);


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

        public void EliminarPerfil(Perfil perfil)
        {
            AccesoDatos.ObtenerConexion().Open();


            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                // ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "DELETE FROM departametos WHERE codigo_departamentos = @codigo_departamento";
                try
                {
                    //ComandoSQL.Parameters.AddWithValue("@codigo_departamento", departamentos.codigo_departamento);


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

        public void ActualizarDepartamento(Departamentos dep)
        {

            AccesoDatos.ObtenerConexion().Open();
            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexion();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "EMPLEADOSACTUALIZAR";
                try
                {
                    //ComandoSQL.Parameters.AddWithValue("@nombre_empleado", Empleados.nombre_empleado);
                    //ComandoSQL.Parameters.AddWithValue("@apellido_empleado", Empleados.apellido_empleado);
                    //ComandoSQL.Parameters.AddWithValue("@cedula_empleado", Empleados.cedula_empleado);
                    //ComandoSQL.Parameters.AddWithValue("@fecha_empleado", Empleados.fecha_empleado);
                    //ComandoSQL.Parameters.AddWithValue("@usuario", Empleados.usuario);
                    //ComandoSQL.Parameters.AddWithValue("@passwor", Empleados.passwor);
                    //ComandoSQL.Parameters.AddWithValue("@encargado_empleado", Empleados.encargado_empleado);
                    //ComandoSQL.Parameters.AddWithValue("@codigo_Departamento", Empleados.codigo_Departamento);
                    //ComandoSQL.Parameters.AddWithValue("@ManejarDepartamento ", Empleados.ManejarDepartamento);
                    //ComandoSQL.Parameters.AddWithValue("@ManejarEmpleado ", Empleados.ManejarEmpleado);
                    //ComandoSQL.Parameters.AddWithValue("@ManejarPerfil ", Empleados.ManejarPerfil);
                    //ComandoSQL.Parameters.AddWithValue("@ManejarClasificacion ", Empleados.ManejarClasificacion);
                    //ComandoSQL.Parameters.AddWithValue("@ManejarCompetencia", Empleados.ManejarCompetencia);
                    //ComandoSQL.Parameters.AddWithValue("@ManejarEvaluacion ", Empleados.ManejarEvaluacion);
                    //ComandoSQL.Parameters.AddWithValue("@ManejarFrecuencia", Empleados.ManejarFrecuencia);
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

        public DataTable BusquedaDepartamento(string parametro, string opcion)
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
