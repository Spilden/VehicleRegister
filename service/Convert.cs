using System.Runtime.InteropServices.JavaScript;

namespace VehicleRegister.service;

public class Convert
{
    public static float ConvertStringFloat(string input)
    {
        float numberFloat;
        while (!float.TryParse(Console.ReadLine(), out numberFloat))
        {
            Console.WriteLine("You did not enter a valid number!");
            Console.Write(input);
        }

        return numberFloat;
    }

    public static int ConvertStringInt(string input)
    {
        int numberInt;
        while (!int.TryParse(Console.ReadLine(), out numberInt))
        {
            Console.WriteLine("You did not enter a valid number!");
            Console.Write(input);
        }

        return numberInt;
    }
}