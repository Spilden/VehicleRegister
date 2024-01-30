using Microsoft.VisualBasic;

namespace VehicleRegister.model;

public class Boat : Vehicle
{
    public int Length { get; set; }
    public int Width { get; set; }
    public int Hp { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Lengde: {Length}, Bredde: {Width}, Hestekrefter: {Hp}");
    }

    public static Boat CreateBoat()
    {
        Console.WriteLine("Skiltnummer: ");
        string plateNumber = Console.ReadLine();
        Console.WriteLine("Merke: ");
        string brand = Console.ReadLine();
        Console.WriteLine("Modell: ");
        string model = Console.ReadLine();
        Console.WriteLine("Årsmodell: ");
        int yearModel = int.Parse(Console.ReadLine());
        Console.WriteLine("Hvor mange fot er båten?");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Hvor brei er båten?");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Hvor mange hestekrefter har båten?");
        int hp = int.Parse(Console.ReadLine());

        return new Boat()
        {
            PlateNumber = plateNumber,
            Brand = brand,
            Model = model,
            YearModel = yearModel,
            Length = length,
            Width = width,
            Hp = hp
        };
    }
}