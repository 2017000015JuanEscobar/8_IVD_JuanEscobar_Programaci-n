using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        double cali1, cali2, cali3, cali4, cali5, promedio;
        Console.WriteLine("Ingresa sus calificaciones del 0 al 100:");
        Console.Write("Ingresa la calificación 1:");
        cali1 = Convert.ToDouble(Console.ReadLine());
        if (cali1 < 0)
        {
            Console.WriteLine("Número incorrecto. Tiene que ser del 1 al 100");
        }
        else if (cali1 > 100)
        {
            Console.WriteLine("Número incorrecto. Tiene que ser del 1 al 100");
        }
        else
        {
            Console.Write("Ingresa la calificación 2:");
            cali2 = Convert.ToDouble(Console.ReadLine());
            if (cali2 < 0)
            {
                Console.WriteLine("Número incorrecto. Tiene que ser del 1 al 100");
            }
            else if (cali2 > 100)
            {
                Console.WriteLine("Número incorrecto. Tiene que ser del 1 al 100");
            }
            else
            {
                Console.Write("Ingresa la calificación 3");
                cali3 = Convert.ToDouble(Console.ReadLine());
                if (cali3 < 0)
                {
                    Console.WriteLine("Número incorrecto. Tiene que ser del 1 al 100");
                }
                else if (cali3 > 100)
                {
                    Console.WriteLine("Número incorrecto. Tiene que ser del 1 al 100");
                }
                else
                {
                    Console.Write("Ingresa la calificación 4");
                    cali4 = Convert.ToDouble(Console.ReadLine());
                    if (cali4 < 0)
                    {
                        Console.WriteLine("Número incorrecto. Tiene que ser del 1 al 100");
                    }
                    else if (cali4 > 100)
                    {
                        Console.WriteLine("Número incorrecto. Tiene que ser del 1 al 100");
                    }
                    else
                    {
                        Console.Write("Ingresa la calificación 5");
                        cali5 = Convert.ToDouble(Console.ReadLine());
                        if (cali5 < 0)
                        {
                            Console.WriteLine("Número incorrecto. Tiene que ser del 1 al 100");
                        }
                        else if (cali5 > 100)
                        {
                            Console.WriteLine("Número incorrecto. Tiene que ser del 1 al 100");
                        }
                        else
                        {
                            promedio = (cali1 + cali2 + cali3 + cali4 + cali5) / 5;
                            Console.WriteLine("Promedio: " + promedio);
                            if (promedio >= 60)
                            {
                                Console.WriteLine("Resultado: APROBADO");
                            }
                            else
                            {
                                Console.WriteLine("Resultado: REPROBADO");
                            }
                        }
                    }
                }
            }
        }
    }
}
