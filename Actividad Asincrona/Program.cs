using System;

class Datos
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un numero entero porfavor: ");
        int E = Convert.ToInt32(Console.ReadLine());

        for (int indice = 0; indice < E; indice++)
        {
            for (int cr7 = 0; cr7 <= indice; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}