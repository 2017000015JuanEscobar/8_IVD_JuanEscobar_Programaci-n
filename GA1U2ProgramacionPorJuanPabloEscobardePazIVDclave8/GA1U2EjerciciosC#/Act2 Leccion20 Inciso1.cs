internal class Program
{
    private static void Main(string[] args)
    {
        string c;
        Console.WriteLine("Ingrese su contraseña:");
        c = Console.ReadLine();

        if (c == "Password123")
        {
            Console.WriteLine("Bienvenido a su cuenta");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta, acceso denegado");
        }
    }
}