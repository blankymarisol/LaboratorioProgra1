using LaboratorioProgra1.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.ClaseHija
{
    internal class JuegoDisparos : VideoJuego
        {
            public bool Disparos { get; set; }
            public string MostrarInformacionDisparos()
            {
                string detallePadre = MostrarInformacionDisparos();
                return detallePadre + " Hay armas de fuego: " + Disparos;
            }
        }
    
}
