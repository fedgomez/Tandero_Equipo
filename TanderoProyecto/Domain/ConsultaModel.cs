using DataAccess;
using System;
using System.Data;

namespace Domain
{
    public static class ConsultaModel
    {

        public static DataTable EjecutaConsulta(string query)
        {
            var consulta = new ConsultaRegister();
            try
            {
                var dt = consulta.GetInfo(query);
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
