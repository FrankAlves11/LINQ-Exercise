namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>()
            {
                "Skyrim",
                "Fallout New Vegas",
                "Minecraft",
                "Apex Legends",
                "Call of duty black ops",
                "Outlast"
            };

            var orderedGames = videoGames.OrderBy(game => game.Length);

            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }

        }      
       
    }
}
