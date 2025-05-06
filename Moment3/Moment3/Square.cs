using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment3
{
    public class Square : Figure
    {
        private double side;

        public Square(double side) //Konstruktor så att den kan ta in input
        {
            this.side = side;
        }
        public override double GetCircumference() //Matte för att räkna ut omkrets
        {
            return side * 4;
        }
        public override double GetArea() //Matte för att räkna ut area
        {
            return side * side;
        }

        public override string GetFigureName()
        {
            return "Square";
        }
        public override string ToString()
        {
            return $"{GetFigureName()} | The square's area is: {GetArea()} and it's circumference is: {GetCircumference()}";
        }
    }
}
