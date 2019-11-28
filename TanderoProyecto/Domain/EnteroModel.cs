using System;
using DataAccess;


namespace Domain
{
    public static class EnteroModel
    {
        public static int EjecutaConsulta(string query, string text)
        {
            var consulta = new EnteroRegister();
            try
            {
                var res = consulta.GetInfo(query, text);
                return res;
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
