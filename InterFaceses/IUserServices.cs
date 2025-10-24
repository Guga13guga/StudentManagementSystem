using StudentManagementSystem.Models.BaseModels;
using StudentManagementSystem.Models.Enums;

namespace StudentManagementSystem.InterFaceses;

/// <summary>
/// Defines user services for authentication and registration.
/// </summary>
public interface IUserServices
{
    void SignIn(string username, string password,Role role);

    void SignOut();

    Person? GetLoggedUser();

    void Register(Person user);
}
