internal class Program
{
    private static void Main(string[] args)
    {
        int dia, mes;
        Console.WriteLine("Estaciones del año");
        Console.WriteLine("Escriba un dia");
        dia = int.Parse(Console.ReadLine());
        Console.WriteLine("Escriba un mes");
        mes = int.Parse(Console.ReadLine());

        if (dia <= 21 && mes >= 3 && mes <= 6)
        {
            Console.WriteLine("Es Primavera");
        }
        else if (dia <= 22 && mes >= 6 && mes <= 9)
        {
            Console.WriteLine("Es Verano");
        }
        else if (dia <= 23 && mes >= 9 && mes <= 12)
        {
            Console.WriteLine("Es Otoño");
        }
        else if (dia <= 22 && mes >= 12 && mes <= 2)
        {
            Console.WriteLine("Es Invierno");
        }
    }
}