using System;
namespace OOP
{
    class Dvd : Media
    {
        private string director;
        private string mainActor;

        public Dvd(string title, double length, string director, string mainActor) : base(title, length)
        {
            this.director = director;
            this.mainActor = mainActor;
        }

        public override void Play()
        {
            Console.WriteLine("Now playing DVD: " + title + " with main actor: " + mainActor);
        }
    }
}