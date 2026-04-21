internal class Program
{
    private static void Main(string[] args)
    {
        int notas;
        Console.WriteLine("Calificaciones");
        Console.WriteLine("Escriba su nota:");
        notas = int.Parse(Console.ReadLine());

        if (notas >= 0 && notas <= 20)
        {
            Console.WriteLine("Su nota es deficiente");
        }
        else if (notas >= 21 && notas <= 40)
        {
            Console.WriteLine("Su nota es regular");
        }
        else if (notas >= 41 && notas <= 60)
        {
            Console.WriteLine("Su nota esta bien");
        }
        else if (notas >= 61 && notas <= 80)
        {
            Console.WriteLine("Su nota esta muy bien");
        }
        else if (notas >= 81 && notas <= 100)
        {
            Console.WriteLine("Su nota es excelente");
        }
    }
}