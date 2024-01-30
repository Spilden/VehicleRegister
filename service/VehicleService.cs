using VehicleRegister.model;
public class VehicleService
{
    private List<Vehicle> vehicles = new List<Vehicle>();
    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }
    public void ShowVehicles()
    {
        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine($"Bil: {vehicle.PlateNumber}, {vehicle.Brand}, {vehicle.Model}, {vehicle.YearModel}");
        }
    }
}