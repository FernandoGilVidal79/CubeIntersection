# CubeIntersection
## Enunciado

Design and start and application (or test project) which accepts as input dimensions and coordinates of two cubic objects (considering a 3D space). The application must determine whether the two objects collide and calculate the intersected volume.
It's not a math exercise, so it is acceptable to consider the two cubes are parallel, so there is no rotation among themselves.The input coordinates define the center of the cube. The purpose of this exercise is to define the application design and architecture, focusing on the parts which ensure the correctness, performance and code clarity. Any design pattern is
accepted and should be justified.

# Respuesta

Se he generado un proyecto en .NET 6 que consta de los siguiente proyectos
  - CubeIntersection.Process. Librería en NET Standard que contiene el modelo   y la creación de objetos mediante el patrón Builder.
  - CubeIntersection.Program. Aplicación de Consola que hace un testeo del funcionamiento de la apicación desde unos datos introducidos por pantalla.
  - CubeIntersection.Test. Aplicación de Test que realiza peticiones a CubeIntersection.Process para probar determinados supuestos en la comparación de los cubos.

 # Explicación
Se ha realizado una aplicación de Consola, porque he pensado que los tests se quedaban un poco cortos y nos ha permitido poner en practica la inyección de Dependencias a una aplicación de consola.


### Patron Builder

Se ha utilizado el patrón [Fluent Builder](https://dev.to/siy/simple-implementation-of-fluent-builder-safe-alternative-to-traditional-builder-3m1d) para la creación de los objetos Cube. Nos facilita la creación de dichos objetos complejos ocultando su implementación. Era un patrón que podía encajar con la implementación de la solución.
