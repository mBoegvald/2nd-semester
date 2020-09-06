namespace OOP
{
    class Train
    {
        private string name;

        public Train(string name)
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
    }
}