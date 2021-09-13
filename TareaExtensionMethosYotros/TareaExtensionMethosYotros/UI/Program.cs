using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaExtensionMethosYotros.Logic;
using TareaExtensionMethosYotros.Logic.Exceptions;
using TareaExtensionMethosYotros.Modelo;
using TareaExtensionMethosYotros.Logic.Extensions;

namespace TareaExtensionMethosYotros
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionMenu = -1;
            while(opcionMenu != 0)
            {
                try
                {
                    Console.WriteLine("1 - Divide por 0");
                    Console.WriteLine("2 - Dividir dos números");
                    Console.WriteLine("0 - Salir");
                    Console.WriteLine("Ingrese una opción: ");
                    opcionMenu = Int32.Parse(Console.ReadLine());
                    switch
                        (opcionMenu)
                    {
                        case 1:
                            Console.WriteLine("Ingrese dividendo (número entero): ");
                            MyExceptions.ArrojarExcepcionDivPorCero(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Ingrese divendo y divisor: ");
                            var inputs = Console.ReadLine().Split();
                            if (inputs.Length > 2)
                            {
                                Console.WriteLine("Sólo debe ingrese dos números separados por espacio.");
                            }
                            else
                            {
                                var calc = new Calculador();
                                calc.DidivirDosNumeros(Int32.Parse(inputs[0]), Int32.Parse(inputs[1]));
                            }

                            break;
                    }
                } 
                catch (ExceptionCustomizada e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(String.Concat("ERROR en ingresar opción del MENU: ", e.Message));
                }
                finally
                {
                    //Console.Clear();
                }
            }
        }
    
    }
}