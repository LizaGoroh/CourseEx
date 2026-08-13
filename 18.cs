//практика ООП (компьютерный клуб)

internal class Program
{
    private static void Main(string[] args)
    {
        ComputerClub computerClub = new ComputerClub(8);
        computerClub.Work();
    }
}

class ComputerClub
{
    private int _money = 0;
    private List<Computer> _computers = new List<Computer>();
    private Queue<Client> _clients = new Queue<Client>();
    public ComputerClub(int coputersCount)
    {
        Random random = new Random();
        for (int i = 0; i < coputersCount; i++)
        {
            _computers.Add(new Computer(random.Next(5, 15)));
        }
        CreateNewClient(25, random);
    }
    public void CreateNewClient(int count, Random random)
    {
        for (int i = 0; i < count; i++)
        {
            _clients.Enqueue(new Client(random.Next(100, 250), random));
        }
    }

    public void Work()
    {
        while (_clients.Count > 0 )
        {
            Client newClient = _clients.Dequeue();
            Console.WriteLine($"Computer club balance: ${_money}. Waiting for a new client.");
            Console.WriteLine($"You have a new clint. They want to buy {newClient.DesiredMinutes} minutes.");
            ShowAllComputersState();

            Console.Write("\nYou suggest computer number: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int computerNumber))
            {
                computerNumber -= 1;

                if (computerNumber >= 0 && computerNumber < _computers.Count)
                {
                    if (_computers[computerNumber].IsTaken)
                    {
                        Console.WriteLine("Computer is not available.");
                    }
                    else
                    {
                        if (newClient.CheckColvency(_computers[computerNumber]))
                        {
                            Console.WriteLine("Client has paid and take comuter number " + (computerNumber + 1));
                            _money += newClient.Pay();
                            _computers[computerNumber].BecomeTaken(newClient);
                        }
                        else
                        {
                            Console.WriteLine("Client can not pay for the computer.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input.");
                }
            }
            else
            {
                CreateNewClient(1, new Random());
                Console.WriteLine("Incorrect input.");
            }

            Console.WriteLine("Press any key to go to the next customer.");
            Console.ReadKey();
            Console.Clear();
            SpendOneMinute();
        }
    }

    private void ShowAllComputersState()
    {
        Console.WriteLine("\nComputer list:");
        for (int i = 0; i < _computers.Count; i++)
        {
            Console.Write(i + 1 + " - ");
            _computers[i].ShowState();
        }
    }

    private void SpendOneMinute()
    {
        foreach (var computer in _computers)
        {
            computer.SpendOneMinute();
        }
    }
}

class Computer
{
    private Client _client;
    private int _minutesRemaining;
    public bool IsTaken
    {
        get
        {
            return _minutesRemaining > 0;
        }
    }
    public int PricePerMinute{get; private set;}

    public Computer(int pricePerMinute)
    {
        PricePerMinute = pricePerMinute;
    }

    public void BecomeTaken(Client client)
    {
        _client = client;
        _minutesRemaining = _client.DesiredMinutes;
    }

    public void BecomeEmpty()
    {
        _client = null;
    }

    public void SpendOneMinute()
    {
        _minutesRemaining--;
    }

    public void ShowState()
    {
        if (IsTaken)
            Console.WriteLine($"Computer is taken, minutes remaining: {_minutesRemaining}.");
        else
            Console.WriteLine($"Computer is available, minute price: {PricePerMinute}.");
    }
}

class Client
{
    private int _money;
    private int _moneyToPay;
    public int DesiredMinutes {get; private set;}
    public Client(int money, Random random)
    {
        _money = money;
        DesiredMinutes = random.Next(10, 30);
    }
    public bool CheckColvency(Computer computer)
    {
        _moneyToPay = DesiredMinutes * computer.PricePerMinute;
        if (_money >= _moneyToPay)
        {
            return true;
        }
        else
        {
            _moneyToPay = 0;
            return false;
        }
    }

    public int Pay()
    {
        _money -= _moneyToPay;
        return _moneyToPay;
    }
}
