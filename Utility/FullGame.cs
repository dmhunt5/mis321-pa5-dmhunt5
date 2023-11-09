namespace mis321_pa5_dmhunt5.Utility
{
    public class FullGame
    {
        public static void PlayGame(Character[] characters)
        {
            characters[0].MaxPower = RandomGenerator.RandomNumber(1, 100);
            characters[0].AttackStrength = RandomGenerator.RandomNumber(1, characters[0].MaxPower);
            characters[0].DefensePower = RandomGenerator.RandomNumber(1, characters[0].MaxPower);
            characters[1].MaxPower = RandomGenerator.RandomNumber(1, 100);
            characters[1].AttackStrength = RandomGenerator.RandomNumber(1, characters[0].MaxPower);
            characters[1].DefensePower = RandomGenerator.RandomNumber(1, characters[0].MaxPower);

            System.Console.WriteLine("Enter player 1's name:");
            characters[0].PlayerName = Console.ReadLine();
            System.Console.WriteLine("Enter player 2's name:");
            characters[0].PlayerName = Console.ReadLine();

            while(characters[0].Health !<= 0 && characters[1].Health !<= 0)
            {
                characters[0].Health = characters[0].Health - (characters[1].AttackStrength - characters[0].DefensePower);
                System.Console.WriteLine($"{characters[1].PlayerName} hit {characters[0].PlayerName} and now they're at {characters[0].Health} health!");
                characters[1].Health = characters[1].Health - (characters[0].AttackStrength - characters[1].DefensePower);
                System.Console.WriteLine($"{characters[0].PlayerName} hit {characters[1].PlayerName} and now they're at {characters[1].Health} health!");
            }

            if(characters[0].Health == 0)
            {
                System.Console.WriteLine($"{characters[1].PlayerName} wins!");
            }
            else
            {
                System.Console.WriteLine($"{characters[0].PlayerName} wins!");
            }
        }
    }
}