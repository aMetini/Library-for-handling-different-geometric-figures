using System;
using System.Collections.Generic;
using ShapeLibrary;

namespace Lab2ShapeGeneratorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_SHAPES = 20;
            List<Shape> shapesList = new List<Shape>();
            float sumTrianglePerimeters = 0;
            float averageAreaofAllShapes = 0;
            Shape3D largestVolumeShape = null;
            String largestVolumeShapeString;

            for (int i = 0; i < NUMBER_OF_SHAPES; i++)
            {
                shapesList.Add(Shape.GenerateShape());
            }

            for (int i = 0; i < NUMBER_OF_SHAPES; i++)
            {
                Console.WriteLine(shapesList[i]);

                if (shapesList[i].GetType() == typeof(Triangle))
                {
                    sumTrianglePerimeters += ((Triangle)shapesList[i]).Circumference;
                }

                averageAreaofAllShapes += shapesList[i].Area;

                if (shapesList[i].GetType().IsSubclassOf(typeof(Shape3D)))
                {
                    {
                        if (largestVolumeShape == null)
                        {
                            largestVolumeShape = (Shape3D)shapesList[i];
                        }
                        else
                        {
                            if (((Shape3D)shapesList[i]).Volume > largestVolumeShape.Volume)
                            {
                                largestVolumeShape = (Shape3D)shapesList[i];
                            }

                        }
                    }
                }

            }
            Console.WriteLine("\nTriangle Perimeter Sum: " + sumTrianglePerimeters);
            Console.WriteLine("Average Area of all Shapes: " + (averageAreaofAllShapes / NUMBER_OF_SHAPES));



            if (largestVolumeShape == null)
            {
                largestVolumeShapeString = "No Shape3D Found";
            }
            else
            {
                largestVolumeShapeString = largestVolumeShape.ToString();

            }

            Console.WriteLine("3D Shape with Largest Volume: " + largestVolumeShapeString);


        }
    }
}