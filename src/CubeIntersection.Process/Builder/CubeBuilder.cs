using CubeIntersection.Process.Model;

namespace CubeIntersection.Process.Builder
{
    /// <summary>
    /// Cube Builder
    /// </summary>
    public class CubeBuilder : ICubeBuilder
    {

        private Point center;
        private double sideLength;

        /// <summary>
        /// Begin Object
        /// </summary>
        /// <returns>ICubeBuilder Object</returns>
        public ICubeBuilder Begin()
        {
            return this;
        }

        /// <summary>
        /// Center Position
        /// </summary>
        /// <param name="coordX">Coord X</param>
        /// <param name="coordY">Coord Y</param>
        /// <param name="coordZ">Coord Z</param>
        /// <returns>ICubeBuilder Object</returns>
        public ICubeBuilder WithCenterAt(double coordX, double coordY, double coordZ)
        {
            center = new Point(coordX, coordY, coordZ);
            return this;
        }

        /// <summary>
        /// Side length
        /// </summary>
        /// <param name="length"></param>
        /// <returns>ICubeBuilder Object</returns>
        public ICubeBuilder WithLength(double length)

        {
            sideLength = length;
            return this;
        }

        /// <summary>
        /// Return a Constructed Cube
        /// </summary>
        /// <returns></returns>
        public Cube Build()
        {
            return new Cube(center, sideLength);
        }
    }
}
