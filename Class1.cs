namespace SalonSamochodowy;

public class Auto
{
    public string Model { get; set; }
    public string Marka { get; set; }
    private int Przebieg { get; set; } = 0;
    public int Rocznik { get; set; }
    public double Cena { get; set; }
    private bool Czydziala { get; set; } = true;

    public Auto(string model, string marka, int rocznik, double cena)
    {
        Model = model;
        Marka = marka;
        Rocznik = rocznik;
        Cena = cena;
    }

    public void Prowadz()
    {
        if (Czydziala)
        {
            Przebieg += 100;
            Console.WriteLine($"{Przebieg}kilometrów");
        }
        else
        {
            Console.WriteLine("Auto nie jedzie");
        }
        if (Przebieg == 1000)
        {
            Zatrzymaj();
            Przebieg = -100;
        }
    }

    private void Zatrzymaj()
    {
        Czydziala = false;
        Console.WriteLine("Auto nie pojedzie dłużej");
    }

    public void Opisz()
    {
        Console.WriteLine($"{Model} model, {Cena} cena, {Rocznik} rocznik, {Marka} marka");
    }

    public void Promocja()
    {
        Cena -= 3500;
    }
}