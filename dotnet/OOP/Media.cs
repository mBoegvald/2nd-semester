using System;
namespace OOP
{
    class Media
    {

        //private on accessible within the class
        //protected: only accessible withing the class and sub-classes
        protected string title;
        private double length;

        public Media(string title, double length)
        {
            this.title = title;
            this.length = length;
        }

        public virtual void Play()
        {
            Console.WriteLine("Now playing " + title);
        }
    }
}