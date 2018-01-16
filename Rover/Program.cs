using Rover.Models;
using System;

namespace Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            var surface = new Plateau(5, 5);
            var rover1 = new RoverOperation(surface, "1 2 N", "LMLMLMLMM");
            var rover2 = new RoverOperation(surface, "3 3 E", "MMRMMRMRRM");

            Console.WriteLine("Rover 1");

            Console.WriteLine("XCoordinate : " + rover1.XCoordinate);
            Console.WriteLine("YCoordinate : " + rover1.YCoordinate);
            Console.WriteLine("Direction : " + rover1.Direction);

            Console.WriteLine("Rover 2");

            Console.WriteLine("XCoordinate : " + rover2.XCoordinate);
            Console.WriteLine("YCoordinate : " + rover2.YCoordinate);
            Console.WriteLine("Direction : " + rover2.Direction);
        }
    }
}
