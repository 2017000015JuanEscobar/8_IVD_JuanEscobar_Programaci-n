internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Introduzca un numero");
        num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("El numero es negativo");
        }
        else
        {
            Console.WriteLine("El numero es positivo");
        }
    }
}