using LAB8;
using LAB8.Library;
using LAB8.UsersAndDocs;

public static class UserMenu
    {
        public static void ManageUsers(Library librarySystem)
        {
            var managingUsers = true;
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
                var choice = Console.ReadLine() ?? "default value";

                switch (choice)
                {
                    case "1":
                        AddUser(librarySystem);
                        break;
                    case "2":
                        DeleteUser(librarySystem);
                        break;
                    case "3":
                        ChangeUserDetails(librarySystem);
                        break;
                    case "4":
                        librarySystem.ListAllUsers();
                        break;
                    case "5":
                        SortUsers(librarySystem);
                        break;
                    case "6":
                        ViewUserByID(librarySystem);
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

        private static void AddUser(Library librarySystem)
        {
            Console.Write("Enter name: ");
            var firstName = Console.ReadLine() ?? "default value";
            Console.Write("Enter last name: ");
            var lastName = Console.ReadLine() ?? "default value";
            Console.Write("Enter academic group: ");
            var academicGroup = Console.ReadLine() ?? "default value";
            librarySystem.AddUser(new User(firstName, lastName, academicGroup));
        }

        private static void DeleteUser(Library librarySystem)
        {
            librarySystem.ListAllUsers();
            Console.Write("Enter the user ID to delete: ");
            var deleteId = int.Parse(Console.ReadLine() ?? "default value");
            librarySystem.DeleteUser(deleteId);
        }

        private static void ChangeUserDetails(Library librarySystem)
        {
            librarySystem.ListAllUsers();
            Console.Write("Enter the user ID to change: ");
            var updateId = int.Parse(Console.ReadLine() ?? "default value");
            Console.Write("Enter a new name: ");
            var newFirstName = Console.ReadLine() ?? "default value";
            Console.Write("Enter a new last name: ");
            var newLastName = Console.ReadLine() ?? "default value";
            Console.Write("Enter a new academic group: ");
            var newAcademicGroup = Console.ReadLine() ?? "default value";
            librarySystem.UpdateUser(updateId, newFirstName, newLastName, newAcademicGroup);
        }

        private static void SortUsers(Library librarySystem)
        {
            Console.WriteLine("1. Sort by name (ascending)");
            Console.WriteLine("2. Sort by name (descending)");
            Console.WriteLine("3. Sort by last name (ascending)");
            Console.WriteLine("4. Sort by last name (descending)");
            Console.WriteLine("5. Sort by academic group (ascending)");
            Console.WriteLine("6. Sort by academic group (descending)");
            Console.Write("Select an option: ");
            var sortChoice = Console.ReadLine() ?? "default value";
            switch (sortChoice)
            {
                case "1":
                    librarySystem.SortUsersByFirstName(true);
                    break;
                case "2":
                    librarySystem.SortUsersByFirstName(false);
                    break;
                case "3":
                    librarySystem.SortUsersByLastName(true);
                    break;
                case "4":
                    librarySystem.SortUsersByLastName(false);
                    break;
                case "5":
                    librarySystem.SortUsersByAcademicGroup(true);
                    break;
                case "6":
                    librarySystem.SortUsersByAcademicGroup(false);
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again.");
                    break;
            }
        }

        private static void ViewUserByID(Library librarySystem)
        {
            Console.Write("Enter user ID: ");
            var userId = int.Parse(Console.ReadLine() ?? "default value");
            librarySystem.GetUserById(userId);
        }
    }

