

namespace StudentManagementSystem.Models;

public class Table:BaseModel
{  
    public Guid StudentId { get; set; }
    public Guid SubjectId { get; set; }
    public List<DateTime> Schedules { get; set; }

}
