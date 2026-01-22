using System;
class Program
{
    static void Main()
    {
        string input = InputModule.GetInput();

        int vowelCount = ProcessingModule.CountRussianVowels(input);

        Console.WriteLine($"Количество гласных букв: {vowelCount}");
    }
}