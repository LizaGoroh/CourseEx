{
    int money;
    int food;
    int foodUnitPrice = 10;
    bool isAbletoPay;

    Console.WriteLine("Welcome to Bakery! Today`s price is " + foodUnitPrice + " coins.");
    Console.Write("How many coins do you have?");
    money = Convert.ToInt32(Console.ReadLine());
    Console.Write("How namy items do you want?");
    food = Convert.ToInt32(Console.ReadLine());

    isAbletoPay = money >= food * foodUnitPrice;
    food *= Convert.ToInt32(isAbletoPay);
    money -= food * foodUnitPrice;
    Console.WriteLine($"You have {food} items and {money} coins.");
}