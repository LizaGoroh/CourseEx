//практика переменных с типом random (игра "угадай число")

{
    int number;
    int lower, higher;
    int triesCount = 5;
    int userInput;
    Random rand = new Random();

    number = rand.Next(0, 101);
    lower = rand.Next(number - 10, number);
    higher = rand.Next(number + 1, number + 10);

    Console.WriteLine($"Guess the number between {lower} and {higher}.");
    Console.WriteLine($"You have {triesCount} tries.");

    while(triesCount-- > 0)
    {
        Console.Write("Your quess is: ");
        userInput = Convert.ToInt32(Console.ReadLine());
        if (userInput == number)
        {
            Console.WriteLine("You`re right!");
            break;
        }
        else
        {
            Console.WriteLine("No, try again.");
        }
    }

    if (triesCount < 0)
    {
    Console.WriteLine("You lose, it was number" + number + ".");
    }
}
