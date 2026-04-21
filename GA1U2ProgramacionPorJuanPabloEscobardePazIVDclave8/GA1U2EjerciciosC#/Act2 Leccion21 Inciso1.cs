internal class Program
{
    private static void Main(string[] args)
    {
        int bdv;
        Console.WriteLine("Buzon de vos de: Bodegas Martines");
        Console.WriteLine("Ingrese uno los siguientes numeros si quiere comunicarse con:");
        Console.WriteLine("1: Ventas");
        Console.WriteLine("2: Compras");
        Console.WriteLine("3: Direccion");
        Console.WriteLine("4: Inventario");
        bdv = int.Parse(Console.ReadLine());

        switch (bdv)
        {
            case 1:
                Console.WriteLine("Bienvenido al departamento de: Ventas");
                Console.WriteLine("Correo del responsable: cl_Martines@gmail.com");
                break;
            case 2:
                Console.WriteLine("Bienvenido al departamento de: Compras");
                Console.WriteLine("Correo del responsable: v_fatima@gmail.com");
                break;
            case 3:
                Console.WriteLine("Bienvenido al departamento de: Direccion");
                Console.WriteLine("Correo del responsable: pjose2006@gmail.com");
                break;
            case 4:
                Console.WriteLine("Bienvenido al departamento de: Inventario");
                Console.WriteLine("Correo del responsable: rramirez08@gmail.com");
                break;
            default:
                Console.WriteLine("Correo del responsable: d_ramirez16@gmail.com");
                break;

        }
    }
}