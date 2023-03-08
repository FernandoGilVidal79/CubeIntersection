namespace CubeIntersection.Process.Model
{

    /// <summary>
    /// Point Model
    /// </summary>
    public class Point
    {
        public double CoordX { get; }
        public double CoordY { get; }
        public double CoordZ { get; }

        /// <summary>
        /// Point Constructor
        /// </summary>
        /// <param name="coordX">CoordX</param>
        /// <param name="coordY">CoordY</param>
        /// <param name="coordZ">CoordZ</param>
        public Point(double coordX, double coordY, double coordZ)
        {
            CoordX = coordX;
            CoordY = coordY;
            CoordZ = coordZ;
        }
    }
}