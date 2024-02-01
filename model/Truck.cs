using VehicleRegister.model;

public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }
    public static Truck CreateTruck()
    {
        var vehicle = CreateVehicle(); // Kaller CreateVehicle fra Vehicle classen og lagrer den i en ny variabel.
        
        Console.Write("Lastekapasitet: ");
        if(!int.TryParse(Console.ReadLine(), out var loadCapacity))
        {
            Console.WriteLine("You did not enter a valid number!");
        }

        return new Truck
        {
            PlateNumber = vehicle.PlateNumber,
            Brand = vehicle.Brand,
            Model = vehicle.Model,
            YearModel = vehicle.YearModel,
            LoadCapacity = loadCapacity
        };
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($", Lastekapasitet: {LoadCapacity}");
    }
}