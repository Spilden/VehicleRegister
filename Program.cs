using VehicleRegister.model;
using VehicleRegister.service;

var vehicleService = new VehicleService();

while (true)
{
    Console.WriteLine("1. Legg til bil!");
    Console.WriteLine("2. Legg til lastebil!");
    Console.WriteLine("3. Legg til motorsykkel!");
    Console.WriteLine("4. Legg til båt!");
    Console.WriteLine("5. Vis alle kjøretøy!");
    Console.WriteLine("6. Avslutt!");
    Console.Write("Ditt valg: ");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            vehicleService.AddVehicle(Car.CreateCar());
            break;
        case "2":
            vehicleService.AddVehicle(Truck.CreateTruck());
            break;
        case "3":
            vehicleService.AddVehicle(Motorcycle.CreateMotorcycle());
            break;
        case "4":
            vehicleService.AddVehicle(Boat.CreateBoat());
            break;
        case "5":
            vehicleService.ShowVehicles();
            break;
        case "6":
            return;
        default:
            Console.WriteLine("Ugyldig valg, prøv igjen!");
            break;
    }
}