namespace ConsoleApp1;

public abstract class Employee
{
    public virtual void Work()
    {
        WriteLine("Employee working");
    }

    public abstract void GetPaid();
}

public class Manager : Employee
{
    public override void Work()
    {
        // base.Work();
        WriteLine("Manager working");
    }

    public override void GetPaid()
    {
        throw new NotImplementedException();
    }
}