using System;
public static class ValidationModule
{
    public static bool IsValidString(string text)
    {
        return !string.IsNullOrEmpty(text);
    }
}