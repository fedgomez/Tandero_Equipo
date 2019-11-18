using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace Domain
{
    public class TandaModel
    {
        TandaRegister tandaRegister = new TandaRegister();

        public bool RegistrarTanda(int IdOrganizador, String FechaInicio, int DiaPago, int NoParticipantes, int Monto, String Codigo, String NombreTanda)
        {
            return tandaRegister.RegistrarTanda(IdOrganizador, FechaInicio, DiaPago, NoParticipantes, Monto, Codigo, NombreTanda);
        }

        public bool UserRating(String Rating, bool Tipo, int ID)
        {
            return tandaRegister.UserRating(Rating, Tipo, ID);
        }

        public bool GetUserRating(int ID, bool Type)
        {
            return tandaRegister.GetUserRating(ID, Type);
        }
    }
}
