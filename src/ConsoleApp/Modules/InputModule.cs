using System;

public static class InputModule
{
    public static string GetInput()
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine();
        return input;
    }
}
