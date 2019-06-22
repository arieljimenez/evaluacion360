using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factor
    {
        public int id_factor { get; }
        public string nombre_factor { get; set; }
        public bool estado { get; set; }

        public Factor(string nombre_factor)
        {
            this.nombre_factor = nombre_factor;
            this.estado = true; //habilitado por defecto
        }

        public Factor(int id_factor, string nombre_factor, bool estado)
        {
            this.id_factor = id_factor;
            this.nombre_factor = nombre_factor ?? throw new ArgumentNullException(nameof(nombre_factor));
            this.estado = estado;
        }

    }
}
