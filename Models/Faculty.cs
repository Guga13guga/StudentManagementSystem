using StudentManagementSystem.Models.BaseModels;

namespace StudentManagementSystem.Models;

/// <summary>
/// Represents a faculty within the student management system.
/// </summary>
public class Faculty:BaseExtention
{
    public string? Description { get; set; }

    public List<Student>? Students { get; set; }

    public List<Subject>? Subjects { get; set; }
}
