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
            return unirseTanda.Unirse(IdTanda, IdUsuario, '0', turno);
        }
    }
}
