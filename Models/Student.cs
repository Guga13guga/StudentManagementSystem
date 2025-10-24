using StudentManagementSystem.Models.BaseModels;

namespace StudentManagementSystem.Models;

/// <summary>
/// Represents a student in the student management system.
/// </summary>
public class Student:Person
{   
    public int Grade { get; set; }

    public Guid FacultyId { get; set; }

    public string? Surname { get; set; }

    public string? Phone { get; set; }

    public bool IsActive { get; set; } 
}
