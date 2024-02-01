namespace VehicleRegister.model;

public class Motorcycle : Vehicle
{
    public bool SideCar { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($", Sidevogn: {(SideCar ? "Ja" : "Nei")}");
    }

    public static Motorcycle CreateMotorcycle()
    {
        var vehicle = CreateVehicle(); // Kaller CreateVehicle fra Vehicle classen og lagrer den i en ny variabel.

        Console.WriteLine("Sidevogn? 'ja/nei': ");
        var sideCar = Console.ReadLine().ToLower() == "ja";

        return new Motorcycle
        {
            PlateNumber = vehicle.PlateNumber,
            Brand = vehicle.Brand,
            Model = vehicle.Model,
            YearModel = vehicle.YearModel,
            SideCar = sideCar
        };
    }
}