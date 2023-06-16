/*
Requerimiento
    El dueño de una veterinaria nos contrató para que desarrollemos una aplicación donde pueda consultar la lista de clientes y sus mascotas.
    * De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. A un cliente se le pueden asociar una o más mascotas.
    * De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación.
        * Los primeros tres datos son obligatorios para dar de alta una mascota
        * Mientras que el último arrancará vacío y se podrá ir agregando vacunas.
        * De las vacunas sólo interesa conocer el nombre.

Consigna: 
    Crear una aplicación de consola.
    Modelar y declarar las clases necesarias para resolver la necesidad del cliente. Hacerlo en un proyecto de biblioteca de clases.
    Las clases deberán tener los métodos necesarios, incluyendo uno que devuelva toda la información del objeto en formato string.

    Instanciar los siguientes objetos:
    Un cliente con un perro sin vacunar.
    Un cliente con un gato con la vacuna "Triple Felina".
    Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
    Mostrar por consola todos los datos de los clientes instanciados y sus mascotas.
*/

using Veterinaria.Utils;

Client client = new Client(
    "Jorge",
    "Sanchez",
    "Avenida Siempre Viva 123");

client.AddPet(new Pet(
    "Perro", 
    "Cholita", 
    DateTime.Now)
);


Client client2 = new Client(
    "Anna",
    "Fernandez",
    "Avenida Siempre Viva 876");

Pet catClient2 = new Pet(
    "Gato",
    "Negro",
    DateTime.Now
);
catClient2.AddVaccine(new Vaccine("Triple Felina"));
client2.AddPet(catClient2);


Client client3 = new Client(
    "Gabriel",
    "Henriquez",
    "Avenida Siempre Viva 111");

Pet catClient3 = new Pet(
    "Gato",
    "Princesa",
    DateTime.Now
);
Pet dogClient3 = new Pet(
    "Perro",
    "Tayson",
    DateTime.Now
);
dogClient3.AddVaccine(new Vaccine("Rabia"));

client3.AddPet(catClient3);
client3.AddPet(dogClient3);

Console.WriteLine(client.ShowInfo());
Console.WriteLine(client2.ShowInfo());
Console.WriteLine(client3.ShowInfo());

