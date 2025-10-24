
using StudentManagementSystem.InterFaceses;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services;

public class TeacherServise : ITeacherService
{
    public void AddFaculty(Guid facultyId)
    {
        throw new NotImplementedException();
    }

    public void AddNewStudent(Student stud)
    {
        throw new NotImplementedException();
    }

    public void AddStudentTofaculty(Guid studentTofacultyId, Student stude)
    {
        throw new NotImplementedException();
    }

    public void AddSubject(Subject subject)
    {
        throw new NotImplementedException();
    }

    public void AddSubjectToFaculty(Subject subject, Guid FacultyId)
    {
        throw new NotImplementedException();
    }

    public void EditStudentFaculty(Guid StudentId, Guid FacultyId)
    {
        throw new NotImplementedException();
    }

    public void RemoveFaculty(Guid FacultyId)
    {
        throw new NotImplementedException();
    }

    public void RemoveStudentId(Guid studentId)
    {
        throw new NotImplementedException();
    }

    public void RemoveStudentTofaculty(Guid StudentTofacultyId, Guid FacultyId)
    {
        throw new NotImplementedException();
    }

    public void RemoveSubject(Guid SubjectId)
    {
        throw new NotImplementedException();
    }

    public void RemoveSubjectFromFaculty(Guid SubjectId, Guid FacultyId)
    {
        throw new NotImplementedException();
    }

    public void StatusUpdate(Guid studentId, bool StudStatus)
    {
        throw new NotImplementedException();
    }

    public void UpdateContactInfo(Guid studentId, string Email, string Phone)
    {
        throw new NotImplementedException();
    }
}
