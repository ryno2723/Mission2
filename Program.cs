using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        RollDice rd = new RollDice();

        int rollNum = 0;

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        string userInput = System.Console.ReadLine();

        int.TryParse(userInput, out rollNum);

        int[] results = rd.RollSim(rollNum);

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + rollNum);

        for (int i = 0; i < results.Length; i++) 
        {
            int percentage = results[i] * 100 / rollNum;

            System.Console.Write(i + 2 + ": ");
            for (int iCount = 0; iCount < percentage; iCount++) 
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}