using System;
using System.Data;
using Datos;
using Entidades;


namespace Logica
{
    public class FactoresDescripcionBL
    {
        FactoresDescripcionDAL fdDAL = new FactoresDescripcionDAL();

        public DataTable DTFactoresDescripciones()
        {
            return fdDAL.ObtenerFactoresDescripciones();
        }

        public bool insertarDescripcionFactor(FactoresDescripcion fd)
        {
            bool result = false;
            try
            {

                result = fdDAL.InsertarFactorDescripcion(fd);

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

            return result;

        }

        public bool editarDescripcionFactor(FactoresDescripcion fd)
        {
            bool result = false;
            try
            {

                result = fdDAL.EditarFactorPosicion(fd);

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

            return result;

        }
    }
}
