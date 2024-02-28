

//CALCULAR FACTORIAL O RAIZ CUADRADA

int numero;
Console.WriteLine("Introduzca un número entero positivo: ");
numero = int.Parse(Console.ReadLine());
int opcion;
do
{
    Console.WriteLine("\nElija una opción:");
    Console.WriteLine("1. Calcular el factorial del número");
    Console.WriteLine("2. Calcular la raíz cuadrada del número");
    Console.WriteLine("3. Salir del programa");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("El factorial de {0} es {1}", numero, CalcularFactorial(numero));
            break;
        case 2:
            Console.WriteLine("La raíz cuadrada de {0} es {1}", numero, Math.Sqrt(numero));
            break;
        case 3:
            Console.WriteLine("¡Hasta luego!");
            break;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }
} while (opcion != 3);
    

    static int CalcularFactorial(int numero)
{
    if (numero == 0 || numero == 1)
    {
        return 1;
    }
    else
    {
        return numero * CalcularFactorial(numero - 1);
    }
}



//NUMERO Y OPERADOR 


Console.WriteLine("Introduzca el primer número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca el segundo número: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca el operador (+, -, *, /): ");
string operador = Console.ReadLine();

if (!ValidarOperador(operador))
{
    Console.WriteLine("Operador no válido. Intente de nuevo.");
    return;
}

int resultado = 0;
switch (operador)
{
    case "+":
        resultado = num1 + num2;
        break;
    case "-":
        resultado = num1 - num2;
        break;
    case "*":
        resultado = num1 * num2;
        break;
    case "/":
        if (num2 == 0)
        {
            Console.WriteLine("No se puede dividir por 0. Intente de nuevo.");
            return;
        }
        resultado = num1 / num2;
        break;
}

Console.WriteLine("El resultado de la operación {0} {1} {2} es {3}", num1, operador, num2, resultado);
    

    static bool ValidarOperador(string operador)
{
    return operador == "+" || operador == "-" || operador == "*" || operador == "/";
}



//TABLA DE MULTIPLICAR DE UN NUMERO 

Console.WriteLine("Introduzca un número: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Tabla de multiplicar del {0}", num);
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
}




//ADIVINAR NUMERO SECRETO 

// Generar un número secreto aleatorio
Random random = new Random();
int numeroSecreto = random.Next(1, 101);

Console.WriteLine("Introduzca un número entre 1 y 100: ");
int numeroUsuario = int.Parse(Console.ReadLine());

while (numeroUsuario != numeroSecreto)
{
   
    if (numeroUsuario > numeroSecreto)
    {
        Console.WriteLine("El número secreto es menor que {0}", numeroUsuario);
    }
    else
    {
        Console.WriteLine("El número secreto es mayor que {0}", numeroUsuario);
    }

    Console.WriteLine("Introduzca otro número: ");
    numeroUsuario = int.Parse(Console.ReadLine());
}

Console.WriteLine("¡Felicidades! Has adivinado el número secreto: {0}", numeroSecreto);
    