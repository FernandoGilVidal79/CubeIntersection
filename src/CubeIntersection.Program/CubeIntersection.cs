using CubeIntersection.Process.Builder;
using CubeIntersection.Process.Model;
using System;

namespace CubeIntersection.Program
{
    public class CubeIntersection
    {

        private ICubeBuilder cubeBuilder;
        private Cube cubeA;
        private Cube cubeB;

        public CubeIntersection(ICubeBuilder cubeBuilder)
        {         
            this.cubeBuilder = cubeBuilder;
        }

        public void Execute()
        {
            cubeA = CreateCube("A");
            cubeB = CreateCube("B");
            PrintResult();

        }

        private void PrintResult()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Resultado análisis");

            if (cubeA.Collides(cubeB))
            {
                Console.WriteLine("El Cubo A y B se tocan");
                Console.WriteLine($"El volumen es {cubeA.IntersectionVolume(cubeB)}");
            }
            else
            {
                Console.WriteLine("El Cubo A y B no se tocan");
            }
            Console.ReadLine();
        }

        private Cube CreateCube(string idCube)
        {
            double? coordX = null;
            double? coordY = null;
            double? coordZ = null;
            Cube cube = null;
            try
            {
                /// TODO Improve data validation
                Console.WriteLine($"Datos Cubo {idCube}");
                Console.WriteLine("Introduzca la medida del lado en cm");
                double? lado = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca las coordenadas");
                Console.WriteLine("Coordenada X");
                coordX = double.Parse(Console.ReadLine());
                Console.WriteLine("Coordenada Y");
                coordY = double.Parse(Console.ReadLine());
                Console.WriteLine("Coordenada Z");
                coordZ = double.Parse(Console.ReadLine());
                
                cube = cubeBuilder.WithLength((double)lado).WithCenterAt((double)coordX, (double)coordY, (double)coordZ).Build();
            }
            catch (Exception)
            {
                Console.WriteLine("Error in the inputa Data");
                return null;
            }
            return cube;
        }
    }
}
