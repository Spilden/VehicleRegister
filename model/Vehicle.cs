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
        string plateNumber, brand, model;
        int yearModel;

        try
        {
            Console.WriteLine("Skiltnummer: ");
            plateNumber = Console.ReadLine();
            Console.WriteLine("Merke: ");
            brand = Console.ReadLine();
            Console.WriteLine("Modell: ");
            model = Console.ReadLine();
            Console.WriteLine("Årsmodell: ");
            yearModel = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            throw;
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