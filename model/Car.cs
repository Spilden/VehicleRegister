namespace VehicleRegister.model;
using service;

public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($", Antall seter: {Seats}");
    }

    public static Car CreateCar()
    {
        // int seats;
        var vehicle = CreateVehicle(); // Kaller CreateVehicle fra Vehicle classen og lagrer den i en ny variabel.
        int seats;

        Console.Write("Antall Seter: ");
        seats = Convert.ConvertStringInt("Antall seter: ");

        return new Car
        {
            PlateNumber = vehicle.PlateNumber,
            Brand = vehicle.Brand,
            Model = vehicle.Model,
            YearModel = vehicle.YearModel,
            Seats = seats
        };
    }
}