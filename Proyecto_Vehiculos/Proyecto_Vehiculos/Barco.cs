using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vehiculos
{
    public class Barco:TransporteAcuatico
    {
        public void PrenderMotor()
        {
        }
        private string forma;
        private int cantidadHelicesBarcos;

        public Barco(string forma)
        {
            this.forma = forma;
        }

        public Barco(int cantidadHelicesBarcos)
        {
            this.cantidadHelicesBarcos = cantidadHelicesBarcos;
        }

        public void setForma(string forma)
        {
            this.forma = forma;
        }
        public string getForma()
        {
            return this.forma;
        }

        public void setHelices(int HelicesBarcos)
        {
            this.cantidadHelicesBarcos = HelicesBarcos;
        }
        public int getHelices()
        {
            return this.cantidadHelicesBarcos;
        }
    }
}
