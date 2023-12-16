/*(2.1.3.1) Crea un programa que multiplique dos números enteros de la siguiente
forma: pedirá al usuario un primer número entero. Si el número que se que teclee
es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0". Si se ha
tecleado un número distinto de cero, se pedirá al usuario un segundo número y se
mostrará el producto de ambos.*/

using System;

public class D1E5
{
    public static void Main()
    {
        int n1, n2;
        
        Console.Write("Escribe un número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        if (n1 == 0)
        {
            Console.WriteLine("El número tecleado es cero");
        }
        
        if (n1 != 0)
        {
            Console.Write("Escribe otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("El resultado de su producto es: {0}", n1*n2);
        }
    }
}
