{
    bool isOpen = true;
    
    string [,] books =
    {
        { "Pushkin", "Lermontov", "Tolstoy" },
        { "Austen", "Woolf", "Bronte" },
        { "Shakespeare", "Dickens", "Chaucer" }
    };

    while (isOpen)
    {
        Console.SetCursorPosition(0, 20);
        Console.WriteLine("\nAuthors list:\n");
        for (int i = 0; i < books.GetLength(0); i++)
        {
            for (int j = 0; j < books.GetLength(1); j++)
            {
                Console.Write(books[i, j] + " | ");
            }
            Console.WriteLine();
        }

        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Library");
        Console.WriteLine("\n1 - Get author`s name by book`s index.\n\n2 - Get book by author`s name.\n\n3 - Leave.\n");
        Console.Write("\nChoose an option:\n");

        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                int line, column;
                Console.Write("Enter line number: ");
                line = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Enter column number: ");
                column = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Author: " + books[line, column]);
                break;
            case 2:
                string author;
                bool authorIsFound = false;
                Console.Write("Enter authot`s last name: ");
                author = Console.ReadLine();
                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j <books.GetLength(1); j++)
                    {
                        if (author.ToLower() == books[i, j].ToLower())
                        {
                            Console.Write($"Author {books[i, j]} is located at the line {i + 1} column {j + 1}.");
                            authorIsFound = true;
                        }
                    }
                }
                if (authorIsFound == false)
                {
                    Console.WriteLine("Author doesn`t exist in the system.");
                }
                    break;
            case 3:
                isOpen = false;
                break;
            default:
                Console.WriteLine("Incorrect option.");
                break;
        }

        if (isOpen)
        {
            Console.WriteLine("\nPress any button to continue.\n");
        }

        Console.ReadKey();
        Console.Clear();
    }
}