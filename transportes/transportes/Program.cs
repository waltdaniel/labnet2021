using System;
using System.Linq;

namespace Transportes
{
    class Program
    {
        private static readonly int CantidadTransportes = 10;
        private static readonly int CantidadOmnibus = 5;

        static void Main(string[] args)
        {
            bool salir = false;
            TransportePublico[] transportes = new TransportePublico[CantidadTransportes];
            while (salir == false)
            {
                Console.WriteLine("MENU: \n 1 - Ingresar cantidad de pasajeros de transportes \n 2 - Ejecutar operación de un transporte");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ingrese la cantidad de pasajeros para los "+CantidadOmnibus+" Omnibus separados por coma: ");
                        string inputConsola;
                        inputConsola = String.Concat(Console.ReadLine(),'/');
                        Console.Write("Ingrese la cantidad de pasajeros para los " + (CantidadTransportes-CantidadOmnibus) + " Taxis separados por coma: ");
                        inputConsola = String.Concat(inputConsola, Console.ReadLine());
                        string[] cantidadesPasajeros = inputConsola.Split(',','/');
                        bool resultado = ValidaYprocesa(transportes, cantidadesPasajeros, salir);
                        if (resultado)
                        {
                            for (int t = 0; t < transportes.Length; t++)
                            {
                                MostrarCantidadDePasajeros(transportes[t]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("FAIL");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el Tipo de Transporte, Nro de transporte y Acción: " +
                            "\n 1 - Omnibus " +
                            "\n 2 - Taxi " +
                            "\n --- Operación: " +
                            "\n 3 - Avanzar \n 4 - Detenerse " +
                            "\n Ejemplo: 1 2 3 (corresponderá a: Omnibus Nro 2, Operación: Avanzar) \n");
                        string[] inputTemp = Console.ReadLine().Split();
                        if ( inputTemp.Any(i => Int32.Parse(i) <= 0
                                  || Int32.Parse(i) > 5)
                             || !(new[] { "3", "4" }.Contains(inputTemp[2]))
                                )
                        {
                            Console.WriteLine("Error en datos ingresados. Intente nuevamente.");
                        }
                        else
                        {
                            Console.WriteLine(EjecutarAccionTransporte(inputTemp, transportes));
                        };
                        break;
                }
                
            } 
             
            Console.Read();
        }

        private static string EjecutarAccionTransporte(string[] instruccion, TransportePublico[] pTransportes)
        {
            string resultado = "";
            string tipoTransp = instruccion[0] == "1" ? "Omnibus" : "Taxi";
            switch (instruccion[2])
            {
                case "3":

                    resultado = pTransportes.Single(x => x.Id == Int16.Parse(instruccion[1])
                        && x.ToString().Split('.')[1] == tipoTransp).Avanzar();
                    break;
                case "4":
                    resultado = pTransportes.Single(x => x.Id == Int16.Parse(instruccion[1])
                        && x.ToString().Split('.')[1] == tipoTransp).Detenerse();
                    break;
            }
            return resultado;
        }

        private static bool ValidaYprocesa(TransportePublico[] pTransportes ,string[] pCantidadesPasajeros,bool psalir)
        {
            if (pCantidadesPasajeros.Length > 10 || pCantidadesPasajeros.Length < 10)
            {
                Console.WriteLine("Deben ser 5 de cada transporte, ni mas ni menos. Intente de nuevo.");
                psalir = false;
            }
            else
            {
                for (int i = 0; i < pCantidadesPasajeros.Length; i++)
                {
                    int auxiliar;
                    if (Int32.TryParse(pCantidadesPasajeros[i], out auxiliar) )
                    {
                        if(i > (CantidadOmnibus - 1) ){
                            if (auxiliar <= 3)
                            {
                                pTransportes[i] = new Taxi(auxiliar,(i+1)-CantidadOmnibus);
                            }
                            else {
                                Console.WriteLine("Los Taxis sólo pueden tener hasta 3 pasajeros. ");
                                psalir = false;
                                break;
                            }
                        } else{
                             
                                if (auxiliar <= 30)
                                {
                                    pTransportes[i] = new Omnibus(auxiliar,i+1);
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

        private static void MostrarCantidadDePasajeros(TransportePublico transportePublico)
        {
            Console.WriteLine( transportePublico.GetType().ToString().Split('.')[1]+" "+ transportePublico.Id + " : " + (transportePublico.Pasajeros == 0 ? "está vacío" : transportePublico.Pasajeros.ToString() + " pasajeros"));
        }
    }
}
