using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Lanzamiento
{
    internal class Fechalanzamiento
    {
        private int anio;
        private string mes;

        public Fechalanzamiento(string mes, int anio)
        {
            this.mes = mes;
            this.anio = anio;

        }
        public string Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public int Anio
        { 
            get { return anio; }
            set
            {
                if (value < 2025) 
                { 
                anio = value;
                }
                else
                {
                    Console.WriteLine("La fecha de lanzamiento no puede sr mayor al año actual.");
                }
            }
        }
    }
}
