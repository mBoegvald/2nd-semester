using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            // Car exercise

            //type objName = new class();
            // Default constructor
            // Engine engine1 = new Engine(230);
            // Engine engine2 = new Engine("V8", 300);


            // Car car1 = new Car("Tesla", "Model 3", "Black", 4, engine1);
            // Car car2 = new Car("Ford", "Focus", "White", 5, engine2);

            // This is not allowed, because I deleted the "set-method".
            // car1.Engine = engine2;


            // Mobile exercise

            Chip chip1 = new Chip("Nice name", 300);

            MobilePhone mobile1 = new MobilePhone("Nokia", "3210", 10, 15, 2, 4.7, chip1);

            Console.WriteLine(mobile1);
            // Console.WriteLine(car1.model);
            // Console.WriteLine(car1.color);
            // Console.WriteLine(car1.numberOfDoors);

            Console.WriteLine("Hello World!");
        }
    }
}
