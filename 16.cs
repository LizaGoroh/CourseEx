using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isOpen = true;

        Table[] tables = { new Table(1, 4), new Table(2, 8), new Table(3, 10) };

        while (isOpen)
        {
            Console.WriteLine("Cafe admin.\n");

            for(int i = 0; i < tables.Length; i++)
            {
                tables[i].ShowInfo();
            }

            Console.Write("\nEnter table number: ");
            int wishTabe = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("\nEnter number of seats to book: ");
            int desiredPlaces = Convert.ToInt32(Console.ReadLine());

            bool isReservationCompleted = tables[wishTabe].Reserve(desiredPlaces);

            if (isReservationCompleted)
            {
                Console.WriteLine("Reserved successfully.");
            }
            else
            {
                Console.WriteLine("Unsuccessful. Not enough seats.");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}

class Table
{
    public int Number;
    public int MaxPlaces;
    public int FreePlaces;

    public Table(int number, int maxPlaces)
    {
        Number = number;
        MaxPlaces = maxPlaces;
        FreePlaces = maxPlaces;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Table: {Number}. Seats available: {FreePlaces} of {MaxPlaces}.");
    }

    public bool Reserve(int places)
    {
        if (FreePlaces >= places)
        {
            FreePlaces -= places;
            return true;
        }
        else
        {
            return false;
        }
    }
}