internal class Program
{
    private static void Main(string[] args)
    {
        int nota;
        Console.WriteLine("Ingrese su calificacion:");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 70)
        {
            Console.WriteLine("Usted a Aprobado");
        }
        else
        {
            Console.WriteLine("Usted a Reprobado");
        }
    }
}