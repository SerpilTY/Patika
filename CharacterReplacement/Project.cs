
namespace CharacterReplacement;

class Project
{

    public static void Swap()
    {

        System.Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            char[] characters = words[i].ToCharArray();
            char temp = characters[0];
            characters[0] = characters[characters.Length - 1];
            characters[characters.Length - 1] = temp;
            string newString = string.Concat(characters);
            System.Console.Write(newString + " ");
        }
    }
}