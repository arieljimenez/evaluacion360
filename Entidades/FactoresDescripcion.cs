using System;

namespace Entidades
{
    public class FactoresDescripcion
    {
        public int id_factor_detalle { get; }
        public string descripcion { get; set; }
        public int factor { get; set; }

        public FactoresDescripcion(string descripcion, int factor)
        {
            this.descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            this.factor = factor;
        }

        public FactoresDescripcion(int id_factor_detalle, string descripcion, int factor)
        {
            this.id_factor_detalle = id_factor_detalle;
            this.descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            this.factor = factor;
        }

    }
}
