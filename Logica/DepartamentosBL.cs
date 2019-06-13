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
    public class DepartamentosBL
    {
        public DataTable LlenarDepartamento()
        {
            DepartamentosDAL Emp = new DepartamentosDAL();

            return Emp.ObtenerDepartamentos();
        }
        public void RegDepartamentos(Departamentos entidad)
        {
            DepartamentosDAL RegistroDepartamentos = new DepartamentosDAL();

            RegistroDepartamentos.InsertarDepartamentos(entidad);

        }

        public void EliminarDepartamentos(Departamentos entidad)
        {
            DepartamentosDAL EliminacionEmpleados = new DepartamentosDAL();

            EliminacionEmpleados.EliminarDepartamentos(entidad);
        }

        public void ActualizarDepartamentos(Departamentos entidad)
        {
            DepartamentosDAL ActualizacionEmpleadosDepartamento = new DepartamentosDAL();

            ActualizacionEmpleadosDepartamento.ActualizarDepartamento(entidad);

        }

        public DataTable BusquedaDepartamento(string parametro, string opcion)
        {
            DepartamentosDAL BusquedaDepartamento = new DepartamentosDAL();

            return BusquedaDepartamento.BusquedaDepartamento(parametro, opcion);
        }

    }
}
