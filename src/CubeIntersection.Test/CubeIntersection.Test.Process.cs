using CubeIntersection.Process.Builder;
using CubeIntersection.Process.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeIntersection.Test
{
    [TestClass]
    public class CubeIntersection
    {
        [TestMethod]
        public void build_cube()
        {
            var cubeCreator = new CubeBuilder ();
            var cube = cubeCreator.Begin()
                       .WithCenterAt(19, 10, 10)
                       .WithLength(20)
                       .Build();

            Assert.IsNotNull(cube);

        }

        [TestMethod]
        public void two_cubes_dont_touch()
        {
            var cubeCreator =  new CubeBuilder();
            var cubeA = cubeCreator.Begin()
                                   .WithCenterAt(10, 10, 10)
                                   .WithLength(3)
                                   .Build();
            var cubeB = cubeCreator.WithCenterAt(20, 20, 20)
                                   .WithLength(3)
                                   .Build();

            Assert.IsFalse(cubeA.Collides(cubeB));


        }

        [TestMethod]
        public void cubes_that_overlap()
        {
            var cubeBuilder = new CubeBuilder();
            var cubeA = cubeBuilder.Begin().WithCenterAt(2, 2, 2).WithLength(3).Build();
            var cubeB = cubeBuilder.Begin().WithCenterAt(3, 2, 2).WithLength(3).Build();
            Assert.IsTrue(cubeA.Collides(cubeB));
        }

     
        [TestMethod]
        public void cubes_intersection_volume()
        {
            var cubeBuilder = new CubeBuilder();
            var cubeA = cubeBuilder.Begin().WithCenterAt(2, 3, 2).WithLength(3).Build();
            var cubeB = cubeBuilder.Begin().WithCenterAt(3, 3, 2).WithLength(3).Build();
            double result = cubeA.IntersectionVolume(cubeB);
            Assert.IsTrue(result > 0);
        }
    }
}