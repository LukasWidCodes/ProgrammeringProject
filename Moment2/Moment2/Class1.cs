using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment2
{
    class FordonKlass
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Year { get; private set; }

        private int id;

        private static int indexCounter = 0;
        public FordonKlass(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
            id = indexCounter;
            indexCounter++;
        }
        public FordonKlass(string make, string model, int year) //Använder denna
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            id = indexCounter;
            indexCounter++;
        }
        public override string ToString()
        {

            return $"Fordonstyp: {Make} | Modell: {Model} | Årsmodell: {Year}";
        }
    }
}
