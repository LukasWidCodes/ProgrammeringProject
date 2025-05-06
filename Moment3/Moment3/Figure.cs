using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment3
{
    public abstract class Figure
    {
        public abstract double GetCircumference(); //Gör allt på engelska för att inte blanda språk, GetOmkrets()=>GetCircumference()
        public abstract double GetArea();
        public abstract string GetFigureName();
    }
}