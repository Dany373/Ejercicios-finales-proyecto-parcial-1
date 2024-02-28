// Concatenación de cadenas


using System.Net.NetworkInformation;

string saludo = "Hola";
string nombre = "Dany";
string mensaje = saludo + ", " + nombre + "!";
Console.WriteLine(mensaje);


//Método Concat
   string saludo = "Hola";
string nombre = "Dany";
string mensaje = String.Concat(saludo, ", ", nombre, "!");


//Interpolacion de cadenas 
string saludo = "Hola";
string nombre = "Dany";
string mensaje = $"{saludo}, {nombre}!";



//Método String.Format
string saludo = "Hola";
string nombre = "Dany";
string mensaje = String.Format("{0}, {1}!", saludo, nombre);
Console.WriteLine(mensaje);


// • Métodos:

//1. Length
string mensaje = "Hola";
int longitud = mensaje.Length; //(longitud sería 4).
Console.WriteLine("La longitud es: " + longitud);




//2. ToUpper()
string mensaje = "hola";
string mayusculas = mensaje.ToUpper(); //(mayusculas sería "HOLA").
Console.WriteLine(mayusculas);


//3. ToLower()
string mensaje = "HOLA"; 
string minusculas = mensaje.ToLower(); //(minusculas sería "hola").
Console.WriteLine(minusculas);

//4. IndexOf()
string mensaje = "Hola mundo";
int indice = mensaje.IndexOf("m"); //(índice sería 5).
Console.WriteLine("el indice es:" + indice);


//5. LastIndex()
string mensaje = "Hola mundo";
int ultimoIndice = mensaje.LastIndexOf("o"); //(últimoIndice sería 9, ya que la última "o" está en la posición 9).
Console.WriteLine("El ultimo indice es: " + ultimoIndice);


//6. Substring()

//Ejemplo 1: 
string mensaje = "Hola mundo";
string subcadena = mensaje.Substring(5); //(subcadena sería "mundo", porque comienza en el índice 5).
Console.WriteLine(subcadena);

//Ejemplo 2:
string mensaje = "Hola mundo";
string subcadena = mensaje.Substring(0, 4); //(subcadena sería "Hola", porque comienza en el índice 0 y se obtienen 4 caracteres).
Console.WriteLine(subcadena);




//7. Replace()

string mensaje = "Hola mundo";
string nuevoMensaje = mensaje.Replace("mundo", "amigo"); //(nuevoMensaje sería "Hola amigo", porque "mundo" se reemplaza por "amigo").
Console.WriteLine(nuevoMensaje);


//8. Trim()

string mensaje = " Hola mundo ";
string limpio = mensaje.Trim(); //(limpio sería "Hola mundo", sin espacios al principio ni al final).
Console.WriteLine(limpio);


//9. . StartsWith()

string mensaje = "Hola mundo";
bool empiezaConHola = mensaje.StartsWith("Hola"); //(empiezaConHola sería true, porque "Hola mundo" comienza con "Hola").
Console.WriteLine(empiezaConHola);


//10. EndsWith()

string mensaje = "Hola mundo";
bool terminaConMundo = mensaje.EndsWith("mundo"); //(terminaConMundo sería true, porque "Hola mundo" termina con "mundo").
Console.WriteLine(terminaConMundo);


//COMPARACION DE CADENAS 
string cadena1 = "Hola";
string cadena2 = "Hola";

bool sonIguales = (cadena1 == cadena2); // true
bool sonDiferentes = (cadena1 != cadena2); // false
int resultadoComparacion = cadena1.CompareTo(cadena2); // 0 (son iguales)

Console.WriteLine(sonIguales);
Console.WriteLine(sonDiferentes);
Console.WriteLine(resultadoComparacion);    






//CONCATENACION DE CADENAS
string cadena1 = "Hola";
string cadena2 = "mundo";
string resultado1 = cadena1 + cadena2; // 
string resultado2 = String.Concat(cadena1, cadena2); 

Console.WriteLine(resultado1);
Console.WriteLine(resultado2);


//FORMATEO DE CADENAS 

string nombre = "Juan";
int edad = 30;

string mensaje1 = String.Format("Hola, {0}, tienes {1} años.", nombre, edad);
string mensaje2 = $"Hola, {nombre}, tienes {edad} años.";

