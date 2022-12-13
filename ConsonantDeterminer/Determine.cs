using System.Text.RegularExpressions;

namespace ConsonantDeterminer;

class Determine
{

    public static void Consonant()
    {

        Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(" ");


        foreach (var word in words)
        {
            bool def = false;
            for (int i = 1; i < word.Length; i++)
            {
                if (isConsonant(word[i]) == isConsonant(word[i - 1]))
                    def = true;                  
            }
            Console.Write(def + " ");
        }

        bool isConsonant(char c)
        {
            return !"aeıioöuü".ToCharArray().Contains(c);
        }
    }
}