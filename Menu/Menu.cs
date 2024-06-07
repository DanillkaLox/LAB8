using LAB8.Library.IService;
using LAB8.Library.Services;

namespace LAB8;

public static class Menu
{
    static void Main()
    {
        IUserService userService = new UserService();
        IDocumentService documentService = new DocumentService();
        IBorrowService borrowService = new BorrowService(userService, documentService);
        ISortingService sortingService = new SortingService(userService, documentService);
        ISearchService searchService = new SearchService(userService, documentService);
        
        Library.Library librarySystem = new Library.Library(userService, documentService, borrowService, sortingService, searchService);
        
        var running = true;
        while (running)
        {
            Console.WriteLine("\nMain menu:");
            Console.WriteLine("1. User management");
            Console.WriteLine("2. Document management");
            Console.WriteLine("3. Document issuance management");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            var choice = Console.ReadLine() ?? "default value";

            switch (choice)
            {
                case "1":
                    UserMenu.ManageUsers(librarySystem);
                    break;
                case "2":
                    DocumentMenu.ManageDocuments(librarySystem);
                    break;
                case "3":
                    DocumentIssueMenu.ManageDocumentIssues(librarySystem);
                    break;
                case "4":
                    SearchMenu.Search(librarySystem);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again.");
                    break;
            }
        }
    }
}