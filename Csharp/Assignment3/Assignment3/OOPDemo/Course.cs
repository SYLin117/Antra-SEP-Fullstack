namespace Assignment3;

public class Course : ICourseService
{
    public string Name { get; set; }
    private List<Student> _studentsList = new List<Student>();

    public List<Student> GetAllStudent()
    {
        return _studentsList;
    }
}