using System;

namespace CarLotSimulator;

public class Car
{
    public string Name { get; set; }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string car, string noise)
    {
        Console.WriteLine($"My car's name is {Name} and it's engine noise is {noise}");
    }

    public void MakeHonkNoise(string car, string noise)
    {
        Console.WriteLine($"My car's name is {Name} and it's honking noise level is {noise}");
    }

    public Car()
    {
        
    }

    public Car(string name, int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
    {
        Name = name;
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDriveable = isDriveable;

    }

    public void PrintCar()
    {
        
    }
}