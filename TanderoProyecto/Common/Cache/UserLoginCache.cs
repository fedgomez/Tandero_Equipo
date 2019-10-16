using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static int IdUsuario { get; set; }
        public static string Nombre { get; set; }
        public static string Email { get; set; }
        public static int numVotosP { get; set; }
        public static int sumRatingP { get; set; }
        public static int numVotosO { get; set; }
        public static int sumRatingO { get; set; }
    }
}
