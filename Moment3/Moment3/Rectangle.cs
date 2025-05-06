using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment3
{
    public class Rectangle : Figure
    {
        private double length;
        private double width;

        public Rectangle(double length, double width) //Konstruktor så att den kan ta in input
        {
            this.length = length;
            this.width = width;
        }

        public override double GetCircumference() //Matte för att räkna ut omkrets
        {
            return 2 *(length + width);
        }
        public override double GetArea() //Matte för att räkna ut area
        {
            return length * width;
        }
        public override string GetFigureName()
        {
            return "Rectangle";
        }
        public override string ToString()
        {
            return $"{GetFigureName()} | The rectangle's area is: {GetArea()} and it's circumference is: {GetCircumference()}";
        }
    }
}
