using LAB8.UsersAndDocs;

namespace LAB8.Library.IService;

public interface IUserService
{
    void AddUser(User user);
    void DeleteUser(int userId);
    void UpdateUser(int userId, string firstName, string lastName, string academicGroup);
    void ListAllUsers();
    void GetUserById(int userId);
    List<User> GetAllUsers();
}