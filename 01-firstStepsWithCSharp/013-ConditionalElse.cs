/* (2.1.4.1) Mejora la solución al ejercicio 2.1.3.1, usando "else". */

using System;

public class D2E2
{
    public static void Main()
    {
        int n1, n2;
        
        Console.Write("Escribe un número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        if (n1 == 0)
        {
            Console.WriteLine("El producto de 0 por cualquier número es 0");
        }
        
        else 
        {
            Console.Write("Escribe otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("El resultado de su producto es: {0}", n1*n2);
        }
    }
}
