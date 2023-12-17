/* (2.1.4.2) Mejora la solución al ejercicio 2.1.3.2, usando "else". */

using System;

public class D2E3
{
    public static void Main()
    {
        int n1, n2;
        
        Console.Write("Escribe un número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escribe otro número: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        if(n2!=0)
        {
            Console.WriteLine("El resultado de la división es: {0}", n1/n2);
        }
        
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero");
        }
    }
}
