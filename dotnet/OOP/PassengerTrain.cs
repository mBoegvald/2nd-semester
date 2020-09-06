namespace OOP
{
    class PassengerTrain : Train
    {
        private int MaxPassengers;

        public PassengerTrain(string name, int MaxPassengers) : base(name)
        {
            this.MaxPassengers = MaxPassengers;
        }
    }
}