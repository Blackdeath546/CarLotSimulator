using System;
using System.Collections.Generic;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var TheCarLot = new CarLot();
            
            //TODO

            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            Car Debbie = new Car();
            Car Luis = new Car();
            Car Nkkii = new Car();

            //Set the properties for each of the cars
            Debbie.Name = "Debbie";
            Debbie.Year = 1995;
            Debbie.Make = "Toyota";
            Debbie.Model = "Camry";
            Debbie.EngineNoise = "Medium";
            Debbie.HonkNoise = "Low";
            Debbie.IsDriveable = true;
            
            TheCarLot.CarList.Add(Debbie);

            Luis.Name = "Luis";
            Luis.Year = 2013;
            Luis.Make = "DizzyLizzy";
            Luis.Model = "D";
            Luis.EngineNoise = "LOUD";
            Luis.HonkNoise = "SILLY";
            Luis.IsDriveable = true;
            
            TheCarLot.CarList.Add(Luis);
            
            Nkkii.Name = "Nkkii";
            Nkkii.Year = 2025;
            Nkkii.Make = "Tesla";
            Nkkii.Model = "4";
            Nkkii.EngineNoise = "Quiet";
            Nkkii.HonkNoise = "Varies";
            Nkkii.IsDriveable = false;
            
            TheCarLot.CarList.Add(Nkkii);

            //Call each of the methods for each car
            Debbie.MakeEngineNoise(Debbie.Name, Debbie.EngineNoise);
            Luis.MakeEngineNoise(Luis.Name, Luis.EngineNoise);
            Nkkii.MakeEngineNoise(Nkkii.Name, Nkkii.EngineNoise);
            
            Debbie.MakeHonkNoise(Debbie.Name, Debbie.HonkNoise);
            Luis.MakeHonkNoise(Luis.Name, Luis.HonkNoise);
            Nkkii.MakeHonkNoise(Nkkii.Name, Nkkii.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car TheJaclyn = new Car()
            {
                Name = "TheJaclyn",
                Year = 1998,
                Make = "MusicJunkie",
                Model = "Swifty",
                EngineNoise = "Shy",
                HonkNoise = "BrainItchy",
                IsDriveable = true
            };
            
            TheCarLot.CarList.Add(TheJaclyn);
            
            Car Furrawri = new Car("Furrawri", 1976, "ABBA", "Fernando", "Pleasantly Loud", "Catchy", true);
            
            TheCarLot.CarList.Add(Furrawri);
            // {
            //     Name = "Furrawri",
            //     Year = 1976,
            //     Make = "ABBA",
            //     Model = "Fernando",
            //     EngineNoise = "Pleasantly Loud",
            //     HonkNoise = "Catchy",
            //     IsDriveable = true
            //
            // };

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            TheCarLot.PrintCars();
        }
    }
}
