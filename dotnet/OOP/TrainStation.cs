using System;

namespace OOP
{
    class TrainStation
    {
        private string name;
        Train[] trains = new Train[5];

        public TrainStation(string name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }

        public bool AddTrain(Train train)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i] == null)
                {
                    trains[i] = train;
                    return true;
                }
            }
            return false;
        }
    }
}