using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaExtensionMethosYotros.Logic.Exceptions
{
    class ExceptionCustomizada : Exception
    {
        public ExceptionCustomizada() :base("Opción inválida. No ingresó nada o ingresó una letra.")
        {

        }
    }
}
