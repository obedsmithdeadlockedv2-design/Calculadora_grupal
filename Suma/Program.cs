using System;
class Program
{
    static void Main()
{
    Console.Write("Ingrese el primer número: ");
    int a = int.Parse(Console.Readline());
    Console.Write ("Ingrese el segundo número: ");
    int b = int.Parse(Console.Readline());
    int suma = a+b;
    Console.WriteLine("La suna es: " + suma);
}
}
