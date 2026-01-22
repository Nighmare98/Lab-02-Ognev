using System;
public static class ProcessingModule
{
   public static int CountRussianVowels(string text)
    {
        if (!ValidationModule.IsValidString(text))
            return 0;

            char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };

            int count = 0;

            foreach (char c in text)
            {
                char LowerChar = char.ToLower(c);

                if (Array.IndexOf(vowels, LowerChar) >= 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
