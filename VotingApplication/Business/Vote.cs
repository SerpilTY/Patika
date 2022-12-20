namespace Business;
public class Vote
{

    public static void VoteNow()
    {
        List<string> catagories = new List<string> { "Adventure", "Action", "Comedy", "Romance" };
        int adventureCount = 0;
        int actionCount = 0;
        int comedyCount = 0;
        int romanceCount = 0;

        Console.WriteLine("Please Vote For The Gorgeous Cinema Industry");
        for (int i = 0; i < catagories.Count; i++)
        {
            Console.WriteLine("For " + catagories[i] + " please press " + (i+1));
        }

        int b = Convert.ToInt32(Console.ReadLine());

        if (b == 1) adventureCount++;
        if (b == 2) actionCount++;
        if (b == 3) comedyCount++;
        if (b == 4) romanceCount++;

        Console.WriteLine("Thanks for your vote");
    }

}