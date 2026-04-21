internal class Program
{
    private static void Main(string[] args)
    {
        int ang1, ang2, ang3;
        Console.WriteLine("Triangulo");
        Console.WriteLine("Ingrese los angulos del triangulo:");
        ang1 = int.Parse(Console.ReadLine());
        ang2 = int.Parse(Console.ReadLine());
        ang3 = int.Parse(Console.ReadLine());

        if (ang1 == 60 && ang2 == 60 && ang3 == 60)
        {
            Console.WriteLine("Es un triangulo equilatero");
        }
        else if (ang1 == ang2 && ang3 != ang1 || ang1 == ang3 && ang2 != ang1 || ang2 == ang3 && ang1 != ang2)
        {
            Console.WriteLine("El un triangulo isoceles");
        }
        else if (ang1 != ang2 && ang1 != ang3 && ang2 != ang3)
        {
            Console.WriteLine("Es un triangulo escaleno");
        }
    }
}