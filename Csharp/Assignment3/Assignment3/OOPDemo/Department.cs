using System.Runtime.InteropServices.ComTypes;

namespace Assignment3;

public class Department : IDepartmentService
{
    private Instructor _chief;
    private decimal _budget;
    private List<Course> _openCourse;

    public Instructor Chief
    {
        get { return _chief; }
        set { _chief = value; }
    }

    public decimal Budget
    {
        get { return _budget; }
        set { _budget = value; }
    }

    public List<Course> GetCourses()
    {
        return _openCourse;
    }
}