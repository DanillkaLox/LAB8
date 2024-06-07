using System;
using LAB8.Library;
using LAB8.UsersAndDocs;

public static class DocumentMenu
{
    public static void ManageDocuments(Library library)
    {
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("\nDocument Management Menu:");
            Console.WriteLine("1. Add Document");
            Console.WriteLine("2. Delete Document");
            Console.WriteLine("3. Update Document");
            Console.WriteLine("4. List All Documents");
            Console.WriteLine("5. Get Document by ID");
            Console.WriteLine("6. Sort Documents");
            Console.WriteLine("7. Return to Main Menu");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine() ?? "default value";

            switch (choice)
            {
                case "1":
                    AddDocument(library);
                    break;
                case "2":
                    DeleteDocument(library);
                    break;
                case "3":
                    UpdateDocument(library);
                    break;
                case "4":
                    ListAllDocuments(library);
                    break;
                case "5":
                    GetDocumentById(library);
                    break;
                case "6":
                    SortDocuments(library);
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again.");
                    break;
            }
        }
    }

    private static void AddDocument(Library library)
    {
        Console.Write("Enter document title: ");
        string title = Console.ReadLine();
        Console.Write("Enter document author: ");
        string author = Console.ReadLine();
        
        library.AddDocument(new Document(title, author));
        Console.WriteLine("Document added successfully.");
    }

    private static void DeleteDocument(Library library)
    {
        library.ListAllDocuments();
        Console.Write("Enter document ID to delete: ");
        int docId = int.Parse(Console.ReadLine() ?? "-1");
        
        library.DeleteDocument(docId);
        Console.WriteLine("Document deleted successfully.");
    }

    private static void UpdateDocument(Library library)
    {
        library.ListAllDocuments();
        Console.Write("Enter document ID to update: ");
        int docId = int.Parse(Console.ReadLine() ?? "-1");
        Console.Write("Enter new title: ");
        string title = Console.ReadLine();
        Console.Write("Enter new author: ");
        string author = Console.ReadLine();
        
        library.UpdateDocument(docId, title, author);
        Console.WriteLine("Document updated successfully.");
    }

    private static void ListAllDocuments(Library library)
    {
        library.ListAllDocuments();
    }

    private static void GetDocumentById(Library library)
    {
        Console.Write("Enter document ID: ");
        int docId = int.Parse(Console.ReadLine() ?? "-1");
        
        library.GetDocById(docId);
    }

    private static void SortDocuments(Library librarySystem)
    {
        Console.WriteLine("1. Sort by author (ascending)");
        Console.WriteLine("2. Sort by author (descending)");
        Console.WriteLine("3. Sort by title (ascending)");
        Console.WriteLine("4. Sort by title (descending)");
        Console.Write("Select an option: ");
        var sortChoice = Console.ReadLine() ?? "default value";
        switch (sortChoice)
        {
            case "1":
                librarySystem.SortDocumentsByAuthor(true);
                break;
            case "2":
                librarySystem.SortDocumentsByAuthor(false);
                break;
            case "3":
                librarySystem.SortDocumentsByTitle(true);
                break;
            case "4":
                librarySystem.SortDocumentsByTitle(false);
                break;
            default:
                Console.WriteLine("Wrong choice, try again.");
                break;
        }
    }
}
