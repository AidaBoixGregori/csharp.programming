/*(2.1.1.1) Crea un programa que pida al usuario un número entero y diga si es par
(pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero:
if (x % 2 == 0) …).*/

using System;

public class D1E1
{
    public static void Main()
    {
        int n;
        
        Console.Write("Escribe un número: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        if (n % 2==0)
            Console.WriteLine("El número es par");
    }
}
