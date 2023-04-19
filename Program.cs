using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Application Starting. Welcome.");

        Tutorial tutorial = new Tutorial();
        tutorial.Introduction(); // Call the static Introduction method directly on the Tutorial class
    }
}
