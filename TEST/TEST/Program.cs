// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Aputador ApuntadorP = new Aputador();
Aputador ApuntadorP2 = new Aputador();


ApuntadorP.Color = "Negro";
ApuntadorP2.Color = "Blanco";

class Aputador
{
    public string Color;
    public double Largo;
    public short NumeroDeBotones;
    public bool TieneStickers;

}