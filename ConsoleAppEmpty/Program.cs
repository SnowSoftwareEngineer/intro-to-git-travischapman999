using GameEnums;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a difficulty");
        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"{i} for ");
            Console.WriteLine((GameDifficulty)i);
        }
        int Difficulty = int.Parse(Console.ReadLine());

        Console.WriteLine("Select a character class");
        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"{i} for ");
            Console.WriteLine((CharacterClass)i);
        }
        int Class = int.Parse(Console.ReadLine());
        Console.WriteLine("You selected:");
        Console.WriteLine($"Difficulty: {(GameDifficulty)Difficulty}");
        Console.WriteLine("Character Class: " + (CharacterClass)Class);
    }

}
