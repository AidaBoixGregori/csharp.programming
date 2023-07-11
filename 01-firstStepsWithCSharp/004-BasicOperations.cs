using System;

public class BasicOperations
{
    public static void Main()
    {
        int num1 = 2;
        int num2 = 5;
        
        Console.Write(num1 + " + " + num2 + " = ");
        Console.WriteLine(num1 + num2);
        
        Console.Write(num1 + " - " + num2 + " = ");
        Console.WriteLine(num1 - num2);
        
        Console.Write(num1 + " * " + num2 + " = ");
        Console.WriteLine(num1 * num2);
        
        Console.Write(num1 + " / " + num2 + " = ");
        Console.WriteLine(num1 * 1.0 / num2);
        
        Console.Write(num1 + " % " + num2 + " = " + (num1 % num2));
    }
}
