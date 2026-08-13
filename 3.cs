//Практическая задача для практики условных операторов

{
    string password = "123qwe";
    string userInput;

    Console.Write("Enter your password:");
    userInput = Console.ReadLine();

    if(userInput == password)
    {
        Console.WriteLine("Password is correct");
    }
    else
    {
        Console.WriteLine("Password is incorrect");
    }
}
