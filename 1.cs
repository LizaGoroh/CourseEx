{
    int health;
    int armor;
    int damage;
    int percentConverter = 100;

    Console.Write("Amount of health: ");
    health = Convert.ToInt32(Console.ReadLine());
    Console.Write("Amount of armor: ");
    armor = Convert.ToInt32(Console.ReadLine());
    Console.Write("Amount of damage: ");
    damage = Convert.ToInt32(Console.ReadLine());

    health -= damage * armor / percentConverter;

    Console.WriteLine($"You`ve got {damage} damage. You have left {health} health.");
}