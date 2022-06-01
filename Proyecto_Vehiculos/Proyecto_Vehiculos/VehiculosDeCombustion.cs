using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class VehiculosDeCombustion:TransporteTerrestre
    {
        public void ImpulsoPorCombustion()
        {

        }
        public double CapacidadDeCombustible { get; set; }
        public int Escape { get; set; }
    }
}
