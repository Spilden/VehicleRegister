using VehicleRegister.model;

namespace VehicleRegister.service;

public class VehicleService
{
    private readonly List<Vehicle> vehicles = new();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ShowVehicles()
    {
        foreach (var vehicle in vehicles) vehicle.DisplayInfo();
    }
}