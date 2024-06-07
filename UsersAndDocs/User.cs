namespace LAB8.UsersAndDocs;

public class User
{
    private static int _nextId;
    
    public int Id { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string AcademicGroup { get; set; }

    public User(string firstName, string lastName, string academicGroup)
    {
        Id = _nextId++;
        FirstName = firstName;
        LastName = lastName;
        AcademicGroup = academicGroup;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {FirstName}, Surname: {LastName}, Group: {AcademicGroup}";
    }
}
