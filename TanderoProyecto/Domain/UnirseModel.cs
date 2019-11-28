/*
 using DataAccess;
using System;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace Domain
{

    public class UnirseModel
    {
        UnirseRegister unirseTanda = new UnirseRegister();

        public bool Unirse(int IdTanda, int IdUsuario, char Cobrado, int turno)
        {
            try
            {
                return unirseTanda.Unirse(IdTanda, IdUsuario, Cobrado, turno);
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
*/