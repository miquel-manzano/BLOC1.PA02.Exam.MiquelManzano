using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        const string Spacer = "----------------------";
        const string UserInputMsg = "Enter a number (0 to exit):";
        const string UserErrorInputMsg = "Invalid input. Please enter a valid integer.";

        int userNum;
        bool validNumber;
        int doorNum;

        Random rdm = new Random();

        // If you choose 1, you can open all doors, and 0 is to exit.
        do
        {
            Console.WriteLine(Spacer);
            Console.WriteLine(UserInputMsg);
            validNumber = int.TryParse(Console.ReadLine(), out userNum);
            if (!validNumber)
            {
                Console.WriteLine(UserErrorInputMsg);
            }

            if (userNum > 0)
            {
                // Generate random number of doors between 5 and 15
                doorNum = rdm.Next(5, 16);
                Console.WriteLine($"Created {doorNum} doors");

                Console.WriteLine("You can open the doors: ");
                for (int i = 1; i <= doorNum; i++)
                {
                    if (i % userNum == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }
        } while (userNum != 0);
    }
}