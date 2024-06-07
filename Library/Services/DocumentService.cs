using LAB8.Library.IService;
using LAB8.UsersAndDocs;

namespace LAB8.Library.Services;

public class DocumentService : BaseService, IDocumentService
{
    private readonly List<Document> _documents = new List<Document>();

    public void AddDocument(Document document)
    {
        _documents.Add(document);
        Log($"Document {document.Title} added.");
    }

    public void DeleteDocument(int documentId)
    {
        var document = _documents.FirstOrDefault(d => d.Id == documentId);
        if (document != null)
        {
            _documents.Remove(document);
            Log($"Document with ID {documentId} deleted.");
        }
        else
        {
            Log($"Document with ID {documentId} not found.");
        }
    }

    public void UpdateDocument(int documentId, string title, string author)
    {
        var document = _documents.FirstOrDefault(d => d.Id == documentId);
        if (document != null)
        {
            document.Title = title;
            document.Author = author;
            Log($"Document data with ID {documentId} updated.");
        }
        else
        {
            Log($"Document with ID {documentId} not found.");
        }
    }

    public void ListAllDocuments()
    {
        foreach (var document in _documents)
        {
            Console.WriteLine(document);
        }
    }

    public void GetDocById(int docId)
    {
        var document = _documents.FirstOrDefault(d => d.Id == docId);
        if (document != null)
        {
            Console.WriteLine(document);
        }
        else
        {
            Log($"Document with ID {docId} not found.");
        }
    }
    
    public Document GetDocumentById(int documentId)
    {
        return _documents.FirstOrDefault(d => d.Id == documentId);
    }
    
    public List<Document> GetAllDocuments()
    {
        List<Document> documents = _documents;
        return documents;
    }
}