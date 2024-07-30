// See https://aka.ms/new-console-template for more information
using System.Text;

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






SuperHeroe Batman = new SuperHeroe();
Batman.Id = 2;
Batman.Nombre = "kINGSTON";
Batman.Ciudad = "Gotica";
Batman.PuedeVolar = false;
Batman.IdentidadSecreta = "Antonio";
List<SuperPoder> poderesBatman = new List<SuperPoder>();
Batman.SuperPoderes.Add(PoderVolar);
Batman.SuperPoderes.Add(SuperFuerza);




SuperHeroe Flash = new SuperHeroe();
Flash.Id = 3;
Flash.Nombre = "Flash";
Flash.IdentidadSecreta = "No identificada";
Flash.PuedeVolar= false;
Flash.Ciudad = "New York";
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
Flash.SuperPoderes.Add(PoderVolar);
Flash.SuperPoderes.Add(SuperFuerza);
string resultSuperPoderes = Flash.UsarSuperPoder();
Console.WriteLine(resultSuperPoderes);



class SuperHeroe
{

    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;


    public SuperHeroe() { 

    Id = 1;
    SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;
    
    }

    public string UsarSuperPoder() {

        StringBuilder sb = new StringBuilder();
        foreach (var item in SuperPoderes)
        {

            sb.AppendLine($"{Nombre} esta usando el super poder {item.Nombre}!!");
        
        }
    
    return sb.ToString();
    
    }


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



