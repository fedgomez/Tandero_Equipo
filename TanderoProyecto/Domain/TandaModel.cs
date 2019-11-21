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
            try
            {
                return tandaRegister.RegistrarTanda(IdOrganizador, FechaInicio, DiaPago, NoParticipantes, Monto, Codigo, NombreTanda);
            }
            catch (InvalidCastException e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }

        public bool UserRating(String Rating, bool Tipo, int ID)
        {
            try
            {
                return tandaRegister.UserRating(Rating, Tipo, ID);
            }
            catch (InvalidCastException e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }

        public bool GetUserRating(int ID, bool Type)
        {
            try
            {
                return tandaRegister.GetUserRating(ID, Type);
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
