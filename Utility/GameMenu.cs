using mis321_pa5_dmhunt5.Utility;

namespace mis321_pa5_dmhunt5
{
    public class GameMenu
    {
        public static void Menu()
        {
            Character[] characters = new Character[2];
            Bowser bowser = new Bowser();
            DonkeyKong donkeyKong = new DonkeyKong();
            Luigi luigi = new Luigi();
            Mario mario = new Mario();
            Peach peach = new Peach();
            System.Console.WriteLine("Player 1, choose your character:\n1. Bowser\n2. Donkey Kong\n3. Luigi\n4. Mario\n5. Peach\n6. Exit");
            string input = Console.ReadLine();
            while(input != "6")
            {
                if(input == "1")
                {
                    characters[0] = bowser;
                }
                else if(input == "2")
                {
                    characters[0] = donkeyKong;
                }
                else if(input == "3")
                {
                    characters[0] = luigi;
                }
                else if(input == "4")
                {
                    characters[0] = mario;
                }
                else if(input == "5")
                {
                    characters[0] = peach;
                }
                System.Console.WriteLine("Player 2, choose your character:\n1. Bowser\n2. Donkey Kong\n3. Luigi\n4. Mario\n5. Peach");
                input = Console.ReadLine();
                if(input == "1")
                {
                    characters[1] = bowser;
                }
                else if(input == "2")
                {
                    characters[1] = donkeyKong;
                }
                else if(input == "3")
                {
                    characters[1] = luigi;
                }
                else if(input == "4")
                {
                    characters[1] = mario;
                }
                else if(input == "5")
                {
                    characters[1] = peach;
                }
                FullGame.PlayGame(characters);
                continue;
            }
        }
    }
}