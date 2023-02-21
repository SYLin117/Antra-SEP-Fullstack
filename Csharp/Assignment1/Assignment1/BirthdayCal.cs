namespace Assignment1;

public class BirthdayCal
{
    public static void CalculateAge(int year = 1990, int month = 1, int day = 10)
    {
        DateTime birthdate = new DateTime(year, month, day);
        DateTime today = DateTime.Today;

        var diffOfDates = today - birthdate;
        WriteLine($"you are {diffOfDates.Days / 365} years old");
    }
}