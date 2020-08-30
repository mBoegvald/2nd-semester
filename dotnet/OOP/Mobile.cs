using System;

namespace OOP
{
    class MobilePhone
    {
        private string brand, model;
        private double width, length, height, screenSize, cubic;

        public Chip Chip { get; }
        public MobilePhone(string brand, string model, double width, double length, double height, double screenSize, Chip chip)
        {
            this.brand = brand;
            this.model = model;
            this.width = width;
            this.length = length;
            this.height = height;
            this.screenSize = this.calculateScreenSize(screenSize);
            this.cubic = this.calculateCubic(width, length, height);
            this.Chip = chip;
        }

        // public setMobile(string brand, string model, double width, double length, double height, double screenSize, double cubic)
        // {
        //     this.brand = brand;
        //     this.model = model;
        //     this.width = width;
        //     this.length = length;
        //     this.height = height;
        //     this.screenSize = screenSize;
        //     this.cubic = cubic;
        // }

        public double calculateCubic(double width, double length, double height)
        {
            return cubic = this.height * this.length * this.width;

        }
        public double calculateScreenSize(double screenSize)
        {
            return screenSize = (screenSize - 1) / 2;
        }

        public override string ToString()
        {
            return brand + ", " + ", " + cubic + ", " + Chip.Name;
        }

    }
}