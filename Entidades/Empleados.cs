using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleados
    {
        //-------------Empleado--------------------
        public int codigo_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public string apellido_empleado { get; set; }
        public string cedula_empleado { get; set; }
        public string estatus_empleado { get; set; }
        public string direccion_empleado { get; set; }
        public string fecha_empleado { get; set; }
        
        public bool encargado_empleado { get; set; }
        public int codigo_Departamento { get; set; }


        //-------------Usuario--------------------
        public string usuario { get; set; }
        public string passwor { get; set; } 
        
        public bool ManejarDepartamento { get; set; }
        public bool ManejarEmpleado { get; set; }
        public bool ManejarPerfil { get; set; }
        public bool ManejarClasificacion { get; set; }
        public bool ManejarCompetencia { get; set; }
        public bool ManejarEvaluacion { get; set; }
        public bool ManejarFrecuencia { get; set; }
    }
}
