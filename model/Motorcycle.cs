namespace VehicleRegister.model;

public class Motorcycle : Vehicle
{
    public bool SideCar { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Sidevogn: {(SideCar ? "Ja" : "Nei")}");
    }

    public static Motorcycle CreateMotorcycle()
    {
        Console.WriteLine("Skriv inn skiltnummer: ");
        String plateNumber = Console.ReadLine();
        Console.WriteLine("Merke: ");
        String brand = Console.ReadLine();
        Console.WriteLine("Modell: ");
        String model = Console.ReadLine();
        Console.WriteLine("Årsmodell: ");
        int yearModel = int.Parse(Console.ReadLine());
        Console.WriteLine("Sidevogn: ");
        bool sideCar = Console.ReadLine().ToLower() == "ja";

        return new Motorcycle()
        {
            PlateNumber = plateNumber,
            Brand = brand,
            Model = model,
            YearModel = yearModel,
            SideCar = sideCar
        };
    }
}