using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    class Taxi : TransportePublico
    {
        public Taxi(int pasajeros)
        {
            this.Pasajeros = pasajeros;
        }
        public Taxi(int pasajeros, int id)
        {
            this.Pasajeros = pasajeros;
            this.Id = id;
        }

        public override string Avanzar()
        {
            return "El taxi " + this.Id + " ha avanzado.";
        }

        public override string Detenerse()
        {
            return "El taxi " + this.Id + " se ha detenido.";
        }
    }
}
