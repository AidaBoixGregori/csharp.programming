/*(2.1.2.1) Crea un programa que pida al usuario un número entero. Si es múltiplo
de 10, informará al usuario y pedirá un segundo número, para decir a
continuación si este segundo número también es múltiplo de 10.*/

using System;

public class D1E4
{
    public static void Main()
    {
        int n1, n2;
        
        Console.Write("Escribe un número entero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        if (n1 % 10 == 0)
        {
            Console.WriteLine("El número es múltiplo de 10");
            Console.Write("Prueba con otro: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            if (n2 % 10 == 0)
                Console.WriteLine("Este también es múltiplo de 10!");
        }
    }
}
