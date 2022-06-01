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
        private string Ruta;

        private string Paraderos;

        private int NumeroVagones;

        public Bus(string ruta, string paraderos)
        {
            Ruta = ruta;
            Paraderos = paraderos;
        }
        public void setruta(string Ruta)
        {
            this.Ruta = Ruta;

        }
        public string getruta()
        {
            return this.Ruta;
        }
        public void setparaderos(string Paraderos)
        {
            this.Paraderos = Paraderos;
        }
        public string getparaderos()
        {
            return this.Paraderos;
        }

        public Bus(int numeroVagones)
        {
            NumeroVagones = numeroVagones;
        }
       
        public void setnumerovagones(int NumeroVagones)
        {
            this.NumeroVagones = NumeroVagones;
        }
        public int getnumerovagones()
        {
            return this.NumeroVagones;
        }

        
    }
}
