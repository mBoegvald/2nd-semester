using System;
using System.Collections.Generic;

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

            // Chip chip1 = new Chip("Nice name", 300);

            // MobilePhone mobile1 = new MobilePhone("Nokia", "3210", 10, 15, 2, 4.7, chip1);

            // Console.WriteLine(mobile1);
            // Console.WriteLine(car1.model);
            // Console.WriteLine(car1.color);
            // Console.WriteLine(car1.numberOfDoors);

            // Cd cd1 = new Cd("Backstreet boys are back!", 10, "Backstreet Boys");
            // // cd1.Play();

            // Dvd dvd1 = new Dvd("Dvd title", 1, "et navn", "et andet navn");

            // // dvd1.Play();

            // List<Media> medias = new List<Media>();

            // // Polymophism - A Cd object or Dvd, has many "shapes" or types. A Cd and a media or Dvd 
            // // and media therefore you can create a list of media and put Cds and Dvds in the list
            // medias.Add(cd1);
            // medias.Add(dvd1);

            // foreach (Media media in medias)
            // {
            //     media.Play();
            // }

            TrainStation station = new TrainStation("Hellerup");
            PassengerTrain train1 = new PassengerTrain("Tog1", 10);
            // Console.WriteLine(train1.getName());
            Console.WriteLine(station.AddTrain(train1));

            Console.WriteLine("Hello World!");
        }
    }
}
