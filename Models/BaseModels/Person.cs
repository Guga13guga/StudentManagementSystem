using StudentManagementSystem.Models.Enums;

namespace StudentManagementSystem.Models.BaseModels;

/// <summary>
/// Represents a person in the student management system.
/// </summary>
public abstract class Person : BaseModel
{
    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public Role? role { get; set; }
}
