namespace VehicleRegister.model;

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
        try
        {
            Console.Write("Fot: ");
            length = float.Parse(Console.ReadLine());

            Console.Write("Bredde: ");
            width = float.Parse(Console.ReadLine());

            Console.Write("Hestekrefter: ");
            hp = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            throw;
        }

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