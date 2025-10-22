

using System.Security.AccessControl;

namespace StudentManagementSystem.Models;

public class Student:BaseExtention
{
    
    public int Grade { get; set; }
    public Guid FacultyId { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public bool IsActive { get; set; }

    
    
}
