using LAB8.Library.IService;
using LAB8.UsersAndDocs;

namespace LAB8.Library;

public class Library
{
    private readonly IUserService _userService;
    private readonly IDocumentService _documentService;
    private readonly IBorrowService _borrowService;
    private readonly ISortingService _sortingService;
    private readonly ISearchService _searchService;

    public Library(IUserService userService, IDocumentService documentService, IBorrowService borrowService,
        ISortingService sortingService, ISearchService searchService)
    {
        _userService = userService;
        _documentService = documentService;
        _borrowService = borrowService;
        _sortingService = sortingService;
        _searchService = searchService;
    }

    public void AddUser(User user) => _userService.AddUser(user);
    public void DeleteUser(int userId) => _userService.DeleteUser(userId);

    public void UpdateUser(int userId, string firstName, string lastName, string academicGroup) =>
        _userService.UpdateUser(userId, firstName, lastName, academicGroup);

    public void ListAllUsers() => _userService.ListAllUsers();
    public void GetUserById(int userId) => _userService.GetUserById(userId);

    public void AddDocument(Document document) => _documentService.AddDocument(document);
    public void DeleteDocument(int documentId) => _documentService.DeleteDocument(documentId);

    public void UpdateDocument(int documentId, string title, string author) =>
        _documentService.UpdateDocument(documentId, title, author);

    public void ListAllDocuments() => _documentService.ListAllDocuments();
    public void GetDocumentById(int docId) => _documentService.GetDocumentById(docId);
    public void GetDocById(int docId) => _documentService.GetDocById(docId);

    public void BorrowDocument(int userId, int documentId) => _borrowService.BorrowDocument(userId, documentId);
    public void ReturnDocument(int userId, int documentId) => _borrowService.ReturnDocument(userId, documentId);
    public void ListDocumentsByUserId(int userId) => _borrowService.ListDocumentsByUserId(userId);
    public void IsDocumentIssued(int documentId) => _borrowService.IsDocumentIssued(documentId);

    public void SortUsersByFirstName(bool ascending) => _sortingService.SortUsersByFirstName(ascending);
    public void SortUsersByLastName(bool ascending) => _sortingService.SortUsersByLastName(ascending);
    public void SortUsersByAcademicGroup(bool ascending) => _sortingService.SortUsersByAcademicGroup(ascending);
    public void SortDocumentsByTitle(bool ascending) => _sortingService.SortDocumentsByTitle(ascending);
    public void SortDocumentsByAuthor(bool ascending) => _sortingService.SortDocumentsByAuthor(ascending);

    public void SearchUsersByKeyword(string keyword) => _searchService.SearchUsersByKeyword(keyword);
    public void SearchDocumentsByKeyword(string keyword) => _searchService.SearchDocumentsByKeyword(keyword);
}