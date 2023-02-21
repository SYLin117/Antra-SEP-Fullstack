namespace Assignment1;

public class NumberGuessGame
{
    public static void GuessNumber(int validMin = 1, int validMax = 3)
    {
        int correctNumber = new Random().Next(3) + 1;
        while (true)
        {
            WriteLine($"please guess a number between {validMin} and {validMax}");
            try
            {
                int guessedNumber = int.Parse(ReadLine());
                if (guessedNumber < validMin || guessedNumber > validMax)
                {
                    WriteLine("please input number between ");
                }
                else if (guessedNumber > correctNumber)
                {
                    WriteLine("your number is higher than the answer");
                }
                else if (guessedNumber < correctNumber)
                {
                    WriteLine("your number is lower than the answer");
                }
                else if (guessedNumber == correctNumber)
                {
                    WriteLine("You get it right!");
                    break;
                }
            }
            catch (Exception e)
            {
                WriteLine("please input valid number");
            }
        }
    }
}