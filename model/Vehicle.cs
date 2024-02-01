namespace VehicleRegister.model;

public class Vehicle
{
    public string PlateNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int YearModel { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("-------------------------------------------------------");
        Console.Write($"Kjøretøy: {PlateNumber}, {Brand}, {Model}, {YearModel}");
    }

    public static Vehicle CreateVehicle()
    {
        int yearModel;

        Console.Write("Skiltnummer: ");
        var plateNumber = Console.ReadLine();

        Console.Write("Merke: ");
        var brand = Console.ReadLine();

        Console.Write("Modell: ");
        var model = Console.ReadLine();

        Console.Write("Årsmodell: ");
        if (!int.TryParse(Console.ReadLine(), out yearModel))
        {
            Console.WriteLine("You did not enter a valid number!");
        }

        return new Vehicle
        {
            PlateNumber = plateNumber,
            Brand = brand,
            Model = model,
            YearModel = yearModel
        };
    }
}