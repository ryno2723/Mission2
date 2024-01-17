using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {// Create new class and initialize variable
        RollDice rd = new RollDice();

        int rollNum = 0;
        //Create intro text and user input
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.Write("\nHow many dice rolls would you like to simulate? ");
        string userInput = System.Console.ReadLine();
        //convert to integer
        int.TryParse(userInput, out rollNum);
        //create array that receives array from method
        int[] results = rd.RollSim(rollNum);

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + rollNum + ".\n");
        //For loop that runs through array and prints * for each percent calculated for each roll
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
        //End simulation
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}