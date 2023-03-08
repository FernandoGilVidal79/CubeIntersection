namespace CubeIntersection.Process.Model
{

    /// <summary>
    /// Cube model
    /// </summary>
    public class Cube
    {
        private Side width;
        private Side height;
        private Side depth;


        /// <summary>
        /// Cube Constructor
        /// </summary>
        /// <param name="center"></param>
        /// <param name="length"></param>
        public Cube(Point center, double length)
        {
            width  = new Side(center.CoordX, length);
            height = new Side(center.CoordY, length);
            depth  = new Side(center.CoordZ, length);
        }

        /// <summary>
        /// Get Collides about two cubes
        /// </summary>
        /// <param name="cube">Second cube</param>
        /// <returns>Boolean</returns>
        public bool Collides(Cube cube)
        {
            return width.Collides(cube.width)
                || height.Collides(cube.height)
                || depth.Collides(cube.depth);
        }

        /// <summary>
        /// Get Intersection Volume
        /// </summary>
        /// <param name="cube"></param>
        /// <returns>Volume value</returns>
        public double IntersectionVolume(Cube cube)
        {
            return width.Overlap(cube.width)
                 * height.Overlap(cube.height)
                 * depth.Overlap(cube.depth);
        }
    }
}