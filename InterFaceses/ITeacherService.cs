using StudentManagementSystem.Models;

namespace StudentManagementSystem.InterFaceses;

/// <summary>
/// Defines teacher services for managing students, subjects, and faculties.
/// </summary>
public interface ITeacherService
{
    void AddNewStudent(Student stud);

    void RemoveStudentId(Guid studentId);

    void UpdateContactInfo(Guid studentId, string Email, string Phone);

    void StatusUpdate(Guid studentId,bool StudStatus);

    void AddSubject(Subject subject);

    void RemoveSubject(Guid SubjectId);

    void AddFaculty(Guid facultyId);

    void RemoveFaculty(Guid FacultyId);

    void AddStudentTofaculty(Guid studentTofacultyId,Student stude);

    void RemoveStudentTofaculty(Guid StudentTofacultyId,Guid FacultyId);

    void EditStudentFaculty(Guid StudentId,Guid FacultyId);

    void AddSubjectToFaculty(Subject subject, Guid FacultyId );

    void RemoveSubjectFromFaculty(Guid SubjectId,Guid FacultyId );
}
