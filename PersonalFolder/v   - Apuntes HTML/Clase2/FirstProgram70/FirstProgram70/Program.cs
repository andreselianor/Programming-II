// See https://aka.ms/new-console-template for more information
using FirstProgram70;

Console.WriteLine("Hello, World!");
Console.WriteLine("Prueba de programa 1");
Console.WriteLine("Introduzca dos numeros:");
int number1 = Int32.Parse(Console.ReadLine());
int number2 = Int32.Parse(Console.ReadLine());

int result1 = Functions.SumNumbers(number1, number2);
int result2 = Functions.GetMajor(number1, number2);

Console.WriteLine("El resultado de sumar los numeros es: " + result1 + "\nEl número mayor es: " + result2);