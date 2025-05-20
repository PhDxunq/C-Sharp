using Lesson6;

TourManagement tourManagement = new TourManagement();
while (true)
{
    Console.WriteLine("=== TOUR MANAGEMENT MENU ===");
    Console.WriteLine("1. Add New Tour Package / Luxury Tour Package");
    Console.WriteLine("2. View All Tour Packages");
    Console.WriteLine("3. Update Tour Package Details");
    Console.WriteLine("4. Delete Tour Package");
    Console.WriteLine("5. Calculate Total Package Cost");
    Console.WriteLine("6. Exit");
    Console.Write("Your choice:");
    int choice = int.Parse(Console.ReadLine() ?? "1");
    switch (choice)
    {
        case 1:
            tourManagement.AddTourPackage();
            break;
        case 2:
            tourManagement.viewTourPackage(); 
            break;
        case 3:
            tourManagement.updateTourPackage();
            break;
        case 4:
            tourManagement.delTourPackage();
            break;
        case 5:
            ///
            break;
        case 6:
            Console.WriteLine("Exiting program...");
            break;
    }

}