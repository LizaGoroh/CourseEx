//практика циклов (программа, которая считает как увеличился вклад по процентам)

{
    float money;
    int years;
    int percent;

    Console.Write("How much money do you want to keep?");
    money = Convert.ToSingle(Console.ReadLine());
    Console.Write("How many years do you want to keep them?");
    years = Convert.ToInt32(Console.ReadLine());
    Console.Write("At what percentage?");
    percent = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < years; i++)
    {
        money += money / 100 * percent;
        Console.WriteLine("This year you got" + money);
        Console.ReadKey();
    }
}
