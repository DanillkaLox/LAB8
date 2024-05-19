namespace LAB8;

public class Document
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Document(int documentId, string title, string author)
    {
        Id = documentId;
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Название: {Title}, Автор: {Author}";
    }
}
