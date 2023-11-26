using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Metin giriniz: ");
        string text = Console.ReadLine();
        List<char> vowel = GetVowels(text);
        foreach(char item in vowel)
            Console.Write(item + ", ");
    }

    public static List<char> GetVowels(string text)
    {
        char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        List<char> findVowels = new List<char>();

        foreach (char character in text)
        {
            char lowerLetter = char.ToLower(character);

            if (Array.Exists(vowels, h => h == lowerLetter))
            {
                
                findVowels.Add(lowerLetter);
                
            }
        }

        return findVowels;
    }
}
