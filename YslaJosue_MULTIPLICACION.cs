namespace CalculadoraGrupal
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Multiplicación */

            /* Declaración de variables */
            int n1 = 0;
            int n2 = 0;
            int mul = 0;

            /* Entrada de datos */
            Console.Write("Ingrese dos números para multiplicar: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            /* Proceso */
            mul = n1 * n2;

            /* Salida */
            Console.WriteLine("El producto de los números es " + mul); 
        }
    }
}