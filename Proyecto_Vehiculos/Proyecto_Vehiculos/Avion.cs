using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Avion:TransporteAereo
    {
        public void TransportarPersonasEnElAire()
        {

        }
        private int alas;

        public Avion(int alas)
        {
            this.alas = alas;
        }

        public void SetAlas(int Alas)
        {
            this.alas = Alas;
        }
        public int GetAlas()
        {
            return this.alas;
        }
    }
}
