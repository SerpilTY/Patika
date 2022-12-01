using System;

namespace ReverseCharacterPrinting;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence that I will reverse the characters:");
        string sentence = Console.ReadLine();
        string[] sections = sentence.Split(" ");
        string reverseString = "";
        string word = "";
        char[] letters;

        for (int i = 0; i < sections.Length; i++)
        {
            word = sections[i];
            letters = new char[word.Length];


            for (int j = 0; j < word.Length; j++)
            {
                letters[j] = word[j];

            }

            for (int k = 1; k < letters.Length; k++)
            {
                char gecici = letters[k - 1];
                letters[k - 1] = letters[k];
                letters[k] = gecici;
            }

            if (reverseString.Length == 0)
            {
                reverseString = new string(letters);
            }
            else
            {
                reverseString += " " + new string(letters);
            }
        }

        Console.WriteLine(reverseString);

    }
}

