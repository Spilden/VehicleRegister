
using VehicleRegister.model;

public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"{Seats}");
        Console.WriteLine("--------------------------------------------------------");
    }
    public static Car CreateCar()
    {
        Console.WriteLine("Skiltnummer: ");
        string plateNumber = Console.ReadLine();
        Console.WriteLine("Merke: ");
        string brand = Console.ReadLine();
        Console.WriteLine("Modell: ");
        string model = Console.ReadLine();
        Console.WriteLine("Årsmodell: ");
        int yearModel = int.Parse(Console.ReadLine());
        Console.WriteLine("Antall Seter: ");
        int seats = int.Parse(Console.ReadLine());

        return new Car
        {
            PlateNumber = plateNumber,
            Brand = brand,
            Model = model,
            YearModel = yearModel,
            Seats = seats
        };
    }
}