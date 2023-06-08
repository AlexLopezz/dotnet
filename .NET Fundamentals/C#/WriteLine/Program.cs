string placaDeVideo = "Nvidia RTX 3080";
decimal precioPlacaVideo = 344663.1236M;
string procesador = "Ryzen 7 5800x";
decimal precioProcesador = 63595M;

/* Aplicando formato a cadena de textos.
 * {1} indica que allí se deberá insertar la representación en texto de la variable que está en la segunda posición.
 * Se puede definir el ancho del campo agregando una coma y un valor.
 * Si el valor es positivo la cadena se alinea a la derecha: {1,10} aplica al valor de la variable en la segunda posición un ancho de columna de 10 caracteres y alineación a la derecha.
 * si es negativo se alinea a la izquierda: {0,-20} aplica al valor de la variable en la primera posición un ancho de columna de 20 caracteres y alineación a la izquierda.
 * 
 * 
 * {1,10:N2} aplica al valor del marcador el formato :N2 que representa un número con separadores de dígitos y hasta 2 decimales.
 * 
 */
Console.WriteLine("{0,-20} {1,20}", "Producto", "Precio");
Console.WriteLine("{0,-20} {1,10:N2}", placaDeVideo, precioPlacaVideo);
Console.WriteLine("{0,-20} {1,10:N2}", procesador, precioProcesador);



decimal precioSinIva = 12M;
decimal precioFinal = 14M;

/* Aplicando un formato numerico standar: :C2 es el formato que se aplica sobre el valor en el marcador.
 * C se utiliza para dar formato de monedas.
 * 2 indica que mostrara dos digitos despues de la coma.
 */
Console.WriteLine("Se ingreso el precio {0:C2}, con IVA incluido suma ${1:C2}", precioSinIva, precioFinal);

/* Aplicando un formato numerico personalizado: 
 * El signo $ es un literal fijo.
 * # representa un digito(siempre que exista) sino, muestra un string vacio.
 * . es el punto decimal.
 * 00 indica hasta dos decimales, si no encuentra decimales, entonces rellena con 0.
 */ 
Console.WriteLine("Se ingreso el precio {0:$#.00}, con IVA incluido suma ${1:$#.00}", precioSinIva, precioFinal);


/* Secuencias de escapes: Dentro de los string se puede incluir secuencias de escape que se utilizan para representar caracteres especiales.
 * Los caracteres de escape vienen acompañados con el prefijo \ (contra barra).
   
   \'	Comilla simple
   \"	Comilla doble
   \\	Contra barra
   \n	Nueva línea / Salto de línea
   \t	Tabulación horizontal
 */
Console.WriteLine("Texto con salto de línea.\n");
Console.WriteLine("\tTexto tabulado horizontalmente.");
Console.WriteLine("Pongo \"comillas dobles\" a mi texto y también \'comillas simples\'.");
Console.WriteLine("Para trabajar con caracteres especiales hay que usar \\.");


/* Existe una forma de escapar todos los caracteres especiales de un texto con el prefijo @
 * También sirve para trabajar con texto multi-línea
 */
Console.WriteLine(@"La ruta al archivo es: C:\\usuario\documentos\texto.txt");
Console.WriteLine(@"
Un texto
en más de una línea
es posible con C#
anteponiendo @ al literal de string.
");