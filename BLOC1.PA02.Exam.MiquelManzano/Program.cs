public class Program
{
    public static void Main()
    {
        // User messages
        const string TrapMsg = "You stepped on a trap!";
        const string CoinMsg = "You found a coin!";
        const string WinMsg = "You've won!";
        const string LoseMsg = "You've lost!";

        int lives = 3;
        int coins = 0;

        bool tramp;

        Random rdm = new Random();

        // Game ends when player gets 5 coins or loses all lives 
        while (lives > 0 && coins < 5)
        {
            // Randomly determine if the player hits a trap or finds a coin
            tramp = rdm.Next(2) == 0;

            if (tramp)
            {
                Console.WriteLine(TrapMsg);
                lives--;
            }
            else
            {
                Console.WriteLine(CoinMsg);
                coins++;
            }
        }
        Console.WriteLine(lives > 0 && coins >= 5 ? WinMsg : LoseMsg);
        
        Console.WriteLine($"Final stats:\nLives: {lives}, Coins: {coins}");
    }
}