using SalonSamochodowy;

Auto auto_1 = new("E46", "BMW", 2013, 35000);
auto_1.Opisz();
auto_1.Prowadz();
auto_1.Promocja();


Auto auto_2 = new("passat 1.9 TDI", "Volkswagen", 1999, 6000);
DodajAuto(auto_2);
auto_2.Opisz();
auto_2.Prowadz();
auto_2.Promocja();
auto_2.Opisz();

Console.WriteLine("Wybierz dzialanie:");
Console.WriteLine("1 - Prowadz");
Console.WriteLine("2 - Opisz");
Console.WriteLine("3 - Promocja");
string wybor = Console.ReadLine();

if (wybor == "1")
{
    auto_1.Prowadz();
    auto_2.Prowadz();
}
if (wybor == "2")
{
    auto_1.Opisz();
    auto_2.Opisz();
}
if (wybor == "3")
{
    auto_1.Promocja();
    auto_2.Promocja();
}

void DodajAuto(Auto auto)
{
    Console.WriteLine("Podaj model:");
    auto.Model = Console.ReadLine();

    Console.WriteLine("Podaj marke:");
    auto.Marka = Console.ReadLine();

    Console.WriteLine("Podaj rocznik:");
    auto.Rocznik = int.Parse(Console.ReadLine());

    Console.WriteLine("Podaj cene:");
    auto.Cena = double.Parse(Console.ReadLine());
}