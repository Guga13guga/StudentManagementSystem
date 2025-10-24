using StudentManagementSystem.InterFaceses;
using StudentManagementSystem.Models;
using StudentManagementSystem.Models.BaseModels;
using StudentManagementSystem.Models.Enums;

namespace StudentManagementSystem.Services;

/// <summary>
/// Provides user services for authentication and registration.
/// </summary>
public class UserService : IUserServices
{
    private readonly IGenericService<Student> _personService;
    private readonly IGenericService<Admin> _adminService;

    public UserService(string StudenInfo, string AdminInfo)
    {
        _personService = new GenericService<Student>(StudenInfo);
        _adminService = new GenericService<Admin>(AdminInfo);
    }

    public static Person? LoggedUser { get; set; }

    public Person? GetLoggedUser()
    {
        if(LoggedUser != null)
        {
            return LoggedUser;
        }
        return null;
    }

    public void Register(Person user)
    {
        if (user.role == Role.Admin)
        {
            throw new UnauthorizedAccessException("We do not create admin users through this method. please contact our support");
        }
        else
        {
            var getUsers = _personService.GetAll();
            if (getUsers?.Any(u => u?.UserName == user?.UserName) == true)
            {
                throw new InvalidOperationException("Username already exists. please choose another username");
            }
            _personService.Add((Student)user);
        }
    }

    public void SignIn(string username, string password, Role Role)
    {
        if(LoggedUser != null)
        {
            throw new InvalidOperationException("A user is already logged in. please waite before system release");
        }

        if (Role == Role.Student)
        {
            var student = _personService?.GetAll()?.FirstOrDefault(s => s.UserName == username && s.Password == password&&s.role==Role.Student);
            if (student != null)
            {
                LoggedUser = student;
            }
            else
            {
                throw new UnauthorizedAccessException("Invalid username or password for student.");
            }
        }
        else if(Role == Role.Admin)
        {
            var admin = _adminService?.GetAll()?.FirstOrDefault(a => a.UserName == username && a.Password == password && a.role == Role.Admin);
            if (admin != null)
            {
                LoggedUser = admin;
            }
            else
            {
                throw new UnauthorizedAccessException("Invalid username or password for admin.");
            }
        }
        else
        {
            throw new ArgumentException("Invalid role specified.");
        }
    }

    public void SignOut()
    {
        if (LoggedUser is null)
        {
            throw new UnauthorizedAccessException("No user is currently logged in.");
        }
        LoggedUser = null;
    }
}
