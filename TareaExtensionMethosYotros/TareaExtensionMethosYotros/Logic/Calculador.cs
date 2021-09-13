using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaExtensionMethosYotros.Logic;
using TareaExtensionMethosYotros.Logic.Extensions;

namespace TareaExtensionMethosYotros.Modelo
{
    class Calculador : ICalculador
    {
        public Calculador() { }
         

        public void DidivePorCero(string dividendo)
        {
            try {
                var result = Int32.Parse(dividendo) / 0;
            } catch{ 
                
            throw new DivideByZeroException();
            }
        }

        public void DidivirDosNumeros(int i, int k)
        {
            try
            {
                if (i.EsPositivo()) { Console.WriteLine("Primer parámetro correcto, es mayor a 0. \n"); }
                if(k == 0) { throw new DivideByZeroException("Solo chuck puede dividir por 0!"); }
                Console.WriteLine(String.Concat("Resultado: ",i / k));
            }
            
        catch(Exception e) {
                Console.WriteLine(String.Concat("OTRO ERROR - ", e.Message)); 
                }
        }
    }
}
