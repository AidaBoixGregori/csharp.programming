/*(2.1.3.2) Crea un programa que pida al usuario dos números enteros. Si el
segundo no es cero, mostrará el resultado de dividir el primero entre el segundo.
Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir
entre cero".*/

using System;

public class D2E1
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
        
        if(n2==0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero");
        }
    }
}
