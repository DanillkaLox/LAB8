using LAB8.Library.IService;

namespace LAB8.Library.Services;

public class BorrowService : BaseService, IBorrowService
{
    private readonly Dictionary<int, List<int>> _userDocuments = new Dictionary<int, List<int>>();
    private readonly IUserService _userService;
    private readonly IDocumentService _documentService;

    public BorrowService(IUserService userService, IDocumentService documentService)
    {
        _userService = userService;
        _documentService = documentService;
    }

    public void BorrowDocument(int userId, int documentId)
    {
        if (!_userDocuments.ContainsKey(userId))
        {
            _userDocuments[userId] = new List<int>();
        }

        if (_userDocuments[userId].Count < 5)
        {
            if (!_userDocuments[userId].Contains(documentId))
            {
                _userDocuments[userId].Add(documentId);
                Log($"Document with ID {documentId} issued to user with ID {userId}.");
            }
            else
            {
                Log($"User with ID {userId} already took the document with ID {documentId}.");
            }
        }
        else
        {
            Log("It is impossible to issue more than 5 documents.");
        }
    }

    public void ReturnDocument(int userId, int documentId)
    {
        if (_userDocuments.ContainsKey(userId) && _userDocuments[userId].Contains(documentId))
        {
            _userDocuments[userId].Remove(documentId);
            Log($"Document with ID {documentId} returned by user ID {userId}.");
        }
        else
        {
            Log($"Document with ID {documentId} was not issued to the user with ID {userId}.");
        }
    }

    public void ListDocumentsByUserId(int userId)
    {
        if (_userDocuments.TryGetValue(userId, out var borrowedDocuments))
        {
            foreach (var documentId in borrowedDocuments)
            {
                var document = _documentService.GetDocumentById(documentId);
                if (document != null)
                {
                    Console.WriteLine(document);
                }
            }
        }
        else
        {
            Log($"For a user with ID {userId} no documents issued.");
        }
    }

    public void IsDocumentIssued(int documentId)
    {
        foreach (var user in _userDocuments)
        {
            if (user.Value.Contains(documentId))
            {
                Log($"Document with ID {documentId} issued to user with ID {user.Key}.");
                return;
            }
        }

        Log($"Document with ID {documentId} not issued.");
    }
}