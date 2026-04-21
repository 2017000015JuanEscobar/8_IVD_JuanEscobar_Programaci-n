internal class Program
{
    private static void Main(string[] args)
    {
        int dia;
        Console.WriteLine("Ingrese un numero del 1 al 7");
        dia = int.Parse(Console.ReadLine());
        switch (dia)
        {
            case 1:
                Console.WriteLine("Hoy es Lunes");
                break;
            case 2:
                Console.WriteLine("Hoy es Martes");
                break;
            case 3:
                Console.WriteLine("Hoy es Miercoles");
                break;
            case 4:
                Console.WriteLine("Hoy es Jueves");
                break;
            case 5:
                Console.WriteLine("Hoy es Viernes");
                break;
            case 6:
                Console.WriteLine("Hoy es Sabado");
                break;
            case 7:
                Console.WriteLine("Hoy es Domingo");
                break;
            default:
                Console.WriteLine("Ingrese un numero valido");
                break;
        }
    }
}