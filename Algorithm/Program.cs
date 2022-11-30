namespace Algorithm;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a word followed by the index of the character you want to extract (Use a comma between them.):");
        string word = Console.ReadLine();            
        string[] sections=word.Split(","); 
        string firstWord=sections[0]; 
        int number=int.Parse(sections[1]);
        firstWord=firstWord.Remove(number,1);
        Console.WriteLine(firstWord);

}}
