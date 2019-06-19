using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Posicion
    {
        public int id_posicion { get; }
        public string nombre_posicion { get; set; }
        public bool estado { get; set; }

        public Posicion(string nombre_posicion)
        {
            this.nombre_posicion = nombre_posicion;
            this.estado = true; //habilitado por defecto
        }

        public Posicion(int id_posicion, string nombre_posicion, bool estado)
        {
            this.id_posicion = id_posicion;
            this.nombre_posicion = nombre_posicion ?? throw new ArgumentNullException(nameof(nombre_posicion));
            this.estado = estado;
        }
    }
}
