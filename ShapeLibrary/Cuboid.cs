using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Cuboid : Shape3D
    {
        private float Height;
        private float Width;
        private float Depth;


        public override float Volume { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }


        public Cuboid(Vector3 center, Vector3 size)
        {
            Center = center;
            Height = size.Y;
            Width = size.X;
            Depth = size.Z;
            Area = ((2.0f * Width * Height) + (2.0f * Width * Depth) + (2.0f * Depth * Height));
            Volume = Width * Depth * Height;
        }

        public Cuboid(Vector3 center, float width)
            : this(center, new Vector3(width))
        {

        }

        public bool IsCube
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
            String shape = "Cuboid";

            if (IsCube)
            {
                shape = "Cube";
            }
            return shape + " @(" + Center.X.ToString("n1") + ", " +
                Center.Y.ToString("n1") + ", " +
                Center.Z.ToString("n1") + ", " +
                Width.ToString("n1") + ", " +
                Height.ToString("n1") + ", " +
                Depth.ToString("n1");
        }
    }
}


            

