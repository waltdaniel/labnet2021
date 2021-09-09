using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    class Program
    {
        static int cantidadTransportes = 10;
        static int cantidadOmnibus = 2;

        static void Main(string[] args)
        {
            bool salir = false;
            TransportePublico[] transportes = new TransportePublico[cantidadTransportes];
            while (salir == false)
            { 
                Console.Write("Ingrese la cantidad de pasajeros para los "+ cantidadOmnibus+" Omnibus seguido para los Taxis, separados por coma: ");
                string inputConsola;
                inputConsola = Console.ReadLine();
                string[] cantidadesPasajeros = inputConsola.Split(',');
                bool resultado = ValidaYprocesa(transportes, cantidadesPasajeros, salir);
                if (resultado)
                {
                    for(int t = 0; t < transportes.Length; t++)
                    { 
                        mostrarCantidadDePasajeros(transportes[t], (t+1));
                    }
                }
                else {
                    Console.WriteLine("FAIL");
                }
            } 
             
            Console.Read();
        }

        private static bool ValidaYprocesa(TransportePublico[] pTransportes ,string[] pcantidadesPasajeros,bool psalir)
        {
            if (pcantidadesPasajeros.Length > 10 || pcantidadesPasajeros.Length < 10)
            {
                Console.WriteLine("Deben ser 5 de cada transporte, ni mas ni menos. Intente de nuevo.");
                psalir = false;
            }
            else
            {
                for (int i = 0; i < pcantidadesPasajeros.Length; i++)
                {
                    int auxiliar;
                    if (Int32.TryParse(pcantidadesPasajeros[i], out auxiliar) )
                    {
                        if(i > (cantidadOmnibus - 1) ){
                            if (auxiliar <= 3)
                            {
                                pTransportes[i] = new Taxi(auxiliar);
                            }
                            else {
                                Console.WriteLine("Los Taxis sólo pueden tener hasta 3 pasajeros. ");
                                psalir = false;
                                break;
                            }
                        } else{
                             
                                if (auxiliar <= 30)
                                {
                                    pTransportes[i] = new Omnibus(auxiliar);
                                }
                                else
                                {
                                    Console.WriteLine("Los Omnibuses sólo pueden tener hasta 30 pasajeros. ");
                                    psalir = false;
                                    break;
                                }
                        }
                        psalir = true;
                    }
                    else
                    {
                        Console.WriteLine("Error, ingrese un números enteros. Intente de nuevo. ");
                        psalir = false;
                        break;
                    }
                }
               
            }
            return psalir;
        }

        private static void mostrarCantidadDePasajeros(TransportePublico transportePublico, int nroTransporte)
        {
            Console.WriteLine( transportePublico.GetType().ToString().Split('.')[1]+" "+ nroTransporte +" : " + (transportePublico.pasajeros == 0 ? "está vacío" : transportePublico.pasajeros.ToString() + " pasajeros"));
        }
    }
}
