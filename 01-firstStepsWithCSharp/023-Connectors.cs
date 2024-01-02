/*(2.1.5.9) Crea un programa que pida al usuario tres números y muestre cuál es el
mayor de los tres.*/

using System;

public class Enero1E3
{
    public static void Main()
    {
        int n1, n2, n3;
        
        Console.Write("Escribe un número entero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Escribe otro número entero: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Escribe un número entero: ");
        n3 = Convert.ToInt32(Console.ReadLine());
        
        if ( n1 > n2 && n1 > n3)
        {
            Console.WriteLine("El primer número introducido es el mayor de los tres");
        }
        else
        {
            if (n2 > n3)
            {
                Console.WriteLine("El segundo número introducido es el mayor de los tres");
            }
            else
            {
                Console.WriteLine("El tercer número introducido es el mayor de los tres");
            }
        }
    }
}
