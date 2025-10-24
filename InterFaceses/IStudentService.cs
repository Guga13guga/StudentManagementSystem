using StudentManagementSystem.Models;

namespace StudentManagementSystem.InterFaceses;

/// <summary>
/// Defines student-specific services for profile management and subject enrollment.
/// </summary>
public interface IStudentService
{
    Student? GetMyProfile();

    void UpdateMyProfile(string PhoneNumber, string Email);

    void UpdatePassword(string oldPassword, string newPassword);

    void EnrollSubject(Guid subjectId, List<DateTime> schedule);

    void UnenrollSubject(Guid subjectId);

    List<Table> GetMySubjects();

    /// <summary>
    /// Give View only if the student is enroll to this subject
    /// </summary>
    /// <param name="SubjectId"></param>
    /// <returns></returns>
    List<Student> GetTeamMates(Guid SubjectId);
}
