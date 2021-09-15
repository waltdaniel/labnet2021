using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros)
        {
            this.Pasajeros = pasajeros;
        }
        public Omnibus(int pasajeros, int id)
        {
            this.Pasajeros = pasajeros;
            this.Id = id;
        }
        public override string Avanzar()
        {
            return "El omnibus " + this.Id + " ha avanzado.";
        }

        public override string Detenerse()
        {
            return "El omnibus " + this.Id + " se ha detenido.";
        }
    }
}
