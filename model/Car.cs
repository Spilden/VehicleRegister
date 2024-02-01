namespace VehicleRegister.model;

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
        while (!int.TryParse(Console.ReadLine(), out seats))
        {
            Console.WriteLine("You did not enter a valid number!");
            Console.Write("Antall Seter: ");
        }

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