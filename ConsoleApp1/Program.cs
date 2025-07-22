namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // Variablies and Instances
        Random dice = new Random();
        int number1 = dice.Next(1, 7);
        int number2 = dice.Next(1, 7);
        int number3 = dice.Next(1, 7);
        int rollSum = number1 + number2 + number3;

        // Reveal the roll
        System.Console.WriteLine($"You Rolled: {number1}, {number2}, {number3}");

        // Check for doubles or triples
        if (number1.Equals(number2) && number2.Equals(number3))
        {
            rollSum += 6;
            System.Console.WriteLine("You Rolled Triples +6 Points!");
        }
        else if (number1.Equals(number2) || number2.Equals(number3) || number1.Equals(number3))
        {
            rollSum += 2;
            System.Console.WriteLine("You Rolled Doubles +2 Points!");
        }

        // Check for high or low scores
        if (rollSum == 24)
        {
            System.Console.WriteLine("You Won A House!");
        }
        else if (rollSum >= 18)
        {
            System.Console.WriteLine("You Won A Car!");
        }
        else if (rollSum >= 15)
        
        // Check for high or low scores
        if (rollSum >= 15)
        {
            System.Console.WriteLine("--High Score!--");
        }
        else if (rollSum < 6)
        {
            System.Console.WriteLine("--Low Score!--");
        }
        
        // Final Score
        System.Console.WriteLine($"Total Score: {rollSum}");

    }
}
