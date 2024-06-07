using System;
using LAB8.Library;

public static class DocumentIssueMenu
{
    public static void ManageDocumentIssues(Library library)
    {
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("\nDocument Issuance Management Menu:");
            Console.WriteLine("1. Borrow Document");
            Console.WriteLine("2. Return Document");
            Console.WriteLine("3. List Documents by User ID");
            Console.WriteLine("4. Check if Document is Issued");
            Console.WriteLine("5. Return to Main Menu");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine() ?? "default value";

            switch (choice)
            {
                case "1":
                    BorrowDocument(library);
                    break;
                case "2":
                    ReturnDocument(library);
                    break;
                case "3":
                    ListDocumentsByUserId(library);
                    break;
                case "4":
                    IsDocumentIssued(library);
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

    private static void BorrowDocument(Library library)
    {
        Console.Write("Enter user ID: ");
        int userId = int.Parse(Console.ReadLine() ?? "-1");
        Console.Write("Enter document ID: ");
        int docId = int.Parse(Console.ReadLine() ?? "-1");
        
        library.BorrowDocument(userId, docId);
    }

    private static void ReturnDocument(Library library)
    {
        Console.Write("Enter user ID: ");
        int userId = int.Parse(Console.ReadLine() ?? "-1");
        Console.Write("Enter document ID: ");
        int docId = int.Parse(Console.ReadLine() ?? "-1");
        
        library.ReturnDocument(userId, docId);
    }

    private static void ListDocumentsByUserId(Library library)
    {
        Console.Write("Enter user ID: ");
        int userId = int.Parse(Console.ReadLine() ?? "-1");
        
        library.ListDocumentsByUserId(userId);
    }

    private static void IsDocumentIssued(Library library)
    {
        Console.Write("Enter document ID: ");
        int docId = int.Parse(Console.ReadLine() ?? "-1");
        
        library.IsDocumentIssued(docId);
    }
}
