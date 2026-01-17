{
    int triesCount = 5;
    string password = "123456";
    string userInput;

    for(int i = 0; i < triesCount; i++)
    {
        Console.Write("Enter your password: ");
        userInput = Console.ReadLine();
        if (userInput == password)
        {
            Console.WriteLine("Correct.");
            break;
        }
        else
        {
            Console.WriteLine("Incorrect.");
            Console.WriteLine("You have " + (triesCount - (i + 1)) + " tries left.");
        }
    }
}