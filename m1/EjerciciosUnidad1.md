<h5>Tarea 2) Enunciar el problema en base a la información relevada</h5>
<ins>enunciar problema:</ins> ordenar conjunto de requerimientos en un enunciado claro y conciso sin redundancias ni perdida de información.

El Instituto Universitario Superior (IUS) desea realizar un sistema para administrar las asignaciones de sus cursos.  La información relevada se encuentra a continuación:
Para comenzar, se requiere registrar los datos de contacto tanto de instructores como de alumnos para informar a cada uno el comienzo de cada curso.
Para que un curso se habilite, se deben inscribir a él por lo menos tres alumnos. 
Una vez dado de alta, el mismo se deberá agregar en un calendario para asignarle su aula correspondiente. Por otro lado, se deberá permitir reprogramar el mismo en el calendario con mas de un turno. Estos pueden ser: mañana, tarde o noche.

Sobre los alumnos, deberán estar asignados por lo menos a un curso para mantener su condición de regular.

Por último, el Instituto organizará los materiales necesarios en cada aula (escritorios, sillas, pizarrones y computadoras) en base a la cantidad de inscriptos por curso.

Enumeración de funcionalidades a resolver:
1. Se requiere registrar los datos de contacto tanto de instructores como de alumnos.
2. Un curso se considero habilitado cuando tiene 3 o más alumnos inscriptos.
3. Los cursos dados de alta se deberán agregar a un calendario y asignarle su aula correspondiente.
4. Se deberá permitir reprogramar el horario de un curso en el calendario con mas de un turno. Estos pueden ser: mañana, tarde o noche.
5. Los alumnos deberán estar asignados por lo menos a un curso para mantener su condición de regular.
6. Notificar tanto a los instructores como a los alumnos, el comienzo de cursada.
7. Se pretende llevar un control de la cantidad de inscriptos por curso así el Instituto puede organizar los materiales necesarios en cada aula (escritorios, sillas, pizarrones y computadoras).

<h5>Tarea 3) Determinar el contexto del problema. Definir si el contexto coincide con el dominio de solución</h5>
<ins>contexto de un problema:</ins> es el alcance que tiene el mismo. Para determinarlo se debe tener en cuenta en base al problema enunciado cuales son los elementos que pertenecerán al conjunto de la solución en base a lo que se desea resolver (aún sin conocer todas las abstracciones).

Lista inicial delimitando el contexto:
1. Registrar los datos de contacto.
2. Inscripción y gestión de alumnos.
3. Asignación de aulas.
4. Reprogramación de horarios.
5. Notificaciones.
6. Organización de materiales.

##### Tarea 4) Crear lista de objetos candidatos

1. Instituto
2. Aula
3. Instructor
4. Alumnos
5. Curso
6. Calendario
7. Materiales necesarios
8. Escritorios
9. Sillas
10. Pizarrones
11. Computadoras
12. Datos de contacto

##### Tarea 5) Analizar los objetos candidatos

| Objeto candidato | Estado | Motivo |
|---------|---------|---------|
| Instituto  | Activo  | Dentro del alcance|
| Aula  | Activo  | Dentro del alcance|
| Instructor  | Activo  | Dentro del alcance|
| Alumnos  | Activo  | Dentro del alcance|
| Curso  | Activo  | Dentro del alcance|
| Calendario  | Activo  | Dentro del alcance|
| Materiales necesarios  | Descartado  | Sinónimo de dominio para escritorios, sillas, pizarrones y computadoras|
| Escritorios  | Activo  | Dentro del alcance|
| Sillas  | Activo  | Dentro del alcance|
| Pizarrones  | Activo  | Dentro del alcance|
| Computadoras  | Activo  | Dentro del alcance|
| Datos de contacto  | Descartado  | Atributo de cada instructor/alumno |
