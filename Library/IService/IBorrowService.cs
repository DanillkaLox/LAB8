namespace LAB8.Library.IService;

public interface IBorrowService
{
    void BorrowDocument(int userId, int documentId);
    void ReturnDocument(int userId, int documentId);
    void ListDocumentsByUserId(int userId);
    void IsDocumentIssued(int documentId);
}