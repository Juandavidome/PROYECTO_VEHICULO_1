using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class AutoHibrido : VehiculoHibrido
    {
        public void EscogerMotorPropulsor()
        {

        }
        private string referenciaMotorCompatible;

        public AutoHibrido(string referenciaMotorCompatible)
        {
            this.referenciaMotorCompatible = referenciaMotorCompatible;
        }

        public void setreferencia (string MotorCompatible)
        {
            this.referenciaMotorCompatible = MotorCompatible;
        }
        public string getreferencia()
        {
            return this.referenciaMotorCompatible;

        }



    }
}
