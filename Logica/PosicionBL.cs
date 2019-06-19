using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class PosicionBL
    {
        PosicionDAL posDAL = new PosicionDAL();

        public DataTable DTPosiciones()
        {  
            return posDAL.ObtenerPosiciones();
        }

        public bool insertarPosicion(Posicion pos)
        {
            bool result = false;
            try
            {

                result = posDAL.InsertarPosicion(pos);

            } catch (Exception ex)
            {
                return false;
                throw ex;
            }

            return result;

        }

        public bool editarPosicion(Posicion pos)
        {
            bool result = false;
            try
            {

                result = posDAL.EditarPosicion(pos);
            
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
