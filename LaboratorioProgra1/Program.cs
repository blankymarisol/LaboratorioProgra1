using LaboratorioProgra1.ClasePadre;
using LaboratorioProgra1.ClaseHija;

static void Laboratorio()
{
    VideoJuego videoJuego = new VideoJuego();
    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    videoJuego.Desarrolladora = "Nintendo";
    videoJuego.Calificacion = 50;
    videoJuego.AnioLanzamiento = 2017;
    videoJuego.MostrarInformacion();
}
 static void Disparos()
{
    JuegoDisparos Tiros = new JuegoDisparos();
    Tiros.Titulo = "Call of duty: Black ops 2";
    Tiros.Desarrolladora = "Activision";
    Tiros.Calificacion = 100;
    Tiros.AnioLanzamiento = 2012;
    Tiros.MostrarInformacion();

}
static void Cocina()
{
    JuegosCocina Comida = new JuegosCocina();
    Comida.Titulo = "overcocked";
    Comida.Desarrolladora = "Activision";
    Comida.Calificacion = 100;
    Comida.AnioLanzamiento = 2012;
    Comida.MostrarInformacion();

}
static void Mundos()
{
    JuegosMundos MundosAbiertos = new JuegosMundos();
    MundosAbiertos.Titulo = "overcocked";
    MundosAbiertos.Desarrolladora = "Activision";
    MundosAbiertos.Calificacion = 100;
    MundosAbiertos.AnioLanzamiento = 2012;
    MundosAbiertos.MostrarInformacion();

}
static void Combates()
{
    JuegosPelea Combate = new JuegosPelea();
    Combate.Titulo = "overcocked";
    Combate.Desarrolladora = "Activision";
    Combate.Calificacion = 100;
    Combate.AnioLanzamiento = 2012;
    Combate.MostrarInformacion();

}

Laboratorio(); 

Disparos();

Cocina();

Mundos();

Combates();
//VideoJuego.Laboratorio();

