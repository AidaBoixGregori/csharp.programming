/*(2.1.1.2) Crea un programa que pida al usuario dos números enteros y diga cuál es
el mayor de ellos.*/

using System;

public class D1E2
{
    public static void Main()
    {
        int n1, n2;
        
        Console.Write("Escribe un número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escribe otro número: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        if (n1 > n2)
            Console.WriteLine("El primer número es mayor");
            
        if (n2 > n1)
            Console.WriteLine("El segundo número es mayor");
    }
}
