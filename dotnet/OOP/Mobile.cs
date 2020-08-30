using System;

namespace OOP
{
    class MobilePhone
    {
        private string brand, model;
        private double width, length, height, screenSize, cubic;

        public MobilePhone(string brand, string model, double width, double length, double height, double screenSize)
        {
            this.brand = brand;
            this.model = model;
            this.width = width;
            this.length = length;
            this.height = height;
            this.screenSize = screenSize;
            this.cubic = this.calculateCubic(width, length, height);
        }

        public void setMobile(string brand, string model, double width, double length, double height, double screenSize, double cubic)
        {
            this.brand = brand;
            this.model = model;
            this.width = width;
            this.length = length;
            this.height = height;
            this.screenSize = screenSize;
            this.cubic = cubic;
        }

        public double calculateCubic(double width, double length, double height)
        {
            return cubic = this.height * this.length * this.width;

        }

        public override string ToString()
        {
            return brand + ", " + cubic;
        }

    }
}