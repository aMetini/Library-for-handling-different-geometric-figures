using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Circle: Shape2D
    {
        private float circleRadius;

        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }
        
        public Circle(Vector2 center, float radius)
        {
            Center = new Vector3(center, 0.0f);
            circleRadius = radius;
            Circumference = 2.0f * MathF.PI * radius;
            Area = MathF.PI * MathF.Pow(radius, 2);
        }

        public override string ToString()
        {
            return "Circle @(" + Center.X.ToString("n1") + ", " +
                Center.Y.ToString("n1") + "): r = " +
                circleRadius.ToString("n1");
        }
       
    }
}
