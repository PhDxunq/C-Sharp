using Lesson5;

EmployeeManagement management = new EmployeeManagement();
while (true)
{
    Console.WriteLine("\n===== Employee Management Menu =====");
    Console.WriteLine("1. Input Employee");
    Console.WriteLine("2. Display All Employees");
    Console.WriteLine("3. Display Employee with Max Years Working");
    Console.WriteLine("4. Search Employee by Name");
    Console.WriteLine("5. Exit");
    Console.Write("Choose option: ");
    string choice = Console.ReadLine() ?? "5";

    switch (choice)
    {
        case "1":
            management.Input_Employee();
            break;
        case "2":
            management.Display_Employee();
            break;
        case "3":
            management.Display_Max_NumWork();
            break;
        case "4":
            management.Search_Employee();
            break;
        case "5":
            Console.WriteLine("Exiting program...");
            return;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
}