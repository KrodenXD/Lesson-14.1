using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14._1
{
    interface ICountry
    {
        public int Population { get; set; }
        public int Army { get; set; }
        public double Area { get; set; }
        public string Name { get; set; }

        public void Density();
    }
}
