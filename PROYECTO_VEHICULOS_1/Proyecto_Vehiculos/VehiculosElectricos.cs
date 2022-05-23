using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class VehiculosElectricos:TransporteTerrestre
    {
        public void ImplusoElectrico()
        {

        }
        public int Baterias { get; set; }
        public int MotorElectrico { get; set; }
        public int Controlador { get; set; }
        public char ConectividadMovil { get; set; }
        public int Cargador { get; set; }

    }
}
