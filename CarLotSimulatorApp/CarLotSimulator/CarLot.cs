using System;

namespace CarLotSimulator;
using System.Collections.Generic;

public class CarLot
{
    
    public List<Car> CarList { get; set; } = new List<Car>();

    public void PrintCars()
    {
        foreach (var car in CarList)
        {
            Console.WriteLine($"{car.Name} stats:\nCar's Year: {car.Year}\nCar's Make: {car.Make}\nCar's Model: {car.Model}\n");
        }
    }
    
}