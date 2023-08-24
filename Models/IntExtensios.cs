using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public static class IntExtensios
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}