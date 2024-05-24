namespace LAB5;

public class Student
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Course { get; set; }
    public string Group { get; set; }
    

    public Student(string login, string firstName, string lastName, int course, string group)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Group = group;
        Course = course;
    }
}