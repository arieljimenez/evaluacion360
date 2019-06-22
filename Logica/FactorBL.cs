using System;
using System.Data;
using Datos;
using Entidades;

namespace Logica
{
    public class FactorBL
    {
        FactorDAL factDAL = new FactorDAL();

        public DataTable DTFactores()
        {  
            return factDAL.ObtenerFactores();
        }

        public bool insertarFactor(Factor fact)
        {
            bool result = false;
            try
            {

                result = factDAL.InsertarFactor(fact);

            } catch (Exception ex)
            {
                return false;
                throw ex;
            }

            return result;

        }

        public bool editarFactor(Factor fact)
        {
            bool result = false;
            try
            {

                result = factDAL.EditarFactor(fact);
            
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
