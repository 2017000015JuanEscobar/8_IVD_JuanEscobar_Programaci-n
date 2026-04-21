internal class Program
{
    private static void Main(string[] args)
    {
        int d;
        Console.WriteLine("Ingrese un dia de la semana:");
        d = int.Parse(Console.ReadLine());

        if (d == 6 || d == 7)
        {
            Console.WriteLine("Es Fin de Semana");
        }
        else
        {
            Console.WriteLine("Es Entre Semana");
        }
    }
}