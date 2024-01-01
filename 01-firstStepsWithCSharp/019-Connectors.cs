/*(2.1.5.5) Crea un programa que pida al usuario dos números enteros y diga si
ambos son pares.*/

using System;

public class Enero1E2
{
    public static void Main()
    {
        int n1, n2;
        
        Console.Write("Escribe un número entero: ");
        n1=Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Escribe otro número entero: ");
        n2=Convert.ToInt32(Console.ReadLine());
        
        if (n1 % 2 == 0 && n2 % 2 == 0)
        {
            Console.WriteLine("Ambos números introducidos son pares");
        }
        
        else 
        {
            if (n1 % 2 == 0 && n2 % 2 != 0)
            {
                Console.WriteLine("El primer número introducido es par pero no el segundo.");
            }
            if (n1 % 2 != 0 && n2 % 2 == 0)
            {
                Console.WriteLine("El segundo número introducido es par pero no el primero.");
            }
            if (n1 % 2 != 0 && n2 % 2 != 0)
            {
                Console.WriteLine("Ninguno de los números introducidos es par.");
            }
        }
    }
}
