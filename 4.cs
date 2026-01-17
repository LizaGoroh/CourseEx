using System.Diagnostics;
using System.Security.Authentication;
using System.Transactions;

{
    float rublesInWallet;
    float dollarsInWallet;

    int rubToUsd = 64, usdToRub = 66;

    float exchangeCurrencyCount;

    string desiredOperation;

    Console.WriteLine("Welcome!");
    
    Console.Write("Enter your Rub balance:");
    rublesInWallet = Convert.ToSingle(Console.ReadLine());

    Console.Write("Enter your Usd balance:");
    dollarsInWallet = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Choose operation:");
    Console.WriteLine("1. Exchange rubles for dollars");
    Console.WriteLine("2. Exchange dollars for rubles");
    Console.Write("Your choise:");
    desiredOperation = Console.ReadLine();

    switch (desiredOperation)
    {
        case "1":
        Console.WriteLine("Exchange rubles for dollars");
        Console.Write("Amount you want to exchange:");
        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
        if(rublesInWallet >= exchangeCurrencyCount)
            {
                rublesInWallet -= exchangeCurrencyCount;
                dollarsInWallet += exchangeCurrencyCount / rubToUsd;
            }
            else
            {
                Console.WriteLine("Unavailable.");
            }
            break;
        case "2":
        Console.WriteLine("Exchange dollars for rubles");
        Console.Write("Amount you want to exchange:");
        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
        if(dollarsInWallet >= exchangeCurrencyCount)
            {
                dollarsInWallet -= exchangeCurrencyCount;
                rublesInWallet += exchangeCurrencyCount * usdToRub;
            }
            else
            {
                Console.WriteLine("Unavailable.");
            }
            break;
        default:
        Console.WriteLine("Unknown operation.");
            break;
    }
    
    Console.WriteLine($"Your balance: {rublesInWallet} Rub, {dollarsInWallet} USD.");
}