/*(2.1.5.6) Crea un programa que pida al usuario dos números enteros y diga si (al
menos) uno es par.*/

using System;

public class Enero1E3
{
    public static void Main()
    {
        int n1, n2;
        
        Console.Write("Escribe un número entero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Escribe otro número entero: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        if ( n1 % 2 == 0 || n2 % 2 == 0)
        {
            Console.WriteLine("Al menos uno de los dos números es par.");
        }
        else
        {
            Console.WriteLine("Ninguno de los dos números es par.");
        }
    }
}
