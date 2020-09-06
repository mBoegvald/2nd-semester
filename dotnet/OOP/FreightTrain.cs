namespace OOP
{
    class FreightTrain : Train
    {
        private int MaxSize, MaxWeight;

        public FreightTrain(string name, int MaxSize, int MaxWeight) : base(name)
        {
            this.MaxSize = MaxSize;
            this.MaxWeight = MaxWeight;
        }
    }
}