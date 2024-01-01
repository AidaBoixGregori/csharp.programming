/*(2.1.5.4) Crea un programa que pida al usuario un número entero y responda si no
es múltiplo de 2 ni de 3.*/

using System;

public class Enero1E1
{
    public static void Main()
    {
        int n1;
        
        Console.Write("Escribe un número entero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        if (n1 % 2 != 0 || n1 % 3 != 0)
        {
            Console.WriteLine("El número no es múltiplo ni de 2 ni de 3.");
        }
        else
        {
            Console.WriteLine("El número es múltiplo de 2 o de 3 o de ambos.");
        }
    }
}
