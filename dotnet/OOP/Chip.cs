namespace OOP
{
    class Chip
    {
        public string Name { get; set; }
        public double ProcessingPower { get; set; }

        // Constructor
        public Chip(string name, double processingPower)
        {
            this.Name = name;
            this.ProcessingPower = processingPower;
        }
        // Default constructor - 
        public Chip(double process)
        {
            this.ProcessingPower = process;
        }

    }
}