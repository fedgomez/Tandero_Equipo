using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;


namespace Domain
{
    public class EnteroModel
    {
        public int ejecutaConsulta(string query, string text)
        {
            EnteroRegister consulta = new EnteroRegister();
            int res;
            try
            {
                res = consulta.getInfo(query, text);
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
