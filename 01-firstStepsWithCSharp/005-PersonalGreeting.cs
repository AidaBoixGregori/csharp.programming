using System;

public class PersonalGreeting
{
    public static void Main()
    {
        string name;
        Console.Write("What's your name? ");
        name = Console.ReadLine();
        
        Console.WriteLine("Hello, " + name);
    }
}
