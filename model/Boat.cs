namespace VehicleRegister.model;
using service;

public class Boat : Vehicle
{
    public float Length { get; set; }
    public float Width { get; set; }
    public int Hp { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($", Lengde: {Length}, Bredde: {Width}, Hestekrefter: {Hp}");
    }

    public static Boat CreateBoat()
    {
        float length, width;
        int hp;
        var vehicle = CreateVehicle(); // Kaller CreateVehicle fra Vehicle classen og lagrer den i en ny variabel.
        
            Console.Write("Fot: ");
            length = Convert.ConvertStringFloat("Fot: ");

            Console.Write("Bredde: ");
            width = Convert.ConvertStringFloat("Bredde: ");

            Console.Write("Hestekrefter: ");
            hp = Convert.ConvertStringInt("Hestekrefter: ");
        

        return new Boat
        {
            PlateNumber = vehicle.PlateNumber,
            Brand = vehicle.Brand,
            Model = vehicle.Model,
            YearModel = vehicle.YearModel,
            Length = length,
            Width = width,
            Hp = hp
        };
    }
}