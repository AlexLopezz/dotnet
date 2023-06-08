// Para tomar un dato ingresado por el usuario se usa el método ReadLine de la clase Console.
Console.Write("Ingrese una fruta: ");
string fruta = Console.ReadLine();
Console.WriteLine("Se ingreso la fruta {0}", fruta);

/* El método ReadLine devuelve siempre un string. 
 * Si trabajamos con números tendremos que convertirlos a un tipo numérico.
 */

Console.Write("Ingrese un precio: ");
string precioIngresado = Console.ReadLine();

decimal precioSinIva = decimal.Parse(precioIngresado);

decimal precioFinal = precioSinIva + precioSinIva * 0.21M;

Console.WriteLine("Se ingreso el precio {0:C2}, con IVA incluido suma ${1:N2}", precioSinIva, precioFinal);


/* Console.ReadKey: Este metodo espera a que el usuario presione una tecla o combinación de teclas y retorna un objeto de tipo ConsoleKeyInfo
 * Propiedades importantes que contiene el objeto ConsoleKeyInfo:
 
   Key: retorna un objeto de tipo ConsoleKey que representa a la tecla presionada
   KeyChar: retorna como tipo char el caracter relacionado a la tecla presionada (siempre que exista, de lo contrario retorna espacio vacío).
   Modifiers: retorna un objeto de tipo ConsoleModifiers que representa a los modificadores que se hayan aplicado en la combinación de teclas. 
   Ejemplos de modificadores son SHIFT, CTRL, ALT, etc.
 */
Console.WriteLine("Presione una tecla o combinación de teclas:");

ConsoleKeyInfo teclaPresionada = Console.ReadKey(true); // Si al método ReadKey le pasamos como argumento true interceptará el caracter presionado y no lo mostará.

ConsoleKey tecla = teclaPresionada.Key; //Obtenemos la letra presionada por el usuario
char caracter = teclaPresionada.KeyChar; //Obtenemos el caracter.
ConsoleModifiers modificadores = teclaPresionada.Modifiers; //Obtenemos los modificadores que ingreso el usuario.

Console.WriteLine("Tecla: {0}. Caracter: {1}. Modificadores: {2}", tecla, caracter, modificadores);


// Tambien podemos manipular las propiedades por defecto de la consola.

Console.Clear(); // Limpiamos todo el contenido que hay en la consola.
Console.Title = "Mi consola"; // Cambiamos el titulo por defecto de la consola.

/* Podemos cambiar el color del texto que se muestra en consola
 * Se tiene que asignar un nuevo valor a la propiedad ForegroundColor de la clase Console
 * Para ayudarnos existe el enumerado ConsoleColor que contiene estos números representados por nombres descriptivos.
 */
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Hola mundo, con color ROJO!");

/* Podemos tambien cambiar el color del fondo del texto que se muestra en consola
 * Se tiene que asignar un nuevo valor a la propiedad BackgroundColor de la clase Console
 * También usaremos el enumerado ConsoleColor para obtener el código del color
 */
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("Hola mundo, con fondo AZUL!");

// Podemos emitir un sonido a traves de la consola con el método Beep de la clase Console.
Console.Beep(); // Sonido por defecto.

//Opcionalmente, se le puede pasar como argumentos la frecuencia del sonido en hertz y la duración en milisegundos.
Console.Beep(1000, 1500); // Sonido de 1000hz durante 1 segundo y medio. 

//El método Beep no funciona en todas las plataformas.