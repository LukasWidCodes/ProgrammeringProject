using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment3
{
    public class Triangle : Figure
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3) //Konstruktor så att den kan ta in input
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double GetCircumference() //Matte för att räkna ut omkrets
        {
            return side1 + side2 + side3;
        }
        public override double GetArea() //Matte för att räkna ut area
        {
            double s = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(s *(s -side1) * (s -side2) * (s - side3)); //Använde Heron's formula hittade den här: https://www.cuemath.com/measurement/area-of-triangle/ under Area of Triangle Using Heron's Formula
            return area;
        }
        public override string GetFigureName()
        {
            return "Triangle";
        }
        public override string ToString()
        {
            return $"{GetFigureName()} | The triangle's area is: {GetArea()} and it's circumference is: {GetCircumference()}";
        }
    }
}
