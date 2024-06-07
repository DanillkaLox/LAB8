using LAB8.UsersAndDocs;

namespace LAB8.Library.IService;

public interface IDocumentService
{
    void AddDocument(Document document);
    void DeleteDocument(int documentId);
    void UpdateDocument(int documentId, string title, string author);
    void ListAllDocuments();
    void GetDocById(int userId);
    Document GetDocumentById(int documentId);
    List<Document> GetAllDocuments();
}