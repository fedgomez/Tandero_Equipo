using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace Domain
{
    public class TandaModel
    {
        TandaRegister tandaRegister = new TandaRegister();

        public bool registrarTanda(int IdOrganizador, String FechaInicio, int DiaPago, int NoParticipantes, int Monto, String Codigo, String NombreTanda)
        {
            return tandaRegister.RegistrarTanda(IdOrganizador, FechaInicio, DiaPago, NoParticipantes, Monto, Codigo, NombreTanda);
        }
    }
}
