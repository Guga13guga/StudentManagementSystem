using StudentManagementSystem.Models.BaseModels;

namespace StudentManagementSystem.Models;

/// <summary>
/// Represents the enrollment of a student in a subject along with their schedules.
/// </summary>
public class Table:BaseModel
{  
    public Guid StudentId { get; set; }
    public Guid SubjectId { get; set; }
    public List<DateTime>? Schedules { get; set; }

}
