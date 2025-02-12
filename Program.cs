DisplayMenu();

void DisplayMenu()
{

    Console.WriteLine("**************");
    Console.WriteLine();
    Console.WriteLine("Menu:");
    Console.WriteLine();
    Console.WriteLine("1 - New Game");
    Console.WriteLine("2 - Load Game");
    Console.WriteLine("3 - Options");
    Console.WriteLine("4 - Quit");
    Console.WriteLine();
    Console.WriteLine("**************");

    HandleMenuChoice();
}

void HandleMenuChoice()
{
    bool validChoice = false;

    while (!validChoice)
    {
        Console.WriteLine("Please enter your choice:");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Starting a new game...");
                validChoice = true;
                // Add code to start a new game
                break;
            case "2":
                Console.WriteLine("Loading a game...");
                validChoice = true;
                // Add code to load a game
                break;
            case "3":
                Console.WriteLine("Opening options...");
                validChoice = true;
                // Add code to display options
                break;
            case "4":
                Console.WriteLine("Quitting...");
                validChoice = true;
                // Add code to quit the application
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}