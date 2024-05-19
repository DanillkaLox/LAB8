namespace LAB8;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string AcademicGroup { get; set; }

    public User(int userId, string firstName, string lastName, string academicGroup)
    {
        Id = userId;
        FirstName = firstName;
        LastName = lastName;
        AcademicGroup = academicGroup;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Имя: {FirstName}, Фамилия: {LastName}, Группа: {AcademicGroup}";
    }
}
