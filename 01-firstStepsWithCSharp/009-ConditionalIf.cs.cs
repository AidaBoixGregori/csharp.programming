/*(2.1.1.3) Crea un programa que pida al usuario dos números enteros y diga si el
primero es múltiplo del segundo (pista: igual que en el ejercicio 2.1.1.1, habrá que
ver si el resto de la división es cero: a % b == 0).*/

using System;

public class D1E3
{
    public static void Main()
    {
        int a, b;
        
        Console.Write("Escribe un número: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escribe otro número: ");
        b = Convert.ToInt32(Console.ReadLine());
        
        if (a % b == 0)
            Console.WriteLine("El primero es múltiplo del segundo");
    }
}
