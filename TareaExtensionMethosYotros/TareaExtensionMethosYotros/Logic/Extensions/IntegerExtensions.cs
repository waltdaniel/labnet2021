using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaExtensionMethosYotros.Logic.Extensions
{
    public static class IntegerExtensions
    {
        public static bool EsPositivo(this int numero)
        {
            return numero > 0;
        }
    }
}
