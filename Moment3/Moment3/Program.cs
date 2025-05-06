using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Moment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWrite a number between 0-4 depending on which figure you want!"); //Meny med olika val
                Console.WriteLine("Your options are:");
                Console.WriteLine("<=|| 0. End Program | 1. Circle | 2. Square | 3. Triangle | 4. Rectangle ||=>");
                char val = Console.ReadKey(true).KeyChar;
                switch (val)
                {
                    case '0':
                        return;
                    case '1':
                        MyCircleMethod();
                        break;
                    case '2':
                        MySquareMethod();
                        break;
                    case '3':
                        MyTriangleMethod();
                        break;
                    case '4':
                        MyRectangleMethod();
                        break;
                }
            }
        }
        static void MyCircleMethod()
        {
            Console.Write("\nWrite a radius for the circle: ");
            if (double.TryParse(Console.ReadLine(), out double radie)) //Tar in input från användaren
            {
                Circle circle = new Circle(radie); //Skapar en ny cirkel som tar in input och använder den för sina matte metoder
                Console.WriteLine(circle.ToString()); //Skriver ut Area och Omkrets
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        static void MySquareMethod()
        {
            Console.Write("\nWrite the length of the sides for the square: ");
            if (double.TryParse(Console.ReadLine(), out double length))
            {
                Square square = new Square(length); //Skapar en kvadrat och använder input för sina matte metoder
                Console.WriteLine(square.ToString());
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        static void MyTriangleMethod()
        {
            Console.Write("\n(1st) Write the length of the first side of the triangle: ");
            if (double.TryParse(Console.ReadLine(), out double side1)) //Input för första sidan 
            {
                Console.Write("(2nd) Write the length of the second side of the triangle: ");
                if (double.TryParse(Console.ReadLine(), out double side2)) //Input för andra sidan
                {
                    Console.Write("(3rd) Write the length of the third side of the triangle: ");
                    if (double.TryParse(Console.ReadLine(), out double side3)) //Input för tredje sidan
                    {
                        Triangle triangle = new Triangle(side1, side2, side3); //Använder alla inputs för att skapa en ny triangel och använder matte metoderna
                        Console.WriteLine(triangle.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        static void MyRectangleMethod()
        {
            Console.Write("\nWrite the lenght of the rectangle: ");
            if (double.TryParse(Console.ReadLine(), out double lengthRectangle)) //Tar in längden
            {
                Console.Write("Write the width of the rectangle: ");
                if (double.TryParse(Console.ReadLine(), out double width)) //Tar in bredden
                {
                    Rectangle rectangle = new Rectangle(lengthRectangle, width); //Skapar en rektangel och kör matte metoderna
                    Console.WriteLine(rectangle.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
