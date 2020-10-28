using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Sphere: Shape3D
    { 
        private readonly float Radius;

        public override float Volume { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }

   
        public Sphere(Vector3 center, float radius)
        {
            Center = center;
            Radius = radius;
            Volume = (4.0f / 3.0f) * MathF.PI * MathF.Pow(radius, 3);
            Area = 4.0f * MathF.PI * MathF.Pow(radius, 2);
        }

        public override string ToString()
        {
            return "Sphere @(" + Center.X.ToString("n1") + ", " +
                Center.Y.ToString("n1") + ", " +
                Center.Z.ToString("n1") + "): r = " +
                Radius.ToString("n1");
        }
    }
}