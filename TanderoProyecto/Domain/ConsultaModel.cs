using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Domain
{
    public class ConsultaModel
    {

        public DataTable ejecutaConsulta(string query)
        {
            ConsultaRegister consulta = new ConsultaRegister();
            DataTable dt = new DataTable();
            try
            {
                dt = consulta.getInfo(query);
                return dt;
            }
            catch (InvalidCastException e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }
    }
}
