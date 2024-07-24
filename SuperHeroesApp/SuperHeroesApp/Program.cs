// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

SuperPoder PoderVolar = new SuperPoder();
PoderVolar.Nombre = "Volar";
PoderVolar.descripcion = "Capacidad de Poder Volar";
PoderVolar.Nivel = NivelPoder.Nivel2;


SuperPoder SuperFuerza = new SuperPoder();
SuperFuerza.Nombre = "Fuerza";
SuperFuerza.descripcion = "Tener habilidad de tener Super Fuerza";
SuperFuerza.Nivel= NivelPoder.Nivel3;

SuperPoder Artesmarciales = new SuperPoder();
Artesmarciales.Nombre = "Artes Marciales";
Artesmarciales.descripcion = "habilidad de pelear";
Artesmarciales.Nivel = NivelPoder.Nivel1;


SuperHeroe superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Gotica";
superman.PuedeVolar = true;
superman.SuperPoderes = new[] { "Vision de rayos x", "super Fuerza", "PoderVolar" };



SuperHeroe Batman = new SuperHeroe();
Batman.Id = 2;
Batman.Nombre = "kINGSTON";
Batman.Ciudad = "Gotica";
Batman.PuedeVolar = false;
Batman.IdentidadSecreta = "Antonio";
Batman.SuperPoderes = new[] { "Bueno con pistola", "artes marciales", "cae con estilo" };




SuperHeroe Flash = new SuperHeroe();
Flash.Id = 3;
Flash.Nombre = "Flash";
Flash.IdentidadSecreta = "No identificada";
Flash.PuedeVolar= false;
Flash.Ciudad = "New York";
Flash.SuperPoderes = new[] { "corre muy rapido", "artes marciales" };



class SuperHeroe
{

    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;

}


class SuperPoder {

    public string Nombre;
    public string descripcion;
    public NivelPoder Nivel;

}


enum NivelPoder { 
    Nivel1,
    Nivel2,
    Nivel3,

}



