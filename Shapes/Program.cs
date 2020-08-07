using System;

namespace UnitTestDemonstration
{
    public class Shapes
    {
        // Private fields
        private double height, width, radius;
        private const double pi = 3.142; // Define the value of pi

        //Constructor to create a Circle
        public Shapes(double rad)
        {
            radius = rad;
        }
        //Constructor to create a rectangle
        public Shapes(double ht, double wd)
        {
            height = ht;
            width = wd;
        }
        // Method to calculate the area of Rectangle
        public double RectangleArea()
        {
            return (height * width);
        }
        // Method to calculate the area of Circle
        public double CircleArea()
        {
            return (pi * radius*radius);
        }
        public void Display(char shapeType)
        {
            if (shapeType == 'r')
                Console.WriteLine("Height and Width of rectangle is: {0}, {1}", height, width);
            else if(shapeType == 'c')
                Console.WriteLine("Radius of circle is: {0}", radius);
        }
    }
    class ShapesTest
    {
        static void Main(string[] args)
        {
            // Create Shape object as per test case
            Shapes circle = new Shapes(4.0);
            Shapes rectangle = new Shapes(5.0, 4.0);

            // Display the object properties
            circle.Display('c');
            rectangle.Display('r');

            // Calculate and display the area of the objects
            Console.WriteLine("The area of circle is {0}", circle.CircleArea());
            Console.WriteLine("The area of rectangle is {0}", rectangle.RectangleArea());

            // Accept a key press from user
            Console.ReadKey();
        }
    }
}

