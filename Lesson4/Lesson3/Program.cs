using Lesson3;

CatManagement catManager = new CatManagement();
int choice;

do
{
    Console.WriteLine("\n----- Cat Management Menu -----");
    Console.WriteLine("1. Input Cat information");
    Console.WriteLine("2. Display all Cats");
    Console.WriteLine("3. Find Cat by index");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");

    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
    {
        Console.Write("Invalid choice. Enter again: ");
    }

    switch (choice)
    {
        case 1:
            string cont;
            do
            {
                Cat cat = new Cat();
                cat.InputData();
                catManager.AddToList(cat);

                Console.Write("Do you want to continue to input data (yes/no)? ");
                cont = Console.ReadLine().ToLower();
            }
            while (cont == "yes");
            break;

        case 2:
            catManager.Display();
            break;

        case 3:
            Console.Write("Enter index of Cat to retrieve: ");
            if (int.TryParse(Console.ReadLine(), out int idx))
            {
                Cat foundCat = catManager[idx];
                if (foundCat != null)
                    foundCat.DisplayData();
            }
            else
            {
                Console.WriteLine("Invalid index input.");
            }
            break;

        case 4:
            Console.WriteLine("Exiting program...");
            break;
    }

} while (choice != 4);