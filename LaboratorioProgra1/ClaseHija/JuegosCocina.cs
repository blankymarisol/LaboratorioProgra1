using LaboratorioProgra1.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.ClaseHija
{
    internal class JuegosCocina : VideoJuego
    {
        public bool Cocina { get; set; }
        public string MostrarInformacionCocina()
        {
            string detallePadre = MostrarInformacionCocina();
            return detallePadre + " Se prepara comida de todo tipo: " + Cocina;
        }
    }
}
