using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Helicoptero:TransporteAereo
    {
        public void EncenderHelices()
        {

        }
        public int PalancaDeMando;
        public int Timon;

        public Helicoptero(int palancaDeMando, int timon)
        {
            this.PalancaDeMando = palancaDeMando;
            this.Timon = timon;
        }

        
        

    }
}
