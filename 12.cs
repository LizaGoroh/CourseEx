using System.Diagnostics;

{
    int [] sectors = { 6, 28, 15, 15, 17};
    bool isOpen = true;

    while (isOpen)
    {
        Console.SetCursorPosition(0, 18);

        for (int i = 0; i < sectors.Length; i++)
        {
            Console.WriteLine($"In sector {i + 1} {sectors[i]} seats available.");
        }

        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Flight check-in.");

        Console.WriteLine("\n\n1 - to book a seat.\n\n2 - to leave the program.\n\n");
        Console.Write("Enter the command number:");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
            int userSector, userPlaceAmount;
            Console.Write("In which sector do you want to book a seat?");
            userSector = Convert.ToInt32(Console.ReadLine()) - 1;
            if(sectors.Length <= userSector || userSector < 0)
                {
                    Console.WriteLine("This sector doesn`t exist.");
                    break;
                }
            Console.Write("How namy seats do you want to book?");
            userPlaceAmount = Convert.ToInt32(Console.ReadLine());
            if(userPlaceAmount < 0)
                {
                    Console.WriteLine("Seats number is incorrect.");
                    break;
                }
            if(sectors[userSector] < userPlaceAmount)
                {
                    Console.WriteLine($"Sector {userSector} doesn`t contain enough seats. Seats left {sectors[userSector]}.");
                    break;
                }
            sectors[userSector] -= userPlaceAmount;
            Console.WriteLine("Booked successfully.");
                break;
            case 2:
            isOpen = false;
                break;
        }
    

        Console.ReadKey();
        Console.Clear();
    }
}