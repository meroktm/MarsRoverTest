using Microsoft.VisualStudio.TestTools.UnitTesting;

using Rover.Models;

namespace RoverUnitTest
{
    [TestClass]
    public class RoverTest
    {
        [TestMethod]
        public void Index()
        {

            var surface = new Plateau(5, 5);
            var rover1 = new RoverOperation(surface, "1 2 N", "LMLMLMLMM");
            var rover2 = new RoverOperation(surface, "3 3 E", "MMRMMRMRRM");


            // Assert
            Assert.IsTrue(rover1.XCoordinate == 1, "RoverOne: X = 1");
            Assert.IsTrue(rover1.YCoordinate == 3, "RoverOne: Y = 3");
            Assert.IsTrue(rover1.Direction == "N", "RoverOne: Direction = North");

            Assert.IsTrue(rover2.XCoordinate == 5, "RoverTwo: X != 5");
            Assert.IsTrue(rover2.YCoordinate == 1, "RoverTwo: Y != 1");
            Assert.IsTrue(rover2.Direction == "E", "RoverTwo: Direction = East");
        }
    }
}
