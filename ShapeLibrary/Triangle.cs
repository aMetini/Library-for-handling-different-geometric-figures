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


        private Vector2[] vectArray = new Vector2[3];


        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Circumference { get; }



        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;

            vectArray[0] = p1;
            vectArray[1] = p2;
            vectArray[2] = p3;

            float side1 = MathF.Sqrt(MathF.Pow((p1.X - p2.X), 2) + MathF.Pow((p1.Y - p2.Y), 2));
            float side2 = MathF.Sqrt(MathF.Pow((p1.X - p3.X), 2) + MathF.Pow((p1.Y - p3.Y), 2));
            float side3 = MathF.Sqrt(MathF.Pow((p3.X - p2.X), 2) + MathF.Pow((p3.Y - p2.Y), 2));


            Circumference = side1 + side2 + side3;

            Area = MathF.Abs(MathF.Sqrt((Circumference / 2f) * ((Circumference / 2f) - side1) *
                ((Circumference / 2f) - side2) * ((Circumference / 2f) - side3)));

            Center = new Vector3()
            {
                X = (p1.X + p2.X + p3.X) / 3f,
                Y = (p1.Y + p2.Y + p3.Y) / 3f,
            };

            
        }

        public override string ToString()
        {
            return
                $"Triangle @({Center.X:0.0}, {Center.Y:0.0}): p1({P1.X:0.0}, {P1.Y:0.0}), p2({P2.X:0.0}, {P2.Y:0.0}), p3({P3.X:0.0}, {P3.Y:0.0})";

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






