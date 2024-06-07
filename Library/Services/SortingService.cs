using LAB8.Library.IService;

namespace LAB8.Library.Services;

public class SortingService : BaseService, ISortingService
{
    private readonly IUserService _userService;
    private readonly IDocumentService _documentService;

    public SortingService(IUserService userService, IDocumentService documentService)
    {
        _userService = userService;
        _documentService = documentService;
    }

    public void SortUsersByFirstName(bool ascending)
    {
        var users = _userService.GetAllUsers();
        BubbleSort(users, u => u.FirstName, ascending);
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }

    public void SortUsersByLastName(bool ascending)
    {
        var users = _userService.GetAllUsers();
        BubbleSort(users, u => u.LastName, ascending);
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }

    public void SortUsersByAcademicGroup(bool ascending)
    {
        var users = _userService.GetAllUsers();
        BubbleSort(users, u => u.AcademicGroup, ascending);
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }

    public void SortDocumentsByTitle(bool ascending)
    {
        var documents = _documentService.GetAllDocuments();
        BubbleSort(documents, d => d.Title, ascending);
        foreach (var document in documents)
        {
            Console.WriteLine(document);
        }
    }

    public void SortDocumentsByAuthor(bool ascending)
    {
        var documents = _documentService.GetAllDocuments();
        BubbleSort(documents, d => d.Author, ascending);
        foreach (var document in documents)
        {
            Console.WriteLine(document);
        }
    }

    private void BubbleSort<T>(List<T> list, Func<T, IComparable> keySelector, bool ascending)
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
}