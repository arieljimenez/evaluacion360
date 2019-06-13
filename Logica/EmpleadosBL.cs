using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;
using Logica;

namespace Logica
{
   public class EmpleadosBL
    {
        public DataTable LlenarEmpleados()
        {
            EmpleadosDAL Emp = new EmpleadosDAL();

            return Emp.ObtenerEmpleados();
        }
        public void RegEmpleados(Empleados entidad)
        {
            EmpleadosDAL RegistroEmpleados = new EmpleadosDAL();

            RegistroEmpleados.InsertarEmpleados(entidad);

        }

        public void EliminarEmpleados(Empleados entidad)
        {
            EmpleadosDAL EliminacionEmpleados = new EmpleadosDAL();

            EliminacionEmpleados.EliminarEmpleados(entidad);
        }

        public void ActualizarEmpleados(Empleados entidad)
        {
           EmpleadosDAL ActualizacionEmpleados = new EmpleadosDAL();

            ActualizacionEmpleados.ActualizarEmpleados(entidad);

        }

        public DataTable BusquedaEmpleados(string parametro, string opcion)
        {
            EmpleadosDAL BusquedaEmpleados = new EmpleadosDAL();

            return BusquedaEmpleados.BusquedaEmpleados(parametro, opcion);
        }

    }
}
