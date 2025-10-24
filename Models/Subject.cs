using StudentManagementSystem.Models.BaseModels;

namespace StudentManagementSystem.Models;

/// <summary>
/// Represents a subject offered by a faculty.
/// </summary>
public class Subject:BaseExtention
{ 
    public Guid FacultytId { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
