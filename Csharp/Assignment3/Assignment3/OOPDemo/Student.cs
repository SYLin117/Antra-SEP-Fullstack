namespace Assignment3;

public class Student : Person, IStudentService
{
    private int _student_id;
    private List<Course> _courses;

    public override void CheckIn()
    {
        WriteLine($"Student {Name} check in");
    }

    public override void SalaryCalculate()
    {
        base.SalaryCalculate();
        WriteLine($"Calculate student: {Name} salary");
    }

    public float GetGPA()
    {
        throw new NotImplementedException();
    }

    public int CalculateAge()
    {
        throw new NotImplementedException();
    }

    public decimal CalculateSalary()
    {
        throw new NotImplementedException();
    }
}