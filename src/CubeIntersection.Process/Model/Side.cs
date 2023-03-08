using System;

namespace CubeIntersection.Process.Model
{
    /// <summary>
    /// Side Model
    /// </summary>
    public class Side
    {
        private readonly double start;
        private readonly double end;

        /// <summary>
        /// Side Constructor
        /// </summary>
        /// <param name="center"></param>
        /// <param name="length"></param>
        public Side(double center, double length)
        {
            start = center - length / 2.0;
            end   = center + length / 2.0; 
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        public double Overlap(Side side)
        {
           return Math.Max(0, Difference(side));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        public bool Collides(Side side)
        {
           return Difference(side) >= 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        private double Difference(Side side)
        {
            return Math.Min(end, side.end) - Math.Max(start, side.start);
        }
      
    }
}
