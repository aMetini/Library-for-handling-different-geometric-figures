using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Rectangle : Shape2D
    {
        private readonly float Height;
        private readonly float Width;
  
        
        public override float Circumference { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

        public Rectangle(Vector2 center, Vector2 size)
        {
            Center = new Vector3(center, 0.0f);
            Height = size.Y;
            Width = size.X;
            Circumference = 2.0f * (Width + Height);
            Area = Width * Height;

        }

        public Rectangle(Vector2 center, float width)
            : this(center, new Vector2(width))
        {

        }

        public bool IsSquare
        {
            get
                {
                if (Height == Width)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            String shape = "Rectangle";

            if (IsSquare)
            {
                shape = "Square";
            }

            return shape + " @(" + Center.X.ToString("n1") + ", " +
                Center.Y.ToString("n1") + "): w = " +
                Width.ToString("n1") + ", h = " +
                Height.ToString("n1");
        }
    }
}