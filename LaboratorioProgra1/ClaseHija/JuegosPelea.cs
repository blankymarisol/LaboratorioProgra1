using LaboratorioProgra1.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.ClaseHija
{
    internal class JuegosPelea : VideoJuego
    {
        public bool Combates { get; set; }
        public string MostrarInformacioCombates()
        {
            string detallePadre = MostrarInformacioCombates();
            return detallePadre + " Hay peleas de 2 jugadores o contra la maquina: " + Combates;
        }
    }
}

