namespace Assignment3;

public class Instructor : Person
{
    private int _structor_id;

    public override void CheckIn()
    {
        WriteLine($"Teacher {Name} check in");
    }

    public override void SalaryCalculate()
    {
        base.SalaryCalculate();
        WriteLine($"Calculate instructor: {Name} salary");
    }
}