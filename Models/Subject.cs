

namespace StudentManagementSystem.Models;

public class Subject:BaseExtention
{ 
    public Guid FacultytId { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

}
