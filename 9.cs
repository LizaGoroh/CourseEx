//практика random (игра, бой гладиаторов)

{
    Random rand = new Random();
    float health1 = rand.Next(90, 100);
    int damage1 = rand.Next(5, 20);
    int armor1 = rand.Next(25, 65);

    float health2 = rand.Next(80, 150);
    int damage2 = rand.Next(20, 40);
    int armor2 = rand.Next(60, 95);

    Console.WriteLine($"Player1 - health: {health1}, damage: {damage1}, armor: {armor1}.");
    Console.WriteLine($"Player2 - health: {health2}, damage: {damage2}, armor: {armor2}.");

    while (health1 > 0 && health2 > 0)
    {
        health1 -= Convert.ToSingle(rand.Next(0, damage2 +1)) / 100 * armor1;
        health2 -= Convert.ToSingle(rand.Next(0, damage1 +1)) / 100 * armor2;

        Console.WriteLine($"Player1 has {health1} health.");
        Console.WriteLine($"Player2 has {health2} health.");
    }

    if (health1 <= 0 && health2 <= 0)
    {
        Console.WriteLine("Draw");
    }
    else if (health1 <= 0)
    {
        Console.WriteLine("Player2 won");
    }
    else if (health2 <= 0)
    {
        Console.WriteLine("Player1 won");
    }
}
