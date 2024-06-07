using LAB8.Library.IService;
using LAB8.UsersAndDocs;

namespace LAB8.Library.Services;

public class UserService : BaseService, IUserService
{
    private readonly List<User> _users = new List<User>();

    public void AddUser(User user)
    {
        _users.Add(user);
        Log($"User {user.FirstName} {user.LastName} added.");
    }

    public void DeleteUser(int userId)
    {
        var user = _users.FirstOrDefault(u => u.Id == userId);
        if (user != null)
        {
            _users.Remove(user);
            Log($"User with ID {userId} deleted.");
        }
        else
        {
            Log($"User with ID {userId} not found.");
        }
    }

    public void UpdateUser(int userId, string firstName, string lastName, string academicGroup)
    {
        var user = _users.FirstOrDefault(u => u.Id == userId);
        if (user != null)
        {
            user.FirstName = firstName;
            user.LastName = lastName;
            user.AcademicGroup = academicGroup;
            Log($"User data with ID {userId} updated.");
        }
        else
        {
            Log($"User with ID {userId} not found.");
        }
    }

    public void ListAllUsers()
    {
        foreach (var user in _users)
        {
            Console.WriteLine(user);
        }
    }

    public void GetUserById(int userId)
    {
        var user = _users.FirstOrDefault(u => u.Id == userId);
        if (user != null)
        {
            Console.WriteLine(user);
        }
        else
        {
            Log($"User with ID {userId} not found.");
        }
    }
    
    public List<User> GetAllUsers()
    {
        List<User> users = _users;
        return users;
    }
}