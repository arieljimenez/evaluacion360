using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_Evaluacion_Desempeno
{
    public class Conectar
    {

        public SqlConnection conectarsql = new SqlConnection(@"server=USAPORTATIL\SQLEXPRESS; database=EvaluacionDesempeno; integrated security=true");
        //--ARIEL        public SqlConnection conectarsql = new SqlConnection(@"server=USAPORTATIL\SQLEXPRESS; database=JsFashion1; integrated security=true");
        public void abrir_conectar()
        {
            if (conectarsql.State == ConnectionState.Closed)
                conectarsql.Open();
        }
        public void Cerrar_conectar()
        {
            if (conectarsql.State == ConnectionState.Open)
                conectarsql.Close();

        }
    }
}
