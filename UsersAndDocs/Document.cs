namespace LAB8.UsersAndDocs;

public class Document
{
    private static int _nextId;
        
    public int Id { get; private set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Document(string title, string author)
    {
        Id = _nextId++;
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Title: {Title}, Author: {Author}";
    }
}
