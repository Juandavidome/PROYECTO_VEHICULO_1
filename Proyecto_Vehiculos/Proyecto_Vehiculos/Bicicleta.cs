using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Bicicleta : VehiculosDeTraccionHumana
    {
        public void TransporteEcologico ()
        {

        }
        private string ReferenciaMarco;
        private int Guardabarros;

        public Bicicleta(string referenciaMarco)
        {
            ReferenciaMarco = referenciaMarco;
        }

        public Bicicleta(int guardabarros)
        {
            Guardabarros = guardabarros;
        }

        public void setMarco(string referenciamarco)
        {
            this.ReferenciaMarco = referenciamarco;
        }
        public string getMarco()
        {
            return this.ReferenciaMarco;
        }


    }
}
