
using VehicleRegister.model;

public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Lastekapasitet: {LoadCapacity}");
    }
    
    public static Truck CreateTruck()
    {
        Console.WriteLine("Skiltnummer: ");
        string plateNumber = Console.ReadLine();
        Console.WriteLine("Merke: ");
        string brand = Console.ReadLine();
        Console.WriteLine("Modell: ");
        string model = Console.ReadLine();
        Console.WriteLine("Årsmodell: ");
        int yearModel = int.Parse(Console.ReadLine());
        Console.WriteLine("Lastekapasitet: ");
        int loadCapacity = int.Parse(Console.ReadLine());

        return new Truck
        {
            PlateNumber = plateNumber,
            Brand = brand,
            Model = model,
            YearModel = yearModel,
            LoadCapacity = loadCapacity
        };
    }
}