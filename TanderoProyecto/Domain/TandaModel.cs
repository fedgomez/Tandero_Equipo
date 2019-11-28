using System;
using DataAccess;

namespace Domain
{
    public class TandaModel
    {
        private readonly TandaRegister tandaRegister = new TandaRegister();


        public bool UserRating(string Rating, bool Tipo, int Id)
        {
            try
            {
                return tandaRegister.UserRating(Rating, Tipo, Id);
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
