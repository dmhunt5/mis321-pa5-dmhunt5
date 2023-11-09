namespace mis321_pa5_dmhunt5.Utility
{
    public class RandomGenerator
    {
        public static int RandomNumber(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
    }
}