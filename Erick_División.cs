class Program
{
    static void Main(string[] args)
    {
        //Variables
        double n1=0, n2=0, n3=0;
        //Bienvenida
        Console.WriteLine("Bienvenido a división ingrese los valores solicitados: ");
        //Ingreso de Dividendo
        Console.Write("Ingrese el dividendo(el número que desea dividir): ");
        n1 = double.Parse(Console.ReadLine());
        //Ingreso de Divisor
        Console.Write("Ingrese el divisor(el número por el que desea dividir al anterior): ");
        n2 = double.Parse(Console.ReadLine());
        //Salida
        n3 = n1 / n2;
        Console.Write("El cocientede de ambos números es(resultado): ");
        Console.Write(n3);
    }
}