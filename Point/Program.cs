using System;

namespace Point
{
    class Point2D
    {
        public float x;
        public float y;

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float GetX()
        {
            return x;
        }

        public void SetX(float x)
        {
            this.x = x;
        }

        public float GetY()
        {
            return y;
        }

        public void SetY(float y)
        {
            this.y = y;
        }

        public float[] GetXY()
        {
            return new float[] { x, y };
        }

        public override string ToString()
        {
            return $"Point2D - X: {x}, Y: {y} ";
        }
    }

    class Point3D : Point2D
    {
        public float z;

        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }

        public float GetZ()
        {
            return z;
        }

        public void SetZ(float z)
        {
            this.z = z;
        }
        public float[] GetXYZ()
        {
            return new float[] { GetX(), GetY(), z };
        }

        public override string ToString()
        {
            return $"Point3D - X: {GetX()}, Y: {GetY()}, Z: {z}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D(2, 3);
            Point3D point3D = new Point3D(3, 4, 5);

            Console.WriteLine(point2D.ToString());
            Console.WriteLine(point3D.ToString());

            float[] xy = point2D.GetXY();
            Console.WriteLine($"Point2D XY: ({xy[0]}, {xy[1]})");

            float[] xyz = point3D.GetXYZ();
            Console.WriteLine($"Point3D XYZ: ({xyz[0]}, {xyz[1]}, {xyz[2]})");
        }
    }
}