using LaboratorioProgra1.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.ClaseHija
{
    internal class JuegosMundos : VideoJuego
    {
        public bool MundoAbierto { get; set; }
        public string MostrarInformacioMundos()
        {
            string detallePadre = MostrarInformacioMundos();
            return detallePadre + " Se puede recorrer el mundo a tu manera: " + MundoAbierto;
        }
    }
}
