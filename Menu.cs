namespace LAB8;

public static class Menu
{
    private static void ManageUsers(LibrarySystem librarySystem)
    {
        bool managingUsers = true;
        while (managingUsers)
        {
            Console.WriteLine("\nUser management:");
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Delete user");
            Console.WriteLine("3. Change user details");
            Console.WriteLine("4. View all users");
            Console.WriteLine("5. Sort users");
            Console.WriteLine("6. View user data by ID");
            Console.WriteLine("7. Back");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine() ?? "default value";

            switch (choice)
            {
                case "1":
                    Console.Write("Enter name: ");
                    string firstName = Console.ReadLine() ?? "default value";
                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine() ?? "default value";
                    Console.Write("Enter academic group: ");
                    string academicGroup = Console.ReadLine() ?? "default value";
                    librarySystem.AddUser(new User(firstName, lastName, academicGroup));
                    break;
                case "2":
                    librarySystem.ListAllUsers();
                    Console.Write("Enter the user ID to delete: ");
                    int deleteId = int.Parse(Console.ReadLine() ?? "default value");
                    librarySystem.DeleteUser(deleteId);
                    break;
                case "3":
                    librarySystem.ListAllUsers();
                    Console.Write("Enter the user ID to change: ");
                    int updateId = int.Parse(Console.ReadLine() ?? "default value");
                    Console.Write("Enter a new name: ");
                    string newFirstName = Console.ReadLine() ?? "default value";
                    Console.Write("Enter a new last name: ");
                    string newLastName = Console.ReadLine() ?? "default value";
                    Console.Write("Enter a new academic group: ");
                    string newAcademicGroup = Console.ReadLine() ?? "default value";
                    librarySystem.UpdateUser(updateId, newFirstName, newLastName, newAcademicGroup);
                    break;
                case "4":
                    librarySystem.ListAllUsers();
                    break;
                case "5":
                    Console.WriteLine("1. Sort by name (ascending)");
                    Console.WriteLine("2. Sort by name (descending)");
                    Console.WriteLine("3. Sort by last name (ascending)");
                    Console.WriteLine("4. Sort by last name (descending)");
                    Console.WriteLine("5. Sort by academic group (ascending)");
                    Console.WriteLine("6. Sort by academic group (descending)");
                    Console.Write("Select an option: ");
                    string sortChoice = Console.ReadLine() ?? "default value";
                    switch (sortChoice)
                    {
                        case "1":
                            librarySystem.SortUsersByFirstName();
                            break;
                        case "2":
                            librarySystem.SortUsersByFirstName(false);
                            break;
                        case "3":
                            librarySystem.SortUsersByLastName();
                            break;
                        case "4":
                            librarySystem.SortUsersByLastName(false);
                            break;
                        case "5":
                            librarySystem.SortUsersByAcademicGroup();
                            break;
                        case "6":
                            librarySystem.SortUsersByAcademicGroup(false);
                            break;
                        default:
                            Console.WriteLine("Wrong choice, try again.");
                            break;
                    }

                    break;
                case "6":
                    Console.Write("Enter user ID: ");
                    int userId = int.Parse(Console.ReadLine() ?? "default value");
                    librarySystem.GetUserById(userId);
                    break;
                case "7":
                    managingUsers = false;
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again.");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    private static void ManageDocuments(LibrarySystem librarySystem)
    {
        bool managingDocuments = true;
        while (managingDocuments)
        {
            Console.WriteLine("\nDocument management:");
            Console.WriteLine("1. Add a document");
            Console.WriteLine("2. Delete document");
            Console.WriteLine("3. Change document details");
            Console.WriteLine("4. View all documents");
            Console.WriteLine("5. Sort documents");
            Console.WriteLine("6. View document data by ID");
            Console.WriteLine("7. Back");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine() ?? "default value";

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the title: ");
                    string title = Console.ReadLine() ?? "default value";
                    Console.Write("Enter the author: ");
                    string author = Console.ReadLine() ?? "default value";
                    librarySystem.AddDocument(new Document(title, author));
                    break;
                case "2":
                    librarySystem.ListAllDocuments();
                    Console.Write("Enter the document ID to delete: ");
                    int deleteId = int.Parse(Console.ReadLine() ?? "default value");
                    librarySystem.DeleteDocument(deleteId);
                    break;
                case "3":
                    librarySystem.ListAllDocuments();
                    Console.Write("\nEnter the document ID to change: ");
                    int updateId = int.Parse(Console.ReadLine() ?? "default value");
                    Console.Write("Enter a new name: ");
                    string newTitle = Console.ReadLine() ?? "default value";
                    Console.Write("Enter a new author: ");
                    string newAuthor = Console.ReadLine() ?? "default value";
                    librarySystem.UpdateDocument(updateId, newTitle, newAuthor);
                    break;
                case "4":
                    librarySystem.ListAllDocuments();
                    break;
                case "5":
                    Console.WriteLine("1. Sort by name (ascending)");
                    Console.WriteLine("2. Sort by name (descending)");
                    Console.WriteLine("3. Sort by author (ascending)");
                    Console.WriteLine("4. Sort by author (descending)");
                    Console.Write("Select an option: ");
                    string sortChoice = Console.ReadLine() ?? "default value";
                    switch (sortChoice)
                    {
                        case "1":
                            librarySystem.SortUsersByDocName();
                            break;
                        case "2":
                            librarySystem.SortUsersByDocName(false);
                            break;
                        case "3":
                            librarySystem.SortDocumentsByAuthor();
                            break;
                        case "4":
                            librarySystem.SortDocumentsByAuthor(false);
                            break;
                        default:
                            Console.WriteLine("Wrong choice, try again.");
                            break;
                    }

                    break;
                case "6":
                    Console.Write("Enter document ID: ");
                    int docId = int.Parse(Console.ReadLine() ?? "default value");
                    librarySystem.GetDocById(docId);
                    break;
                case "7":
                    managingDocuments = false;
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again.");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    private static void ManageDocumentIssues(LibrarySystem librarySystem)
    {
        bool managingIssues = true;
        while (managingIssues)
        {
            Console.WriteLine("\nDocument issuance management:");
            Console.WriteLine("1. Issue a document");
            Console.WriteLine("2. Return document");
            Console.WriteLine("3. View user documents");
            Console.WriteLine("4. Check if the document has been issued");
            Console.WriteLine("5. \nBack");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine() ?? "default value";

            switch (choice)
            {
                case "1":
                    librarySystem.ListAllUsers();
                    Console.Write("Enter user ID: ");
                    int userId = int.Parse(Console.ReadLine() ?? "default value");
                    librarySystem.ListAllDocuments();
                    Console.Write("Enter document ID: ");
                    int documentId = int.Parse(Console.ReadLine() ?? "default value");
                    librarySystem.BorrowDocument(userId, documentId);
                    break;
                case "2":
                    librarySystem.ListAllUsers();
                    Console.Write("Enter user ID: ");
                    int returnUserId = int.Parse(Console.ReadLine() ?? "default value");
                    librarySystem.ListAllDocuments();
                    Console.Write("Enter document ID: ");
                    int returnDocumentId = int.Parse(Console.ReadLine() ?? "default value");
                    librarySystem.ReturnDocument(returnUserId, returnDocumentId);
                    break;
                case "3":
                    librarySystem.ListAllUsers();
                    Console.Write("Enter user ID: ");
                    int listUserId = int.Parse(Console.ReadLine() ?? "default value");
                    librarySystem.ListDocumentsByUserId(listUserId);
                    break;
                case "4":
                    librarySystem.ListAllDocuments();
                    Console.Write("Enter document ID: ");
                    int checkDocumentId = int.Parse(Console.ReadLine() ?? "default value");
                    librarySystem.IsDocumentIssued(checkDocumentId);
                    break;
                case "5":
                    managingIssues = false;
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again.");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    private static void Search(LibrarySystem librarySystem)
    {
        bool searching = true;
        while (searching)
        {
            Console.WriteLine("\nSearch:");
            Console.WriteLine("1. Search by keyword among documents");
            Console.WriteLine("2. Search by keyword among users");
            Console.WriteLine("3. Back");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine() ?? "default value";

            switch (choice)
            {
                case "1":
                    Console.Write("Enter keyword: ");
                    string documentKeyword = Console.ReadLine() ?? "default value";
                    librarySystem.SearchDocumentsByKeyword(documentKeyword);
                    break;
                case "2":
                    Console.Write("Enter keyword: ");
                    string userKeyword = Console.ReadLine() ?? "default value";
                    librarySystem.SearchUsersByKeyword(userKeyword);
                    break;
                case "3":
                    searching = false;
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again.");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    static void Main()
    {
        LibrarySystem librarySystem = new LibrarySystem();
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMain menu:");
            Console.WriteLine("1. User management");
            Console.WriteLine("2. Document management");
            Console.WriteLine("3. Document issuance management");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine() ?? "default value";

            switch (choice)
            {
                case "1":
                    ManageUsers(librarySystem);
                    break;
                case "2":
                    ManageDocuments(librarySystem);
                    break;
                case "3":
                    ManageDocumentIssues(librarySystem);
                    break;
                case "4":
                    Search(librarySystem);
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
