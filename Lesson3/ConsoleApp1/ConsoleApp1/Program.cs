using ConsoleApp1;

CourseManager manager = new CourseManager();
bool running = true;

while (running)
{
    Console.WriteLine("=== COURSE ENROLLMENT MENU === ");
    Console.WriteLine("1. Add New Course / Online Course");
    Console.WriteLine("2. View All Courses");
    Console.WriteLine("3. Update Course Fee");
    Console.WriteLine("4. Delete Course");
    Console.WriteLine("5. Calculate Total Fee by Course ID");
    Console.WriteLine("6. Exit");
    Console.Write("Choose an option: ");

    try
    {
        int choice = int.Parse(Console.ReadLine() ?? "0");
        switch (choice)
        {
            case 1:
                manager.AddCourse();
                break;

            case 2:
                manager.ViewAllCourses();
                break;

            case 3:
                manager.UpdateCourse();
                break;

            case 4:
                manager.DeleteCourse();
                break;

            case 6:
                running = false;
                Console.WriteLine("Exiting...");
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}