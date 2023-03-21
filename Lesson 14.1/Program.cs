using System;

namespace Lesson_14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Country country = new Country();

            country.Population = 1000000;
            country.Area = 57200;
            country.Density();
        }
    }
}
