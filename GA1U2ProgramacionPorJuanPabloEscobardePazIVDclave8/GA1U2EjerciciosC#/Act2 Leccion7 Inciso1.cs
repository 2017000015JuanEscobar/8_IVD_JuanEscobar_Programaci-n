internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Servicio de Banrural");
        Console.WriteLine("Escriba un numero");
        num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("Servicios de Remesas Familiares");
                break;
            case 2:
                Console.WriteLine("Servicios de Pagos Programados");
                break;
            case 3:
                Console.WriteLine("Servicios de Cuentas y Créditos");
                break;
            case 4:
                Console.WriteLine("Caja Banrural");
                break;
            default:
                Console.WriteLine("Error, numero invalido");
                break;
        }
    }
}
