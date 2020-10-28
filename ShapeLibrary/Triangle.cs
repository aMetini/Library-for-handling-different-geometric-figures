using System;
using System.Collections.Generic;
using System.Collections;
using System.Numerics;


namespace ShapeLibrary  
{
    public class Triangle : Shape2D, IEnumerable
    {
        private Vector2 P1;
        private Vector2 P2;
        private Vector2 P3;

        public override float Circumference { get; }

        public override float Area { get; }

        public override Vector3 Center { get; }

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {

            Center = new Vector3()
            {
                X = (P1.X + P2.X + P3.X) / 3f,
                Y = (P1.Y + P2.Y + P3.Y) / 3f,
                Z = 0.0f
            };

            P1.X = p1.X;
            P1.Y = p1.Y;

            P2.X = p2.X;
            P2.Y = p2.Y;

            P3.X = p3.X;
            P3.Y = p3.Y;


            Circumference = GetCircumference();

            Area = MathF.Abs(1.0f / 2.0f *
                (P1.X * (P2.Y - P3.Y)) +
                (P2.X * (P3.Y - P1.Y)) +
                (P3.X * (P1.Y - P2.Y)));

        }

        public override string ToString()
        {
            return "Triangle @(" + Center.X.ToString("n1") + ", " + Center.Y.ToString("n1") +
                "): p1 (" + P1.X.ToString("n1") + ", " + P1.Y.ToString("n1") +
                "), p2 (" + P2.X.ToString("n1") + ", " + P2.Y.ToString("n1") +
                "), p3 (" + P3.X.ToString("n1") + ", " + P3.Y.ToString("n1") + ")";
        }

        public float GetCircumference()
        {
            float side1 = MathF.Sqrt(MathF.Pow(P1.X - P2.X, 2) + MathF.Pow(P1.Y - P2.Y, 2));
            float side2 = MathF.Sqrt(MathF.Pow(P2.X - P3.X, 2) + MathF.Pow(P2.Y - P3.Y, 2));
            float side3 = MathF.Sqrt(MathF.Pow(P3.X - P2.X, 2) + MathF.Pow(P3.Y - P2.Y, 2));

            return side1 + side2 + side3;

        }

        public IEnumerator<Vector2> GetEnumerator()
        {
            return new TrianglePointEnumerator(P1, P2, P3);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class TrianglePointEnumerator : IEnumerator<Vector2>
    {
        List<Vector2> PointsList;
        private int index;

        public int Current => 0;

        object IEnumerator.Current => Current;

        Vector2 IEnumerator<Vector2>.Current => PointsList[index];

        public TrianglePointEnumerator(Vector2 P1, Vector2 P2, Vector2 P3)
        {
            index = -1;
            PointsList = new List<Vector2>();
            PointsList.Add(P1);
            PointsList.Add(P2);
            PointsList.Add(P3);
        }


        public bool MoveNext()
        {
            bool retVal = true;
            index++;

            if (index > 2)
            {
                retVal = false;
            }

            return retVal;
        }

        public void Reset()
        {
            index = -1;
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }


                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}






