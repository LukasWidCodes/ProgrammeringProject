using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment3
{
    public class Circle : Figure
    {
        private double radie;

        public Circle(double radie) //Konstruktor så att den kan ta in input
        {
            this.radie = radie;
        }

        public override double GetCircumference()
        {
            return Math.PI * 2 * radie; //Matte för att räkna ut omkrets
        }

        public override double GetArea()
        {
            return Math.Pow(radie, 2) * Math.PI; //Matte för att räkna ut area
        }

        public override string ToString()
        {
            return $"{GetFigureName()} | The circle's area is: {GetArea()} and it's circumference is: {GetCircumference()}";
        }

        public override string GetFigureName()
        {
            return "Circle";
        }
    }
}