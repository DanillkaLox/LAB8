namespace LAB8;

public class LibrarySystem
{
    private readonly List<User> _users = new List<User>();
    private readonly List<Document> _documents = new List<Document>();
    private readonly Dictionary<int, List<int>> _userDocuments = new Dictionary<int, List<int>>();
    
    public void AddUser(User user)
    {
        _users.Add(user);
        Console.WriteLine($"User {user.FirstName} {user.LastName} added.");
    }

    public void DeleteUser(int userId)
    {
        var user = _users.FirstOrDefault(u => u.Id == userId);
        if (user != null)
        {
            _users.Remove(user);
            Console.WriteLine($"User with ID {userId} deleted.");
        }
        else
        {
            Console.WriteLine($"User with ID {userId} not found.");
        }
    }

    public void UpdateUser(int userId, string firstName, string lastName, string academicGroup)
    {
        var user = _users.FirstOrDefault(u => u.Id == userId);
        if (user != null)
        {
            user.FirstName = firstName;
            user.LastName = lastName;
            user.AcademicGroup = academicGroup;
            Console.WriteLine($"User data with ID {userId} updated.");
        }
        else
        {
            Console.WriteLine($"User with ID {userId} not found.");
        }
    }

    public void ListAllUsers()
    {
        foreach (var user in _users)
        {
            Console.WriteLine(user);
        }
    }

    public void GetUserById(int userId)
    {
        var user = _users.FirstOrDefault(u => u.Id == userId);
        if (user != null)
        {
            Console.WriteLine(user);
        }
        else
        {
            Console.WriteLine($"User with ID {userId} not found.");
        }
    }
    
    public void GetDocById(int docId)
    {
        var doc = _documents.FirstOrDefault(d => d.Id == docId);
        if (doc != null)
        {
            Console.WriteLine(doc);
        }
        else
        {
            Console.WriteLine($"User with ID {docId} not found.");
        }
    }

    public void SortUsersByFirstName(bool ascending = true)
    {
        BubbleSortUser(_users, u => u.FirstName, ascending);
        ListAllUsers();
    }

    public void SortUsersByLastName(bool ascending = true)
    {
        BubbleSortUser(_users, u => u.LastName, ascending);
        ListAllUsers();
    }

    public void SortUsersByAcademicGroup(bool ascending = true)
    {
        BubbleSortUser(_users, u => u.AcademicGroup, ascending);
        ListAllUsers();
    }
    
    public void SortUsersByDocName(bool ascending = true)
    {
        BubbleSortDoc(_documents, d => d.Title, ascending);
        ListAllUsers();
    }
    
    public void SortDocumentsByAuthor(bool ascending = true)
    {
        BubbleSortDoc(_documents, d => d.Author, ascending);
        ListAllDocuments();
    }
    
    private void BubbleSortUser<T>(List<User> list, Func<User, T> keySelector, bool ascending) where T : IComparable
    {
        int n = list.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                int comparison = keySelector(list[j]).CompareTo(keySelector(list[j + 1]));
                if ((ascending && comparison > 0) || (!ascending && comparison < 0))
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }
    }
    
    private void BubbleSortDoc<T>(List<Document> list, Func<Document, T> keySelector, bool ascending) where T : IComparable
    {
        int n = list.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                int comparison = keySelector(list[j]).CompareTo(keySelector(list[j + 1]));
                if ((ascending && comparison > 0) || (!ascending && comparison < 0))
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }
    }
    
    public void AddDocument(Document document)
    {
        _documents.Add(document);
        Console.WriteLine($"Document {document.Title} added.");
    }

    public void DeleteDocument(int documentId)
    {
        var document = _documents.FirstOrDefault(d => d.Id == documentId);
        if (document != null)
        {
            _documents.Remove(document);
            Console.WriteLine($"Document with ID {documentId} deleted.");
        }
        else
        {
            Console.WriteLine($"Document with ID {documentId} not found.");
        }
    }

    public void UpdateDocument(int documentId, string title, string author)
    {
        var document = _documents.FirstOrDefault(d => d.Id == documentId);
        if (document != null)
        {
            document.Title = title;
            document.Author = author;
            Console.WriteLine($"Document data with ID {documentId} updated.");
        }
        else
        {
            Console.WriteLine($"Document with ID {documentId} not found.");
        }
    }

    public void ListAllDocuments()
    {
        foreach (var document in _documents)
        {
            Console.WriteLine(document);
        }
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
                Console.WriteLine($"Document with ID {documentId} issued to user with ID {userId}.");
            }
            else
            {
                Console.WriteLine($"Document with ID {userId} already took the document with ID {documentId}.");
            }
        }
        else
        {
            Console.WriteLine("It is impossible to issue more than 5 documents.");
        }
    }

    public void ReturnDocument(int userId, int documentId)
    {
        if (_userDocuments.ContainsKey(userId) && _userDocuments[userId].Contains(documentId))
        {
            _userDocuments[userId].Remove(documentId);
            Console.WriteLine($"Document with ID {documentId} returned by user ID {userId}.");
        }
        else
        {
            Console.WriteLine($"Document with ID {documentId} was not issued to the user with ID {userId}.");
        }
    }

    public void ListDocumentsByUserId(int userId)
    {
        if (_userDocuments.TryGetValue(userId, out List<int>? borrowedDocuments))
        {
            foreach (var documentId in borrowedDocuments)
            {
                var document = _documents.FirstOrDefault(d => d.Id == documentId);
                if (document != null)
                {
                    Console.WriteLine(document);
                }
            }
        }
        else
        {
            Console.WriteLine($"For a user with ID {userId} no documents issued.");
        }
    }

    public void IsDocumentIssued(int documentId)
    {
        foreach (var user in _userDocuments)
        {
            if (user.Value.Contains(documentId))
            {
                Console.WriteLine($"Document with ID {documentId} issued to user with ID {user.Key}.");
                return;
            }
        }

        Console.WriteLine($"Document with ID {documentId} not issued.");
    }
    
    public void SearchDocumentsByKeyword(string keyword)
    {
        var result = _documents.Where(d => d.Title.Contains(keyword) || d.Author.Contains(keyword));
        foreach (var document in result)
        {
            Console.WriteLine(document);
        }
    }

    public void SearchUsersByKeyword(string keyword)
    {
        var result = _users.Where(u =>
            u.FirstName.Contains(keyword) || u.LastName.Contains(keyword) || u.AcademicGroup.Contains(keyword));
        foreach (var user in result)
        {
            Console.WriteLine(user);
        }
    }
}