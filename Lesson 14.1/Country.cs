using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14._1
{
    class Country : ICountry
    {
        private int population;
        public int Population { get { return population; } set { population = value; } }
        public int Army { get; set;}
        private double area;
        public double Area { get { return area; } set { area = value; } }
        public string Name { get; set; }

        public void Density()
        {
            Console.WriteLine("Density = " + Population/Area + " ppl/km^2");
        }
    }
}
