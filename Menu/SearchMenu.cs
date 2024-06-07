using System;
using LAB8.Library;

public static class SearchMenu
{
    public static void Search(Library library)
    {
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("\nSearch Menu:");
            Console.WriteLine("1. Search Users by Keyword");
            Console.WriteLine("2. Search Documents by Keyword");
            Console.WriteLine("3. Return to Main Menu");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine() ?? "default value";

            switch (choice)
            {
                case "1":
                    SearchUsers(library);
                    break;
                case "2":
                    SearchDocuments(library);
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again.");
                    break;
            }
        }
    }

    private static void SearchUsers(Library library)
    {
        Console.Write("Enter keyword: ");
        string keyword = Console.ReadLine() ?? "";
        
        library.SearchUsersByKeyword(keyword);
    }

    private static void SearchDocuments(Library library)
    {
        Console.Write("Enter keyword: ");
        string keyword = Console.ReadLine() ?? "";
        
        library.SearchDocumentsByKeyword(keyword);
    }
}