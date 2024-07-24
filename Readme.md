
Estimados, el proyecto creado no posee tanta logica de negocio pero en si podemos ver un patron de diseño aplicado, el patrón de diseño Mediator, utilizando la biblioteca de MediaTr. Tambien he aplicado inyecciones de dependencias para que cada uno maneje su propia logica, el codigo esta limpio y facil de leer.
Tambien he utilizado la biblioteca de XUnit para la utilizacion de pruebas unitarias.
He agregado ORM como dapper, para dar ejemplo del uso de las mismas (no aplicado en todos los casos ya que el fin era solo mostrar de que manera lo utilizo).
He agrego distintos tipos de arquitectura: Ejemplo: Arquitectura de Capa de negocio, Clean Arquitecture, Arquitectura en capas, y CQRS (Command Query Responsibility Segregation)
Lo que podemos ver en el proyecto es lo siguiente:
Creación de un Estudiante.
Creacion de un Curso.
Asignación de un curso a un estudiante con una logica de pago de por medio.
Pruebas unitarias para la creacion de estudiantes.
Obtencion de cantidad de cursos y sus respectivos estudiantes.


Me hubiese gustado agregar, pero por falta de tiempo no lo he hecho:

Agregado de pruebas unitarias en metodos POST para preveer posibles bugs y/o fallas.
Obtencion de estudiantes por Identificación UNICA (DNI).
Filtro de Estudiantes con cursos finalizados y/o por realizar.
Filtro para obtener todos los cursos disponibles.
Filtro para futuros cursos disponibles(Con fecha de inicio).
Filtro del Curso al que un estudiante quiere acceder con sus respectivos precios.



 