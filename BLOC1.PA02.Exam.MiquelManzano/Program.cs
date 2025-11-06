using System.Data.SqlTypes;

public class Program
{
    public static void Main()
    {
        const string Spacer = "----------------------";
        const string UserInputMsg = "Enter a number (0 to exit):";
        const string UserErrorInputMsg = "Invalid input. Please enter a valid integer.";

        bool validNumber;
        int userNum;
        int number;

        do
        {
            Console.WriteLine(Spacer);
            Console.WriteLine(UserInputMsg);
            validNumber = int.TryParse(Console.ReadLine(), out userNum);
            if (!validNumber)
            {
                Console.WriteLine(UserErrorInputMsg);
            }
            else
            {
                number = userNum;
                Console.Write("The factors of {0} are: ", userNum);
                while (number >= 1)
                {
                    if (userNum % number == 0)
                    {
                        Console.Write("{0} ", number);
                    }
                    number--;
                }
                Console.WriteLine();
            }
        } while (userNum != 0);
    }
}