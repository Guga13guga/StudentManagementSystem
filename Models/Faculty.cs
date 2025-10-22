

namespace StudentManagementSystem.Models;

public class Faculty:BaseExtention
{
    public string Description { get; set; }
    public List<Student> Students { get; set; }
    public List<Subject> Subjects { get; set; }
}
