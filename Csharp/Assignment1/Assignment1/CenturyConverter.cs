namespace Assignment1;

public class CenturyConverter
{
    public static void ConvertCentury()
    {
        WriteLine($"Please enter a positive number:");
        string? s = ReadLine();
        int century = 0;
        int.TryParse(s, out century);
        int years = 100 * century;
        int days = years * 365;
        decimal hours = days * 24;
        decimal minutes = hours * 60;
        decimal seconds = minutes * 60;
        decimal microseconds = seconds * 1_000_000;
        decimal nanoseconds = seconds * 1_000_000_000;
        WriteLine(
            $"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}