using VehicleRegister.model;

public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($", Lastekapasitet: {LoadCapacity}");
    }

    public static Truck CreateTruck()
    {
        int loadCapacity;
        var vehicle = CreateVehicle(); // Kaller CreateVehicle fra Vehicle classen og lagrer den i en ny variabel.
        try
        {
            Console.WriteLine("Lastekapasitet: ");
            loadCapacity = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            throw;
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
}