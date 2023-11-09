namespace mis321_pa5_dmhunt5
{
    public class MainMenu
    {
        public static void Menu()
        {
            Console.Clear();
            

            System.Console.WriteLine("Enter menu choice:\n1. Play game\n2. Exit");
            string input = Console.ReadLine();
            while(input != "2")
            {
                if(input != "1")
                {
                    System.Console.WriteLine("Invalid Input.");
                    input = Console.ReadLine();
                    System.Console.WriteLine("Enter menu choice:\n1. Play game\n2. Exit");
                }
                else
                {
                    GameMenu.Menu();
                }
                System.Console.WriteLine("Enter menu choice:\n1. Play game\n2. Exit");
                input = Console.ReadLine();
            }
        }        
    }
}