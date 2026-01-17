{
    int playerHealth = 100;
    int playerDamage = 10;
    int enemyHealth = 50;
    int enemyDamage = 15;

    while (playerHealth > 0 && enemyHealth > 0)
    {
        playerHealth -= enemyDamage;
        enemyHealth -= playerDamage;

        Console.WriteLine(playerHealth + "player.");
        Console.WriteLine(enemyHealth + "enemy.");
    }

    if (playerHealth <= 0 && enemyHealth <= 0)
    {
        Console.WriteLine("Draw.");
    }
    else if (enemyHealth <= 0)
    {
        Console.WriteLine("Player won.");
    }
    else if (playerHealth <= 0)
    {
        Console.WriteLine("Enemy won.");
    }
}