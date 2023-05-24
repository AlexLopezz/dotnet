namespace Variables
{
    internal class Excercise
    { 
        private class Coche
        {
            public int Puertas{ get; set; }
            public int Ruedas { get; set; }
            public String Marca { get; set; }
            public String ITV { get; set; }

            public virtual string? ToString()
            {
                return $"Informacion del coche:\nPuertas: {Puertas}\nRuedas: {Ruedas}\nMarca: {Marca}\nITV: {ITV}";
            }
        }
        public class Mesa
        {
            public double Peso { get; set; }
            public double Largo { get; set; }
            public String Material { get; set; }
            public String Color { get; set; }

            public virtual string? ToString()
            {
                return $"Informacion de la mesa:\nPeso: {Peso}\nLargo: {Largo}\nMaterial: {Material}\nColor: {Color}";
            }
        }

        public static void Excercise1()
        {
            /* Ejercicio 1 Variables:
            * Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para 
            * cada dato y otra para el mensaje.Ej: nombre, apellido, edad, sabe programar, etc.
            */
            String nombre, apellido;
            double edad;
            bool sabeProgramar;
            Console.Write("> Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("> Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.Write("> Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("> ¿Ud. sabe programar?");
            sabeProgramar = Console.ReadLine().Equals("si");

            Console.WriteLine($"Datos de la persona\nNombre: {nombre}\nApellido: {apellido}\nEdad: {edad}\nSabe programar? {sabeProgramar}");

        }
        public static void Excercise2()
        {
            /*
             * Ejercicio 2
             * Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
             *
             * Coche: puertas, ruedas, marca, ITV vigente
             * Mesa: peso, largo, material, color
             * Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es
             * almacenar los datos en los tipos más adecuados.
             */

            Coche coche = new Coche { 
                Puertas = 4,
                Ruedas = 4,
                Marca = "Wolksvagen",
                ITV = "23432AE"
            };

            Mesa mesa = new Mesa
            {
                Peso = 12.6,
                Largo = 30.2,
                Material = "Madera",
                Color = "Marron"
            };

            Console.WriteLine(coche);
            Console.WriteLine(mesa);
        }
        public static void Excercise3()
        {
            /*
             * Ejercicio 3 Operadores 
             * Determina los operadores para verificar las siguientes condiciones:
             *  Un número es mayor o igual a 18
             *  Un char es ‘a’
             *  Se cumplen dos conciones a la vez (ambas verdaderas)
             *  Se cumple una de dos condiciones a la vez (una true y otra false)
             */

            int number = 24;
            Console.WriteLine($"{number} es mayor que 18? {number > 18}");
            char character = 'a';
            Console.WriteLine($"{character} es igual a 'a'? {character.Equals('a')}");

            Console.WriteLine($"{number} es mayor a 18 pero menor a 25? {number > 18 && number < 25}");
            Console.WriteLine($"{number} es mayor a 18 o la el caracter es igual a 'b'? {number > 18 || character.Equals('b')}");
        }
    }
}
