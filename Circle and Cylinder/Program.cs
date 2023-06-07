using System;

namespace Draw
{
    class Circle
    {
        public double radius;
        public string color;

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return $"Circle - Radius: {radius}, Color: {color} ";
        }
    }

    class Cylinder : Circle
    {
        public double height;

        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            this.height = height;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double GetVolume()
        {
            return Math.PI * radius * radius * height;
        }

        public override string ToString()
        {
            return $"Cylinder - Radius: {GetRadius()}, Color: {GetColor()}, Height: {height}, Volume: {GetVolume()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0, "Red");
            Cylinder cylinder = new Cylinder(3.0, "Blue", 8.0);

            Console.WriteLine(circle.ToString());
            Console.WriteLine(cylinder.ToString());
        }
    }
}