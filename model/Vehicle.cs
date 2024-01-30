namespace VehicleRegister.model;

public class Vehicle
{
    public string PlateNumber { get; set; }
    public string Brand {get; set;}
    public string Model {get; set;}
    public int YearModel {get; set;}

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Kjøretøy: {PlateNumber}, {Brand}, {Model}, {YearModel}");
    }
}