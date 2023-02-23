namespace Assignment3;

public class Person
{
    private string _name = "";
    private string _email = "";
    private decimal _baseSalary;
    private string _address = "";


    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public virtual void CheckIn()
    {
    }

    public virtual void SalaryCalculate()
    {
        WriteLine("base class calculate.");
    }
}