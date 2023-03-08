using CubeIntersection.Process.Model;

namespace CubeIntersection.Process.Builder
{
    /// <summary>
    /// ICubeBuilder Interface
    /// </summary>
    public interface ICubeBuilder 
    {
        /// <summary>
        /// Begin Builder
        /// </summary>
        /// <returns>ICubeBuilder Object</returns>
        ICubeBuilder Begin();

        /// <summary>
        /// Set Center 
        /// </summary>
        /// <param name="coordX">CoordinateX</param>
        /// <param name="coordY">CoordinateY</param>
        /// <param name="coordZ">CoordinateZ</param>
        /// <returns>ICubeBuilder Object</returns>
        public ICubeBuilder WithCenterAt(double coordX, double coordY, double coordZ);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lenth"></param>
        /// <returns>ICubeBuilder Object</returns>
        public ICubeBuilder WithLength(double lenth);

        /// <summary>
        /// Builded Final Object
        /// </summary>
        /// <returns>Cube model object</returns>
        Cube Build();
    }
}