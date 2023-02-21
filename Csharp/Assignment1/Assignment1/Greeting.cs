namespace Assignment1;

public class Greeting
{
    public static void GreetingToYou()
    {
        DateTime now = DateTime.Now;
        int hour = now.Hour;
        // WriteLine($"hour right now: {hour}");

        if (hour < 12)
        {
            WriteLine("Good Morning");
        }
        else if (hour < 18)
        {
            WriteLine("Good Afternoon");
        }
        else if (hour < 22)
        {
            WriteLine("Good Evening");
        }
        else
        {
            WriteLine("Good Night");
        }
    }
}