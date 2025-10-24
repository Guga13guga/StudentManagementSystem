using StudentManagementSystem.Models.BaseModels;

namespace StudentManagementSystem.Models;

/// <summary>
/// Represents an administrator in the student management system.
/// </summary>
public class Admin : Person
{
    public string? Name { get; set; }
}
