/*(2.1.5.3) Crea un programa que pida al usuario un número entero y responda si es
múltiplo de 2 pero no de 3.*/

using System;

public class D3E2
{
    public static void Main()
    {
        int n1;
        
        Console.Write("Escribe un número entero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        if (n1 % 2 == 0 && n1 % 3 != 0)
        {
            Console.WriteLine("El número es múltiplo de 2 pero no de 3");
        }
        else
            Console.WriteLine("El número no es múltiplo de 2 pero no de 3");
    }
}
