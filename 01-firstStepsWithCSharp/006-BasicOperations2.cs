using System;

public class BasicOperations2
{
    public static void Main()
    {
        
        Console.Write("Enter number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        
        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        
        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 * 1.0 / num2));
        
        Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
    }
}
