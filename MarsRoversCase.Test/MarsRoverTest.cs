using NUnit.Framework;
using System.Collections.Generic;

namespace MarsRoversCase.Test
{
    public class MarsRoverTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TEST_12N_LMLMLMLMM()
        {
            Position position = new Position()
            {
                X = 1,
                Y = 2,
                Direction = Direction.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            string moves = "LMLMLMLMM";

            position.StartMove(maxPoints, moves);

            string output = $"{position.X} {position.Y} {position.Direction}"; 

            Assert.Pass("1 3 N", output);
        }

        [Test]
        public void TEST_33E_MMRMMRMRRM()
        {
            var position = new Position()
            {
                X = 3,
                Y = 3,
                Direction = Direction.E
            };

            var maxPoints = new List<int>() { 5, 5 };
            string moves = "MMRMMRMRRM";

            position.StartMove(maxPoints, moves);

            string output = $"{position.X} {position.Y} {position.Direction}";

            Assert.Pass("5 1 E", output);
        }
    }
}