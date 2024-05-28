using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles:");
            int rounds = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            for (int i = 0; i < rounds; i++)
            {
                Hero one = new Knight("Sir Lancelot","Sword");
                Hero two = new Rogue("Robin Hood","Rock");

                Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == one) oneWins++; else twoWins++;
            }
            Console.WriteLine();
            Console.WriteLine($"One has {oneWins} wins.");
            Console.WriteLine($"Two has {twoWins} wins.");
            Console.WriteLine();


            Console.Write("Enter number of battles to second pair of heroes:");
            rounds = Int32.Parse(Console.ReadLine());
            oneWins = 0; twoWins = 0;

            for (int i = 0; i < rounds; i++)
            {
                Hero one = new Mage("Gandalf","MagicWand");
                Hero two = new Pokemon("Pikachu","Bazooka");
                Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == one) oneWins++; else twoWins++;
            }
            Console.WriteLine();
            Console.WriteLine($"One has {oneWins} wins.");
            Console.WriteLine($"Two has {twoWins} wins.");
        }
    }
}
