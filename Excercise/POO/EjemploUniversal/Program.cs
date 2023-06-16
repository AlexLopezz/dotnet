/*
La clase Estudiante:

    *Tendrá un constructor estático que inicializará el atributo estático random.
    *Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
    *El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
    *El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
    *El método privado CalcularPromedio retornará el promedio de las dos notas.
    *El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
    *El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:

    *Nombre, apellido y legajo.
    *Nota del primer y segundo parcial.
    *Promedio.
    *Nota final. 
        *Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
    
    En el main: 
    *Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
    *Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
    *Mostrar los datos de todos los alumnos.
*/

using EjemploUniversal.Utils;

//Inicializamos las instancias de Student: 
Student student = new Student(
    "Alex",
    "Lopez",
    "654763");
Student student2 = new Student(
    "Gervasia",
    "Nuñez",
    "624763");
Student student3 = new Student(
    "Anibal",
    "Gomez",
    "651263");

//Alumnos aprobados.
student.FirstExam = 6;
student.SecondExam = 6;
student2.FirstExam = 9;
student2.SecondExam = 8;

//Alumno desaprobado.
student3.FirstExam = 3;
student3.SecondExam = 4;

//Mostramos la info correspondiente.
Console.WriteLine(student.ShowInfo());
Console.WriteLine(student2.ShowInfo());
Console.WriteLine(student3.ShowInfo());