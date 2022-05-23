using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Bus : VehiculosDeCombustion
    {
        public void TransportarGranCantidadDePersonas()
        {

        }
        public char Ruta { get; set; }
        public char Paraderos { get; set; }
        public int NumeroVagones { get; set; }
    }
}
