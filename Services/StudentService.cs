

using StudentManagementSystem.InterFaceses;
using StudentManagementSystem.Models;
using StudentManagementSystem.Models.BaseModels;

namespace StudentManagementSystem.Services;

public class StudentService : IStudentService
{
    private readonly GenericService<Student> _studentService;
    private readonly GenericService<Table> _tableService;
    public StudentService(string StUrl,string Url)
    {
            _studentService = new GenericService<Student> (StUrl);
            _tableService = new GenericService<Table>(Url);
    }
    public void EnrollSubject(Guid subjectId, List<DateTime> schedule)
    {
        var user = ChekStudentAuto();
        _tableService.Add(new Table { Id =subjectId,StudentId = user.Id, Schedules = schedule });
    }

    public Student? GetMyProfile()
    {
        var user = ChekStudentAuto();
        var student = _studentService.GetAll();
        return student.FirstOrDefault(i=>i.Email == user.Email && i.UserName== user.UserName );
    }

    public List<Table> GetMySubjects()
    {
        var user = ChekStudentAuto();
        var table = _tableService.GetAll();
        return table.Where(i => i.StudentId == user.Id).ToList();
    }

    public List<Student> GetTeamMates(Guid SubjectId)
    {
        var user = ChekStudentAuto();
        var tables = _tableService.GetAll();
        var filtered = tables.Where(i => i.SubjectId == SubjectId && i.StudentId == user.Id).Select(i=>i.StudentId);
        /// მომაქვს კონკრეტულ საგანზე ყველა სტუდენტი რომელიც სწავლობს ჩემთან ერთად, ვაბრუნებ მათ ID
        
        var students = _studentService.GetAll();
        return students.Where(i => filtered.Contains(i.Id)).ToList();
        /// იფილტრება სტუდენტები id-ის მიხედვით.

    }

    public void UnenrollSubject(Guid subjectId)
    {
        var user = ChekStudentAuto();
        var subject = _tableService.list.FirstOrDefault(i => i.SubjectId == subjectId);
        if (subject != null)
        {
            _tableService.list.Remove(subject);
            _tableService.SaveChangesToFile();
        }
    }

    public void UpdateMyProfile(string PhoneNumber, string Email)
    {
        var user = ChekStudentAuto();
    }

    public void UpdatePassword(string oldPassword, string newPassword)
    {
        var user = ChekStudentAuto();
    }
    private Person ChekStudentAuto() 
    {
        var CurentUser=UserService.LoggedUser;
        if (CurentUser == null)
        {
            throw new UnauthorizedAccessException("please get Autorization");
        }
        else 
        {
            if (CurentUser.role!= Models.Enums.Role.Student)
            {
                throw new UnauthorizedAccessException("Y are Not student");
            }
        }
        return CurentUser;
    }
}
