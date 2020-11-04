using System;
using System.Numerics;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            Shape shape = null;
            Random random = new Random();
            int randomInt = random.Next(0, 7);
            Vector2 center2D = new Vector2();
            Vector2 size2D = new Vector2();
            Vector3 center3D = new Vector3();
            Vector3 size3D = new Vector3();
            Vector2 p1 = new Vector2();
            Vector2 p2 = new Vector2();
            Vector2 p3 = new Vector2();
            float radius;
            float width;

            switch (randomInt)
            {
                case 0:
                    center2D.X = (float)random.NextDouble() * 10f;
                    center2D.Y = (float)random.NextDouble() * 10f;
                    radius = (float)random.NextDouble() * 10f;
                    shape = new Circle(center2D, radius);
                    break;
                case 1:
                    center2D.X = (float)random.NextDouble() * 10f;
                    center2D.Y = (float)random.NextDouble() * 10f;
                    size2D.X = (float)random.NextDouble() * 10f;
                    size2D.X = (float)random.NextDouble() * 10f;
                    shape = new Rectangle(center2D, size2D);
                    break;
                case 2:
                    center2D.X = (float)random.NextDouble() * 10f;
                    center2D.Y = (float)random.NextDouble() * 10f;
                    width = (float)random.NextDouble() * 10f;
                    shape = new Rectangle(center2D, width);
                    break;
                case 3:
                    p1.X = (float)random.NextDouble() * 10f;
                    p1.Y = (float)random.NextDouble() * 10f;
                    p2.X = (float)random.NextDouble() * 10f;
                    p2.Y = (float)random.NextDouble() * 10f;
                    p3.X = (float)((3 * center2D.X) - p1.X - p2.X);
                    p3.Y = (float)((3 * center2D.Y) - p1.Y - p2.Y);
                    shape = new Triangle(p1, p2, p3);
                    break;
                case 4:
                    center3D.X = (float)random.NextDouble() * 10f;
                    center3D.Y = (float)random.NextDouble() * 10f;
                    center3D.Z = (float)random.NextDouble() * 10f;
                    size3D.X = (float)random.NextDouble() * 10f;
                    size3D.Y = (float)random.NextDouble() * 10f;
                    size3D.Z = (float)random.NextDouble() * 10f;
                    shape = new Cuboid(center3D, size3D);
                    break;
                case 5:
                    center3D.X = (float)random.NextDouble() * 10f;
                    center3D.Y = (float)random.NextDouble() * 10f;
                    center3D.Z = (float)random.NextDouble() * 10f;
                    width = (float)random.NextDouble() * 10f;
                    shape = new Cuboid(center3D, width);
                    break;
                case 6:
                    center3D.X = (float)random.NextDouble() * 10f;
                    center3D.Y = (float)random.NextDouble() * 10f;
                    center3D.Z = (float)random.NextDouble() * 10f;
                    radius = (float)random.NextDouble() * 10f;
                    shape = new Sphere(center3D, radius);
                    break;
                default:
                    Console.WriteLine("Error: Invalid shape requested.");
                    break;
            }

            return shape;

        }
        public static Shape GenerateShape(Vector3 center)
        {
            Shape shape = null;
            Random random = new Random();
            int randomInt = random.Next(0, 7);
            Vector2 center2D = new Vector2();
            Vector2 size2D = new Vector2();
            Vector3 center3D = new Vector3();
            Vector3 size3D = new Vector3();
            Vector2 p1 = new Vector2();
            Vector2 p2 = new Vector2();
            Vector2 p3 = new Vector2();
            float radius;
            float width;

            switch (randomInt)
            {
                case 0:
                    center2D.X = center.X;
                    center2D.Y = center.Y;
                    Vector2 circleCenter = new Vector2(center.X, center.Y);
                    radius = (float)random.NextDouble() * 10f;
                    shape = new Circle(circleCenter, radius);
                    break;
                case 1:
                    center2D.X = center.X;
                    center2D.Y = center.Y;
                    Vector2 rectangleCenter = new Vector2(center.X, center.Y);
                    size2D.X = (float)random.NextDouble() * 10f;
                    size2D.Y = (float)random.NextDouble() * 10f;
                    shape = new Rectangle(rectangleCenter, size2D);
                    break;
                case 2:
                    center2D.X = center.X;
                    center2D.Y = center.Y;
                    Vector2 squareCenter = new Vector2(center.X, center.Y);
                    width = (float)random.NextDouble() * 10f;
                    shape = new Rectangle(squareCenter, width);
                    break;
                case 3:
                    p1.X = (float)random.NextDouble() * 10f;
                    p1.Y = (float)random.NextDouble() * 10f;
                    p2.X = (float)random.NextDouble() * 10f;
                    p2.Y = (float)random.NextDouble() * 10f;
                    p3.X = (float)random.NextDouble() * 10f;
                    p3.Y = (float)random.NextDouble() * 10f;
                    shape = new Triangle(p1, p2, p3);
                    break;
                case 4:
                    center3D.X = center.X;
                    center3D.Y = center.Y;
                    center3D.Z = center.Z;
                    size3D.X = (float)random.NextDouble() * 10f;
                    size3D.Y = (float)random.NextDouble() * 10f;
                    size3D.Z = (float)random.NextDouble() * 10f;
                    shape = new Cuboid(center, size3D);
                    break;
                case 5:
                    center3D.X = center.X;
                    center3D.Y = center.Y;
                    center3D.Z = center.Z;
                    width = (float)random.NextDouble() * 10f;
                    shape = new Cuboid(center, width);
                    break;
                case 6:
                    center3D.X = center.X;
                    center3D.Y = center.Y;
                    center3D.Z = center.Z;
                    radius = (float)random.NextDouble() * 10f;
                    shape = new Sphere(center, radius);
                    break;
                default:
                    Console.WriteLine("Error: Invalid shape requested.");
                    break;
            }

            return shape;


        }
    }
}