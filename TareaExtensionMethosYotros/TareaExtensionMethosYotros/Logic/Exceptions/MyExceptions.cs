using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaExtensionMethosYotros.Logic.Exceptions
{
    public class MyExceptions : SystemException
    {
        public static void ArrojarExcepcionDivPorCero(string parametro) {
            try
            {
                Console.WriteLine("Intentando dividir por 0...");
                var resultado = Int32.Parse(parametro) / 0;
                Console.WriteLine("Operación completada con éxito.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(string.Concat("Operación fallida.  ", e.Message));
                Console.WriteLine(string.Concat("Stacktrace. .. \n", e.StackTrace));
            }
        }
         
    }
}
